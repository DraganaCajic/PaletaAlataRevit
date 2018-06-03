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
    public partial class PocetnaForma : Form
    {
        public int pocetni;
        public int opcija;
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void btnBrojSobe_Click(object sender, EventArgs e)
        {
            
            
            this.Dispose();
            opcija = 1;

        }

        private void btnNamjestaj_Click(object sender, EventArgs e)
        {
            this.Dispose();
            opcija = 2;
        }

        private void btnParametri_Click(object sender, EventArgs e)
        {
            this.Dispose();
            opcija = 3;
        }
    }
}
