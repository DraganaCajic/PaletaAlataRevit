using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Analysis;
namespace PaletaAlataRevit
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand

    { 
        public int brojParam;
        public List<string> nazivParam;
        public List<string> vrijednostiParam;
        public string namjestaj;
        public string sprat;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiap = commandData.Application;
            UIDocument docum = uiap.ActiveUIDocument;
            Application app = uiap.Application;
            Document doc = docum.Document;
            PocetnaForma forma = new PocetnaForma();
            forma.ShowDialog();
            List<Room> sobe = new List<Room>();
            DodjelaBroja broj = new DodjelaBroja();

            int levelNumber = 0;
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ICollection<Element> collection = collector.OfClass(typeof(Level)).ToElements();
            foreach (Element e in collection)
            {
                levelNumber++;
            }

            if (forma.opcija == 1)
            {
                string rezultat = "Lista soba i njhovih brojeva:\n";
                broj.ShowDialog();
                if (broj.opcija == 1)
                {
                    int pocetni = broj.pocetni;
                    using (Transaction tr = new Transaction(doc))
                    {
                        int level = 1;
                        int brojSoba = 0;
                        tr.Start("Transaction");
                        for (int i = 0; i < levelNumber; i++)
                        {
                            foreach (Room soba in getRooms(doc))
                            {
                                if (soba.Level.Name == "Level " + level.ToString())
                                {

                                    soba.Number = pocetni.ToString();
                                    sobe.Add(soba);
                                    rezultat += soba.Name + " " + soba.Level.Name + "\n";
                                    pocetni++;
                                    brojSoba++;

                                }

                            }
                            level++;
                        }
                    
                        TaskDialog.Show("Sobe", rezultat);

                        tr.Commit();
                    }
                }
              

            }
            if(forma.opcija==2)
            {
                
                View currentView =docum.ActiveView;
                string viewname = currentView.Name.ToString();
                int j = 0;
                for (int i = 1; i < levelNumber; i++)
                {
                    
                    if (viewname == "Level " + i)
                    {
                        j++;
                        FilteredElementCollector furniture = new FilteredElementCollector(doc)
                        .WherePasses(new ElementCategoryFilter(BuiltInCategory.OST_Furniture))
                         .WhereElementIsNotElementType();
                        namjestaj = "";
                        foreach (Element element in furniture)
                        {

                            Level level = element.Document.GetElement(element.LevelId) as Level;
                            Element elemType = doc.GetElement(element.GetTypeId());
                            if (level.Name == viewname)
                                namjestaj += element.Name +  "\n";
                            sprat = level.Name;
                        }
                       
                    }


                }
                if(j>0)
                {
                    Namjestaj formaNamjestaj = new Namjestaj(namjestaj, sprat);
                    formaNamjestaj.ShowDialog();
                }
                
                else
                {
                    TaskDialog.Show("Poruka", "U aktivnom pogledu treba biti željeni level!");
                }

            }
            if(forma.opcija==3)
            {
              
                Selection selekcija = commandData.Application.ActiveUIDocument.Selection;
                ICollection<ElementId> idSelekcije = docum.Selection.GetElementIds();
                
                foreach (ElementId id in idSelekcije)
                {
                    Element element = doc.GetElement(id);
                    int brojParam = element.Parameters.Size;
                    nazivParam = new List<string>();
                    vrijednostiParam = new List<string>();
                    
                    int j = 0;
                    foreach (Parameter parameter in element.Parameters)
                    {
                        nazivParam.Insert(j, (GetParameterName(parameter, doc)));      
                        vrijednostiParam.Insert(j, (GetParameterValue(parameter, doc)));
                         
                        j++;
                    }
                    Parametri param = new Parametri(nazivParam, vrijednostiParam, brojParam);
                    foreach (Parameter parameter in element.Parameters)
                    {
                      for(int s=0;s<brojParam;s++)
                        {
                           if(s==param.broj)
                            {
                                using (Transaction tr = new Transaction(doc))
                                {
                                    tr.Start("Transakcija");
                              //     parameter.SetValueString(vrijednostiParam[s]);
                              //Dobijam poruku da su paramteri read-only
                                    tr.Commit();
                                }
                            }
                        }          

                    }

                    param.ShowDialog();
                }

            }

            return Autodesk.Revit.UI.Result.Succeeded;
        }
        
        public List<Room> getRooms(Document doc)
        {

            ElementCategoryFilter filter = new ElementCategoryFilter(BuiltInCategory.OST_Rooms);
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            IList<Element> rooms = collector.WherePasses(filter).WhereElementIsNotElementType().ToElements();
            List<Room> rooms_list = new List<Room>();
            foreach (Room room in rooms)
            {
                rooms_list.Add(room);
            }
            return rooms_list;
        }
       public  string GetParameterName(Parameter para, Document document)
        {
            string defName = para.Definition.Name.ToString(); ;
          
            return defName;
        }
       public String GetParameterValue(Parameter para, Document document)
        {
            string value = "";
          
             switch (para.StorageType)
              {
                  case StorageType.Double:
                      
                     value +=  para.AsValueString();

                      break;
                  case StorageType.ElementId:
                      Autodesk.Revit.DB.ElementId id = para.AsElementId();
                      if (id.IntegerValue >= 0)
                      {
                          value += document.GetElement(id).Name;
                      }
                      else
                      {
                          value +=  id.IntegerValue.ToString();
                      }
                      break;
                  case StorageType.Integer:
                      if (ParameterType.YesNo == para.Definition.ParameterType)
                      {
                          if (para.AsInteger() == 0)
                          {
                              value +=  "False";
                          }
                          else
                          {
                            value += "True";
                          }
                      }
                      else
                      {
                        value += para.AsInteger().ToString();
                      }
                      break;
                  case StorageType.String:
                    value +=  para.AsString();
                      break;
                  default:
                    value = "Unexposed parameter.";
                      break;
              }

            return value;
        }
       
    }
}
