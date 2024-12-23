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
    public partial class KupacPage : Form
    {
        Kasa kasa = new Kasa();
        public KupacPage(string ime)
        {
            InitializeComponent();
            Automat automat = new Automat(ime);
            for (int i = 0; i < automat.Duzina(); i++)
            {
                PictureBox slika = new PictureBox();
                slika.Load(automat.getUrl(i));
                slika.Size = new Size(50, 50);
                slika.SizeMode = PictureBoxSizeMode.StretchImage;
                FLPAutomat.Controls.Add(slika);
            }
        }

        private void BtnUbaci_Click(object sender, EventArgs e)
        {
            if (RB5.Checked) { kasa.dodajNovac(5); }
            else if (RB10.Checked) { kasa.dodajNovac(10); }
            else if (RB20.Checked) { kasa.dodajNovac(20); }
            else if (RB50.Checked) { kasa.dodajNovac(50); }
            else if (RB100.Checked) { kasa.dodajNovac(100); }
            else if (RB200.Checked) { kasa.dodajNovac(200); }
            LblBalansAutomata.Text = $"Balans automata: {kasa.Novac}";
        }
    }
}
