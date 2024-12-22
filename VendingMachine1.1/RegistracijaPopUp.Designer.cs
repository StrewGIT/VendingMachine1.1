
namespace VendingMachine1._1
{
    partial class RegistracijaPopUp
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
            this.LblRegistracijaUspesna = new System.Windows.Forms.Label();
            this.LblZatvoriteProzor = new System.Windows.Forms.Label();
            this.LblRazlogNeuspeha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblRegistracijaUspesna
            // 
            this.LblRegistracijaUspesna.AutoSize = true;
            this.LblRegistracijaUspesna.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistracijaUspesna.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblRegistracijaUspesna.Location = new System.Drawing.Point(24, 29);
            this.LblRegistracijaUspesna.Name = "LblRegistracijaUspesna";
            this.LblRegistracijaUspesna.Size = new System.Drawing.Size(309, 32);
            this.LblRegistracijaUspesna.TabIndex = 0;
            this.LblRegistracijaUspesna.Text = "Registracija uspešna!";
            // 
            // LblZatvoriteProzor
            // 
            this.LblZatvoriteProzor.AutoSize = true;
            this.LblZatvoriteProzor.Location = new System.Drawing.Point(105, 128);
            this.LblZatvoriteProzor.Name = "LblZatvoriteProzor";
            this.LblZatvoriteProzor.Size = new System.Drawing.Size(139, 17);
            this.LblZatvoriteProzor.TabIndex = 1;
            this.LblZatvoriteProzor.Text = "Zatvorite ovaj prozor";
            // 
            // LblRazlogNeuspeha
            // 
            this.LblRazlogNeuspeha.AutoSize = true;
            this.LblRazlogNeuspeha.Location = new System.Drawing.Point(190, 87);
            this.LblRazlogNeuspeha.Name = "LblRazlogNeuspeha";
            this.LblRazlogNeuspeha.Size = new System.Drawing.Size(0, 17);
            this.LblRazlogNeuspeha.TabIndex = 2;
            this.LblRazlogNeuspeha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistracijaPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 167);
            this.Controls.Add(this.LblRazlogNeuspeha);
            this.Controls.Add(this.LblZatvoriteProzor);
            this.Controls.Add(this.LblRegistracijaUspesna);
            this.Name = "RegistracijaPopUp";
            this.Text = "RegistracijaPopUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistracijaPopUp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRegistracijaUspesna;
        private System.Windows.Forms.Label LblZatvoriteProzor;
        private System.Windows.Forms.Label LblRazlogNeuspeha;
    }
}