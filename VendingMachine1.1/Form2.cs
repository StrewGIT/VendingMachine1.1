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
    public partial class Form2 : Form
    {
        public static Form2 instanca;
        public Form2()
        {
            InitializeComponent();
            instanca = this;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistracijaAdmina registracijaAdmina = new RegistracijaAdmina();
            registracijaAdmina.Show();
            //this.Hide();
        }

        private void BtnUlogujSe_Click(object sender, EventArgs e)
        {
            StreamReader citac = new StreamReader(@"admini.txt");
            string lnl = citac.ReadLine();
            while (lnl != null)
            {
                string ime = lnl.Split(' ')[0];
                string lozinka = lnl.Split(' ')[1];
                if(TBoxKorisnickoIme.Text == ime && TBoxLozinka.Text == lozinka)
                {
                    AdminPage adminStrana = new AdminPage(ime);
                    adminStrana.Show();
                    this.Hide();
                }
                lnl = citac.ReadLine();
            }
            LblPogresanLogin.Text = "Pogrešno korisničko ime ili lozinka";
            LblPogresanLogin.ForeColor = Color.Red;
            citac.Close();
            citac.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
