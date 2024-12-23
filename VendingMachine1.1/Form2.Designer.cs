
namespace VendingMachine1._1
{
    partial class Form2
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
            this.LblDobrodosli = new System.Windows.Forms.Label();
            this.LblUkucajteAdminskuSifruIliUdjiteKaoKupac = new System.Windows.Forms.Label();
            this.BtnKupac = new System.Windows.Forms.Button();
            this.GBoxAdminLogin = new System.Windows.Forms.GroupBox();
            this.LblPogresanLogin = new System.Windows.Forms.Label();
            this.BtnUlogujSe = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TBoxLozinka = new System.Windows.Forms.TextBox();
            this.LblLozinka = new System.Windows.Forms.Label();
            this.LblKorisnickoIme = new System.Windows.Forms.Label();
            this.TBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.GBoxAdminLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDobrodosli
            // 
            this.LblDobrodosli.AutoSize = true;
            this.LblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDobrodosli.Location = new System.Drawing.Point(277, 62);
            this.LblDobrodosli.Name = "LblDobrodosli";
            this.LblDobrodosli.Size = new System.Drawing.Size(264, 55);
            this.LblDobrodosli.TabIndex = 0;
            this.LblDobrodosli.Text = "Dobrodošli";
            // 
            // LblUkucajteAdminskuSifruIliUdjiteKaoKupac
            // 
            this.LblUkucajteAdminskuSifruIliUdjiteKaoKupac.AutoSize = true;
            this.LblUkucajteAdminskuSifruIliUdjiteKaoKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUkucajteAdminskuSifruIliUdjiteKaoKupac.Location = new System.Drawing.Point(220, 134);
            this.LblUkucajteAdminskuSifruIliUdjiteKaoKupac.Name = "LblUkucajteAdminskuSifruIliUdjiteKaoKupac";
            this.LblUkucajteAdminskuSifruIliUdjiteKaoKupac.Size = new System.Drawing.Size(377, 25);
            this.LblUkucajteAdminskuSifruIliUdjiteKaoKupac.TabIndex = 1;
            this.LblUkucajteAdminskuSifruIliUdjiteKaoKupac.Text = "Ukucajte adminsku šifru ili uđite kao kupac";
            // 
            // BtnKupac
            // 
            this.BtnKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKupac.Location = new System.Drawing.Point(472, 273);
            this.BtnKupac.Name = "BtnKupac";
            this.BtnKupac.Size = new System.Drawing.Size(178, 75);
            this.BtnKupac.TabIndex = 2;
            this.BtnKupac.Text = "Udjite kao kupac";
            this.BtnKupac.UseVisualStyleBackColor = true;
            // 
            // GBoxAdminLogin
            // 
            this.GBoxAdminLogin.Controls.Add(this.LblPogresanLogin);
            this.GBoxAdminLogin.Controls.Add(this.BtnUlogujSe);
            this.GBoxAdminLogin.Controls.Add(this.linkLabel1);
            this.GBoxAdminLogin.Controls.Add(this.TBoxLozinka);
            this.GBoxAdminLogin.Controls.Add(this.LblLozinka);
            this.GBoxAdminLogin.Controls.Add(this.LblKorisnickoIme);
            this.GBoxAdminLogin.Controls.Add(this.TBoxKorisnickoIme);
            this.GBoxAdminLogin.Location = new System.Drawing.Point(185, 216);
            this.GBoxAdminLogin.Name = "GBoxAdminLogin";
            this.GBoxAdminLogin.Size = new System.Drawing.Size(233, 201);
            this.GBoxAdminLogin.TabIndex = 3;
            this.GBoxAdminLogin.TabStop = false;
            this.GBoxAdminLogin.Text = "Admin log-in";
            // 
            // LblPogresanLogin
            // 
            this.LblPogresanLogin.AutoSize = true;
            this.LblPogresanLogin.Location = new System.Drawing.Point(5, 110);
            this.LblPogresanLogin.Name = "LblPogresanLogin";
            this.LblPogresanLogin.Size = new System.Drawing.Size(0, 17);
            this.LblPogresanLogin.TabIndex = 9;
            // 
            // BtnUlogujSe
            // 
            this.BtnUlogujSe.Location = new System.Drawing.Point(72, 135);
            this.BtnUlogujSe.Name = "BtnUlogujSe";
            this.BtnUlogujSe.Size = new System.Drawing.Size(88, 36);
            this.BtnUlogujSe.TabIndex = 8;
            this.BtnUlogujSe.Text = "Uloguj se";
            this.BtnUlogujSe.UseVisualStyleBackColor = true;
            this.BtnUlogujSe.Click += new System.EventHandler(this.BtnUlogujSe_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(37, 174);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 17);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kreiraj adminski nalog";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TBoxLozinka
            // 
            this.TBoxLozinka.Location = new System.Drawing.Point(120, 79);
            this.TBoxLozinka.Name = "TBoxLozinka";
            this.TBoxLozinka.Size = new System.Drawing.Size(100, 22);
            this.TBoxLozinka.TabIndex = 6;
            // 
            // LblLozinka
            // 
            this.LblLozinka.AutoSize = true;
            this.LblLozinka.Location = new System.Drawing.Point(15, 79);
            this.LblLozinka.Name = "LblLozinka";
            this.LblLozinka.Size = new System.Drawing.Size(57, 17);
            this.LblLozinka.TabIndex = 5;
            this.LblLozinka.Text = "Lozinka";
            // 
            // LblKorisnickoIme
            // 
            this.LblKorisnickoIme.AutoSize = true;
            this.LblKorisnickoIme.Location = new System.Drawing.Point(15, 45);
            this.LblKorisnickoIme.Name = "LblKorisnickoIme";
            this.LblKorisnickoIme.Size = new System.Drawing.Size(99, 17);
            this.LblKorisnickoIme.TabIndex = 4;
            this.LblKorisnickoIme.Text = "Korisničko Ime";
            // 
            // TBoxKorisnickoIme
            // 
            this.TBoxKorisnickoIme.Location = new System.Drawing.Point(120, 45);
            this.TBoxKorisnickoIme.Name = "TBoxKorisnickoIme";
            this.TBoxKorisnickoIme.Size = new System.Drawing.Size(100, 22);
            this.TBoxKorisnickoIme.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBoxAdminLogin);
            this.Controls.Add(this.BtnKupac);
            this.Controls.Add(this.LblUkucajteAdminskuSifruIliUdjiteKaoKupac);
            this.Controls.Add(this.LblDobrodosli);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GBoxAdminLogin.ResumeLayout(false);
            this.GBoxAdminLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDobrodosli;
        private System.Windows.Forms.Label LblUkucajteAdminskuSifruIliUdjiteKaoKupac;
        private System.Windows.Forms.Button BtnKupac;
        private System.Windows.Forms.GroupBox GBoxAdminLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox TBoxLozinka;
        private System.Windows.Forms.Label LblLozinka;
        private System.Windows.Forms.Label LblKorisnickoIme;
        private System.Windows.Forms.TextBox TBoxKorisnickoIme;
        private System.Windows.Forms.Button BtnUlogujSe;
        private System.Windows.Forms.Label LblPogresanLogin;
    }
}