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
    public partial class RegistracijaAdmina : Form
    {
        public static bool registracijaUspesna = true;
        public static int razlogNeuspeha = -1;
        public RegistracijaAdmina()
        {
            InitializeComponent();
        }

        private void RegistracijaAdmina_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.instanca.Show();
        }

        private void BtnRegistrujteSe_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"admini.txt"))
            {
                StreamWriter a = new StreamWriter(@"admini.txt", append: true);
                a.Close();
                a.Dispose();
            }
            StreamReader citac = new StreamReader(@"admini.txt");
            string nln = citac.ReadLine();
            while (nln != null)
            {
                if (TBoxKorisnickoIme.Text == nln.Split(' ')[0])
                {
                    registracijaUspesna = false;
                    razlogNeuspeha = 1;
                }
                nln = citac.ReadLine();
            }
            citac.Close();
            citac.Dispose();






            StreamWriter admini = new StreamWriter(@"admini.txt",append:true);
            
            if(TBoxKorisnickoIme.Text == "" || TBoxLozinka.Text == "")
            {
                registracijaUspesna = false;
                razlogNeuspeha = 2;
            }
            else if(TBoxLozinka.Text != TBoxPonovoLozinka.Text)
            {
                registracijaUspesna = false;
                razlogNeuspeha = 3;
            }
            else if(TBoxKorisnickoIme.Text.Contains(" ") || TBoxLozinka.Text.Contains(" "))
            {
                registracijaUspesna = false;
                razlogNeuspeha = 4;
            }
            if (registracijaUspesna)
            {
                admini.WriteLine(TBoxKorisnickoIme.Text + " " + TBoxLozinka.Text);
            }
            admini.Close();
            admini.Dispose();
            RegistracijaPopUp popup = new RegistracijaPopUp();
            popup.Show();
            this.Close();
        }
    }
}
