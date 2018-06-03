using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PaletaAlataRevit
{
    public partial class Parametri : Form
    {
        public List<string> vrijednostParam;
      public  int broj;
       public  string novaVrijednost;
        
        public Parametri(List<string> imena, List<string> vrijednosti, int brojParametara)
        {

            InitializeComponent();
            lb.Visible = false;
            tb.Visible = false;
            btnPromijeni.Visible = false;
            
            vrijednostParam = new List<string>();
            foreach (string vr in vrijednosti)
            {
                vrijednostParam.Add(vr);
            }
            lblBroj.Text += brojParametara.ToString();

            for (int i = 0; i < brojParametara; i++)
            {

                clbParametri.Items.Add(imena[i]);

            }

        }   

        private void clbParametri_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            for (int x = 0; x < clbParametri.Items.Count; ++x)
            {
                
                lb.Visible = true;
                
                tb.Visible = true;
                btnPromijeni.Visible = true;
           
                tb.Text = (vrijednostParam[Convert.ToInt32(clbParametri.SelectedIndex)]).ToString();
                broj = clbParametri.SelectedIndex;
                if (x != e.Index)
                {
                   
                    clbParametri.SetItemChecked(x, false);
                    
                }
            
            }

        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            novaVrijednost = tb.Text.ToString();
            vrijednostParam[Convert.ToInt32(clbParametri.SelectedIndex)] = tb.Text.ToString(); ;
        }
    }
}
    
