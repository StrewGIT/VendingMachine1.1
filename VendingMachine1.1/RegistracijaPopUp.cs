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
    public partial class RegistracijaPopUp : Form
    {
        public RegistracijaPopUp()
        {
            InitializeComponent();
            if(RegistracijaAdmina.registracijaUspesna == false)
            {
                LblRegistracijaUspesna.Text = "Registracija neuspesna";
                LblRegistracijaUspesna.ForeColor = Color.Red;
                LblRegistracijaUspesna.Location = new Point((this.Size.Width - LblRegistracijaUspesna.Size.Width) / 2 - 5, LblRegistracijaUspesna.Location.Y);
                switch (RegistracijaAdmina.razlogNeuspeha)
                {
                    case (1): LblRazlogNeuspeha.Text = "Dato korisničko ime već postoji";break;
                    case (2): LblRazlogNeuspeha.Text = "Korisničko ime i lozinka ne mogu biti prazni";break;
                    case (3): LblRazlogNeuspeha.Text = "Lozinke moraju da se poklapaju";break;
                    case (4): LblRazlogNeuspeha.Text = "Zabranjeno korišćenje blanko karaktera";break;
                }
                LblRazlogNeuspeha.Location = new Point((this.Size.Width - LblRazlogNeuspeha.Size.Width) / 2, LblRazlogNeuspeha.Location.Y);
            }
        }

        private void RegistracijaPopUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegistracijaAdmina regAd = new RegistracijaAdmina();
            //regAd.Location = new Point(Form2.instanca.Location.X + Form2.instanca.Size.Width / 2, Form2.instanca.Location.Y + Form2.instanca.Size.Height / 2);
            regAd.Show();
        }
    }
}
