using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine1._1
{
    public partial class CenaPopup : Form
    {
        int cena;
        public static Kasa kupac;
        Automat automat;
        public static bool proslo=true;
        public CenaPopup(int cena, Kasa kupac,Automat automat)
        {
            this.cena = cena;
            CenaPopup.kupac = kupac;
            this.automat = automat;
            InitializeComponent();
            LblCena.Text = "Cena: " + cena; 
        }

        private void BtnKupi_Click(object sender, EventArgs e)
        {
            automat.dodajNovcanice(kupac.dajNovcanice());
            if (kupac.Novac < cena) { MessageBox.Show("Nemate dovoljno para"); proslo=false; this.Close(); }
            
             int delta = kupac.Novac - cena;
             kupac = new Kasa();
             kupac.dodajNovcanice(automat.oduzmiNovac(delta));
             proslo = true;
            
        }

        private void CenaPopup_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BtnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
