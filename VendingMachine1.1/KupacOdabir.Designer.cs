
namespace VendingMachine1._1
{
    partial class KupacOdabir
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
            this.FLPAdmini = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FLPAdmini
            // 
            this.FLPAdmini.Location = new System.Drawing.Point(71, 102);
            this.FLPAdmini.Name = "FLPAdmini";
            this.FLPAdmini.Size = new System.Drawing.Size(659, 283);
            this.FLPAdmini.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odaberite čiji automat želite da posetite";
            // 
            // KupacOdabir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FLPAdmini);
            this.Name = "KupacOdabir";
            this.Text = "KupacOdabir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KupacOdabir_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPAdmini;
        private System.Windows.Forms.Label label1;
    }
}