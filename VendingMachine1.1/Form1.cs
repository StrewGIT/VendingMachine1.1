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
    public partial class Form1 : Form
    {
        static int balans = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TBoxUnesiCifru_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TBoxUnesiCifru_MouseClick(object sender, MouseEventArgs e)
        {
            RB10.Checked = false;
            RB20.Checked = false;
            RB50.Checked = false;
            RB100.Checked = false;
            RB200.Checked = false;
            TBoxUnesiCifru.Text = "";
        }

        private void BtnUbaci_Click(object sender, EventArgs e)
        {
            if (RB10.Checked) { balans += 10; }
            else if (RB20.Checked) { balans += 20; }
            else if (RB50.Checked) { balans += 50; }
            else if (RB100.Checked) { balans += 100; }
            else if (RB200.Checked) { balans += 200; }
            else if (TBoxUnesiCifru.Text != "Unesi cifru") { balans += int.Parse(TBoxUnesiCifru.Text); }
            LBalans.Text = "Balans = " + balans + " rsd";
        }

        private void TBoxUnesiCifru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RBA1.Checked)
            {
                Button btn = new Button();
                btn.Text = "1";
                btn.Width = FLPAutomat.Width/3 -10;
                FLPAutomat.Controls.Add(btn);
            }
            else if (RBA2.Checked)
            {
                Button btn = new Button();
                btn.Text = "2";
                btn.Width = FLPAutomat.Width / 3 - 10;
                FLPAutomat.Controls.Add(btn);
            }
            else if (RBA3.Checked)
            {
                Button btn = new Button();
                btn.Text = "3";
                btn.Width = FLPAutomat.Width / 3 - 10;
                FLPAutomat.Controls.Add(btn);
            }
        }
    }
}
