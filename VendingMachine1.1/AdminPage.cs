using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace VendingMachine1._1
{
    
    public partial class AdminPage : Form
    {
        Automat automat;
        string ime;
        public AdminPage(string ime)
        {
            this.ime = ime;
            InitializeComponent();
            automat = new Automat(ime);
            LblBalansAutomata.Text = $"Balans automata: {automat.Novac()}";
            for(int i = 0; i < automat.Duzina(); i++)
            {
                PictureBox slika = new PictureBox();
                slika.Load(automat.getUrl(i));
                slika.Size = new Size(50, 50);
                slika.SizeMode = PictureBoxSizeMode.StretchImage;
                FLPAutomat.Controls.Add(slika);
            }
            StreamReader citac = new StreamReader(@"..\..\tabelaArtikala.txt");
            string nln = citac.ReadLine();
            while(nln != null)
            {
                LBoxArtikli.Items.Add(nln.Split(' ')[0]);
                nln = citac.ReadLine();
            }
            citac.Close();
            citac.Dispose();
            
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            automat.Save();
            Form2.instanca.Close();
        }

        private void RB100_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnUbaci_Click(object sender, EventArgs e)
        {
            if (RB5.Checked) { automat.dodajNovac(5); }
            else if (RB10.Checked) { automat.dodajNovac(10); }
            else if (RB20.Checked) { automat.dodajNovac(20); }
            else if (RB50.Checked) { automat.dodajNovac(50); }
            else if (RB100.Checked) { automat.dodajNovac(100); }
            else if (RB200.Checked) { automat.dodajNovac(200); }
            LblBalansAutomata.Text = $"Balans automata: {automat.Novac()}";
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            automat.dodajArtikal(LBoxArtikli.SelectedIndex);
            PictureBox slika = new PictureBox();
            slika.Load(automat.getUrl(LBoxArtikli.SelectedIndex));
            slika.Size = new Size(50, 50);
            slika.SizeMode = PictureBoxSizeMode.StretchImage;
            FLPAutomat.Controls.Add(slika);
        }
    }
    
}
