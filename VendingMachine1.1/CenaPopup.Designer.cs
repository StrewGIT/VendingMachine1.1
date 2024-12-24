
namespace VendingMachine1._1
{
    partial class CenaPopup
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
            this.LblCena = new System.Windows.Forms.Label();
            this.BtnKupi = new System.Windows.Forms.Button();
            this.BtnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCena
            // 
            this.LblCena.AutoSize = true;
            this.LblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCena.Location = new System.Drawing.Point(41, 34);
            this.LblCena.Name = "LblCena";
            this.LblCena.Size = new System.Drawing.Size(135, 29);
            this.LblCena.TabIndex = 0;
            this.LblCena.Text = "Cena: 0 rsd";
            // 
            // BtnKupi
            // 
            this.BtnKupi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnKupi.ForeColor = System.Drawing.Color.Green;
            this.BtnKupi.Location = new System.Drawing.Point(46, 129);
            this.BtnKupi.Name = "BtnKupi";
            this.BtnKupi.Size = new System.Drawing.Size(118, 52);
            this.BtnKupi.TabIndex = 1;
            this.BtnKupi.Text = "Kupi";
            this.BtnKupi.UseVisualStyleBackColor = false;
            this.BtnKupi.Click += new System.EventHandler(this.BtnKupi_Click);
            // 
            // BtnOtkazi
            // 
            this.BtnOtkazi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnOtkazi.ForeColor = System.Drawing.Color.Red;
            this.BtnOtkazi.Location = new System.Drawing.Point(227, 129);
            this.BtnOtkazi.Name = "BtnOtkazi";
            this.BtnOtkazi.Size = new System.Drawing.Size(118, 52);
            this.BtnOtkazi.TabIndex = 2;
            this.BtnOtkazi.Text = "Otkaži";
            this.BtnOtkazi.UseVisualStyleBackColor = false;
            this.BtnOtkazi.Click += new System.EventHandler(this.BtnOtkazi_Click);
            // 
            // CenaPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 230);
            this.Controls.Add(this.BtnOtkazi);
            this.Controls.Add(this.BtnKupi);
            this.Controls.Add(this.LblCena);
            this.Name = "CenaPopup";
            this.Text = "CenaPopup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CenaPopup_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCena;
        private System.Windows.Forms.Button BtnKupi;
        private System.Windows.Forms.Button BtnOtkazi;
    }
}