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
    public partial class DodjelaBroja : Form
    {
        public int pocetni;
        public int opcija;


        public DodjelaBroja()
        {
            InitializeComponent();
           
         }

        private void button1_Click(object sender, EventArgs e)
        {
           pocetni = Convert.ToInt32(txtPocetniBoj.Text);
            opcija = 1;
           this.Dispose();
        }

        private void btnAutomatski_Click(object sender, EventArgs e)
        {
            pocetni = 100;
            opcija = 1;
            this.Dispose();
        }

        private void DodjelaBroja_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
