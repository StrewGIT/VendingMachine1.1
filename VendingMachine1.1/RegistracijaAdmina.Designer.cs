
namespace VendingMachine1._1
{
    partial class RegistracijaAdmina
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
            this.GBoxAdminLogin = new System.Windows.Forms.GroupBox();
            this.BtnRegistrujteSe = new System.Windows.Forms.Button();
            this.TBoxPonovoLozinka = new System.Windows.Forms.TextBox();
            this.LblPonovoLozinka = new System.Windows.Forms.Label();
            this.TBoxLozinka = new System.Windows.Forms.TextBox();
            this.LblLozinka = new System.Windows.Forms.Label();
            this.LblKorisnickoIme = new System.Windows.Forms.Label();
            this.TBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.GBoxAdminLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxAdminLogin
            // 
            this.GBoxAdminLogin.Controls.Add(this.BtnRegistrujteSe);
            this.GBoxAdminLogin.Controls.Add(this.TBoxPonovoLozinka);
            this.GBoxAdminLogin.Controls.Add(this.LblPonovoLozinka);
            this.GBoxAdminLogin.Controls.Add(this.TBoxLozinka);
            this.GBoxAdminLogin.Controls.Add(this.LblLozinka);
            this.GBoxAdminLogin.Controls.Add(this.LblKorisnickoIme);
            this.GBoxAdminLogin.Controls.Add(this.TBoxKorisnickoIme);
            this.GBoxAdminLogin.Location = new System.Drawing.Point(90, 44);
            this.GBoxAdminLogin.Name = "GBoxAdminLogin";
            this.GBoxAdminLogin.Size = new System.Drawing.Size(301, 234);
            this.GBoxAdminLogin.TabIndex = 4;
            this.GBoxAdminLogin.TabStop = false;
            this.GBoxAdminLogin.Text = "Admin log-in";
            // 
            // BtnRegistrujteSe
            // 
            this.BtnRegistrujteSe.Location = new System.Drawing.Point(88, 160);
            this.BtnRegistrujteSe.Name = "BtnRegistrujteSe";
            this.BtnRegistrujteSe.Size = new System.Drawing.Size(124, 43);
            this.BtnRegistrujteSe.TabIndex = 9;
            this.BtnRegistrujteSe.Text = "Registrujte se";
            this.BtnRegistrujteSe.UseVisualStyleBackColor = true;
            this.BtnRegistrujteSe.Click += new System.EventHandler(this.BtnRegistrujteSe_Click);
            // 
            // TBoxPonovoLozinka
            // 
            this.TBoxPonovoLozinka.Location = new System.Drawing.Point(160, 113);
            this.TBoxPonovoLozinka.Name = "TBoxPonovoLozinka";
            this.TBoxPonovoLozinka.Size = new System.Drawing.Size(100, 22);
            this.TBoxPonovoLozinka.TabIndex = 8;
            // 
            // LblPonovoLozinka
            // 
            this.LblPonovoLozinka.AutoSize = true;
            this.LblPonovoLozinka.Location = new System.Drawing.Point(40, 113);
            this.LblPonovoLozinka.Name = "LblPonovoLozinka";
            this.LblPonovoLozinka.Size = new System.Drawing.Size(104, 17);
            this.LblPonovoLozinka.TabIndex = 7;
            this.LblPonovoLozinka.Text = "Ponovo lozinka";
            // 
            // TBoxLozinka
            // 
            this.TBoxLozinka.Location = new System.Drawing.Point(160, 80);
            this.TBoxLozinka.Name = "TBoxLozinka";
            this.TBoxLozinka.Size = new System.Drawing.Size(100, 22);
            this.TBoxLozinka.TabIndex = 6;
            // 
            // LblLozinka
            // 
            this.LblLozinka.AutoSize = true;
            this.LblLozinka.Location = new System.Drawing.Point(40, 80);
            this.LblLozinka.Name = "LblLozinka";
            this.LblLozinka.Size = new System.Drawing.Size(57, 17);
            this.LblLozinka.TabIndex = 5;
            this.LblLozinka.Text = "Lozinka";
            // 
            // LblKorisnickoIme
            // 
            this.LblKorisnickoIme.AutoSize = true;
            this.LblKorisnickoIme.Location = new System.Drawing.Point(40, 47);
            this.LblKorisnickoIme.Name = "LblKorisnickoIme";
            this.LblKorisnickoIme.Size = new System.Drawing.Size(99, 17);
            this.LblKorisnickoIme.TabIndex = 4;
            this.LblKorisnickoIme.Text = "Korisničko Ime";
            // 
            // TBoxKorisnickoIme
            // 
            this.TBoxKorisnickoIme.Location = new System.Drawing.Point(160, 47);
            this.TBoxKorisnickoIme.Name = "TBoxKorisnickoIme";
            this.TBoxKorisnickoIme.Size = new System.Drawing.Size(100, 22);
            this.TBoxKorisnickoIme.TabIndex = 0;
            // 
            // RegistracijaAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 342);
            this.Controls.Add(this.GBoxAdminLogin);
            this.Name = "RegistracijaAdmina";
            this.Text = "RegistracijaAdmina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistracijaAdmina_FormClosed);
            this.GBoxAdminLogin.ResumeLayout(false);
            this.GBoxAdminLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxAdminLogin;
        private System.Windows.Forms.Button BtnRegistrujteSe;
        private System.Windows.Forms.TextBox TBoxPonovoLozinka;
        private System.Windows.Forms.Label LblPonovoLozinka;
        private System.Windows.Forms.TextBox TBoxLozinka;
        private System.Windows.Forms.Label LblLozinka;
        private System.Windows.Forms.Label LblKorisnickoIme;
        private System.Windows.Forms.TextBox TBoxKorisnickoIme;
    }
}