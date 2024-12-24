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
        Automat automat ;
        PictureBox pritisnut;
        public KupacPage(string ime)
        {
            InitializeComponent();
            automat = new Automat(ime);
            for (int i = 0; i < automat.Duzina(); i++)
            {
                PictureBox slika = new PictureBox();
                slika.Load(automat.getUrl(i));
                slika.Size = new Size(50, 50);
                slika.SizeMode = PictureBoxSizeMode.StretchImage;
                slika.Click += new EventHandler(slika_OnClick);
                slika.MinimumSize = new Size(automat.getID(i),i);
                FLPAutomat.Controls.Add(slika);
            }
        }
        void slika_OnClick(object sender, EventArgs e)
        {
            PictureBox slika = (PictureBox)sender;
            CenaPopup cp = new CenaPopup(automat.idToCena(slika.MinimumSize.Width), kasa, automat);
            cp.Show();
            cp.FormClosed += new FormClosedEventHandler(cp_FormClosed);
            pritisnut = slika;
        }
        void cp_FormClosed(object sender,EventArgs e)
        {
            if (CenaPopup.proslo)
            {
                kasa = new Kasa();
                automat.oduzmiArtikal(pritisnut.MaximumSize.Height);
                pritisnut.Dispose();
                LblBalansAutomata.Text = $"Balans: {kasa.Novac}";
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
            LblBalansAutomata.Text = $"Balans: {kasa.Novac}";
        }

        private void KupacPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.instanca.Close();
            automat.Save();
        }
    }
}
