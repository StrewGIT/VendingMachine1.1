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
    public partial class KupacOdabir : Form
    {
        public KupacOdabir()
        {
            InitializeComponent();
            DirectoryInfo folder = new DirectoryInfo(@"Automati");
            FileInfo[] admini = folder.GetFiles("*.txt");
            foreach(var admin in admini)
            {
                Button dugme = new Button();
                dugme.Click += new EventHandler(dugme_OnClick);
                dugme.Text = admin.Name.Split('.')[0];
                dugme.Size = new Size(100, 50);
                FLPAdmini.Controls.Add(dugme);
            }
        }
        void dugme_OnClick(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            KupacPage kupacPage = new KupacPage(btn.Text);
            this.Hide();
            kupacPage.Show();
        }

        private void KupacOdabir_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.instanca.Close();
        }
    }
    class DugmeOdabir : Button
    {
        
    }
}
