namespace VendingMachine1._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBoxUbaciNovac = new System.Windows.Forms.GroupBox();
            this.RB10 = new System.Windows.Forms.RadioButton();
            this.RB20 = new System.Windows.Forms.RadioButton();
            this.RB50 = new System.Windows.Forms.RadioButton();
            this.RB100 = new System.Windows.Forms.RadioButton();
            this.RB200 = new System.Windows.Forms.RadioButton();
            this.TBoxUnesiCifru = new System.Windows.Forms.TextBox();
            this.BtnUbaci = new System.Windows.Forms.Button();
            this.LBalans = new System.Windows.Forms.Label();
            this.GBoxDodajArtikal = new System.Windows.Forms.GroupBox();
            this.RBA1 = new System.Windows.Forms.RadioButton();
            this.RBA2 = new System.Windows.Forms.RadioButton();
            this.RBA3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.FLPAutomat = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNKupi = new System.Windows.Forms.Button();
            this.GBoxUbaciNovac.SuspendLayout();
            this.GBoxDodajArtikal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxUbaciNovac
            // 
            this.GBoxUbaciNovac.Controls.Add(this.BtnUbaci);
            this.GBoxUbaciNovac.Controls.Add(this.TBoxUnesiCifru);
            this.GBoxUbaciNovac.Controls.Add(this.RB200);
            this.GBoxUbaciNovac.Controls.Add(this.RB100);
            this.GBoxUbaciNovac.Controls.Add(this.RB50);
            this.GBoxUbaciNovac.Controls.Add(this.RB20);
            this.GBoxUbaciNovac.Controls.Add(this.RB10);
            this.GBoxUbaciNovac.Location = new System.Drawing.Point(496, 221);
            this.GBoxUbaciNovac.Name = "GBoxUbaciNovac";
            this.GBoxUbaciNovac.Size = new System.Drawing.Size(256, 182);
            this.GBoxUbaciNovac.TabIndex = 0;
            this.GBoxUbaciNovac.TabStop = false;
            this.GBoxUbaciNovac.Text = "UbaciNovac";
            // 
            // RB10
            // 
            this.RB10.AutoSize = true;
            this.RB10.Location = new System.Drawing.Point(29, 35);
            this.RB10.Name = "RB10";
            this.RB10.Size = new System.Drawing.Size(54, 17);
            this.RB10.TabIndex = 0;
            this.RB10.TabStop = true;
            this.RB10.Text = "10 rsd";
            this.RB10.UseVisualStyleBackColor = true;
            // 
            // RB20
            // 
            this.RB20.AutoSize = true;
            this.RB20.Location = new System.Drawing.Point(29, 59);
            this.RB20.Name = "RB20";
            this.RB20.Size = new System.Drawing.Size(54, 17);
            this.RB20.TabIndex = 1;
            this.RB20.TabStop = true;
            this.RB20.Text = "20 rsd";
            this.RB20.UseVisualStyleBackColor = true;
            // 
            // RB50
            // 
            this.RB50.AutoSize = true;
            this.RB50.Location = new System.Drawing.Point(29, 82);
            this.RB50.Name = "RB50";
            this.RB50.Size = new System.Drawing.Size(54, 17);
            this.RB50.TabIndex = 2;
            this.RB50.TabStop = true;
            this.RB50.Text = "50 rsd";
            this.RB50.UseVisualStyleBackColor = true;
            // 
            // RB100
            // 
            this.RB100.AutoSize = true;
            this.RB100.Location = new System.Drawing.Point(149, 35);
            this.RB100.Name = "RB100";
            this.RB100.Size = new System.Drawing.Size(60, 17);
            this.RB100.TabIndex = 3;
            this.RB100.TabStop = true;
            this.RB100.Text = "100 rsd";
            this.RB100.UseVisualStyleBackColor = true;
            // 
            // RB200
            // 
            this.RB200.AutoSize = true;
            this.RB200.Location = new System.Drawing.Point(149, 59);
            this.RB200.Name = "RB200";
            this.RB200.Size = new System.Drawing.Size(60, 17);
            this.RB200.TabIndex = 4;
            this.RB200.TabStop = true;
            this.RB200.Text = "200 rsd";
            this.RB200.UseVisualStyleBackColor = true;
            // 
            // TBoxUnesiCifru
            // 
            this.TBoxUnesiCifru.Location = new System.Drawing.Point(134, 82);
            this.TBoxUnesiCifru.Name = "TBoxUnesiCifru";
            this.TBoxUnesiCifru.Size = new System.Drawing.Size(100, 20);
            this.TBoxUnesiCifru.TabIndex = 5;
            this.TBoxUnesiCifru.Text = "Unesi cifru";
            this.TBoxUnesiCifru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBoxUnesiCifru.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TBoxUnesiCifru_MouseClick);
            this.TBoxUnesiCifru.TextChanged += new System.EventHandler(this.TBoxUnesiCifru_TextChanged);
            this.TBoxUnesiCifru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBoxUnesiCifru_KeyPress);
            // 
            // BtnUbaci
            // 
            this.BtnUbaci.Location = new System.Drawing.Point(77, 125);
            this.BtnUbaci.Name = "BtnUbaci";
            this.BtnUbaci.Size = new System.Drawing.Size(115, 43);
            this.BtnUbaci.TabIndex = 6;
            this.BtnUbaci.Text = "Ubaci";
            this.BtnUbaci.UseVisualStyleBackColor = true;
            this.BtnUbaci.Click += new System.EventHandler(this.BtnUbaci_Click);
            // 
            // LBalans
            // 
            this.LBalans.AutoSize = true;
            this.LBalans.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBalans.Location = new System.Drawing.Point(515, 86);
            this.LBalans.Name = "LBalans";
            this.LBalans.Size = new System.Drawing.Size(202, 33);
            this.LBalans.TabIndex = 1;
            this.LBalans.Text = "Balans = 0 rsd";
            // 
            // GBoxDodajArtikal
            // 
            this.GBoxDodajArtikal.Controls.Add(this.button1);
            this.GBoxDodajArtikal.Controls.Add(this.RBA3);
            this.GBoxDodajArtikal.Controls.Add(this.RBA2);
            this.GBoxDodajArtikal.Controls.Add(this.RBA1);
            this.GBoxDodajArtikal.Location = new System.Drawing.Point(55, 221);
            this.GBoxDodajArtikal.Name = "GBoxDodajArtikal";
            this.GBoxDodajArtikal.Size = new System.Drawing.Size(116, 182);
            this.GBoxDodajArtikal.TabIndex = 2;
            this.GBoxDodajArtikal.TabStop = false;
            this.GBoxDodajArtikal.Text = "Dodaj artikal";
            // 
            // RBA1
            // 
            this.RBA1.AutoSize = true;
            this.RBA1.Location = new System.Drawing.Point(7, 35);
            this.RBA1.Name = "RBA1";
            this.RBA1.Size = new System.Drawing.Size(101, 17);
            this.RBA1.TabIndex = 0;
            this.RBA1.TabStop = true;
            this.RBA1.Text = "Artikal 1 : 70 rsd";
            this.RBA1.UseVisualStyleBackColor = true;
            // 
            // RBA2
            // 
            this.RBA2.AutoSize = true;
            this.RBA2.Location = new System.Drawing.Point(7, 59);
            this.RBA2.Name = "RBA2";
            this.RBA2.Size = new System.Drawing.Size(107, 17);
            this.RBA2.TabIndex = 1;
            this.RBA2.TabStop = true;
            this.RBA2.Text = "Artikal 2 : 100 rsd";
            this.RBA2.UseVisualStyleBackColor = true;
            // 
            // RBA3
            // 
            this.RBA3.AutoSize = true;
            this.RBA3.Location = new System.Drawing.Point(7, 83);
            this.RBA3.Name = "RBA3";
            this.RBA3.Size = new System.Drawing.Size(101, 17);
            this.RBA3.TabIndex = 2;
            this.RBA3.TabStop = true;
            this.RBA3.Text = "Artikal 3 : 40 rsd";
            this.RBA3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FLPAutomat
            // 
            this.FLPAutomat.Location = new System.Drawing.Point(220, 48);
            this.FLPAutomat.Name = "FLPAutomat";
            this.FLPAutomat.Size = new System.Drawing.Size(236, 275);
            this.FLPAutomat.TabIndex = 3;
            // 
            // BTNKupi
            // 
            this.BTNKupi.Location = new System.Drawing.Point(285, 346);
            this.BTNKupi.Name = "BTNKupi";
            this.BTNKupi.Size = new System.Drawing.Size(110, 43);
            this.BTNKupi.TabIndex = 4;
            this.BTNKupi.Text = "Kupi";
            this.BTNKupi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNKupi);
            this.Controls.Add(this.FLPAutomat);
            this.Controls.Add(this.GBoxDodajArtikal);
            this.Controls.Add(this.LBalans);
            this.Controls.Add(this.GBoxUbaciNovac);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Automat";
            this.GBoxUbaciNovac.ResumeLayout(false);
            this.GBoxUbaciNovac.PerformLayout();
            this.GBoxDodajArtikal.ResumeLayout(false);
            this.GBoxDodajArtikal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxUbaciNovac;
        private System.Windows.Forms.TextBox TBoxUnesiCifru;
        private System.Windows.Forms.RadioButton RB200;
        private System.Windows.Forms.RadioButton RB100;
        private System.Windows.Forms.RadioButton RB50;
        private System.Windows.Forms.RadioButton RB20;
        private System.Windows.Forms.RadioButton RB10;
        private System.Windows.Forms.Button BtnUbaci;
        private System.Windows.Forms.Label LBalans;
        private System.Windows.Forms.GroupBox GBoxDodajArtikal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RBA3;
        private System.Windows.Forms.RadioButton RBA2;
        private System.Windows.Forms.RadioButton RBA1;
        private System.Windows.Forms.FlowLayoutPanel FLPAutomat;
        private System.Windows.Forms.Button BTNKupi;
    }
}

