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
        public AdminPage(string ime)
        {
            InitializeComponent();
            if (!Directory.Exists(@"Automati"))
            {
                Directory.CreateDirectory(@"Automati");
            }

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.instanca.Close();
        }
    }
}
