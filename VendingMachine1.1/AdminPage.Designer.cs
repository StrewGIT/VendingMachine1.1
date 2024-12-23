
namespace VendingMachine1._1
{
    partial class AdminPage
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
            this.LblBalansAutomata = new System.Windows.Forms.Label();
            this.LBoxArtikli = new System.Windows.Forms.ListBox();
            this.GBoxUbaciNovac = new System.Windows.Forms.GroupBox();
            this.BtnUbaci = new System.Windows.Forms.Button();
            this.RB200 = new System.Windows.Forms.RadioButton();
            this.RB100 = new System.Windows.Forms.RadioButton();
            this.RB50 = new System.Windows.Forms.RadioButton();
            this.RB20 = new System.Windows.Forms.RadioButton();
            this.RB10 = new System.Windows.Forms.RadioButton();
            this.RB5 = new System.Windows.Forms.RadioButton();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.FLPAutomat = new System.Windows.Forms.FlowLayoutPanel();
            this.GBoxUbaciNovac.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblBalansAutomata
            // 
            this.LblBalansAutomata.AutoSize = true;
            this.LblBalansAutomata.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBalansAutomata.Location = new System.Drawing.Point(56, 24);
            this.LblBalansAutomata.Name = "LblBalansAutomata";
            this.LblBalansAutomata.Size = new System.Drawing.Size(309, 39);
            this.LblBalansAutomata.TabIndex = 0;
            this.LblBalansAutomata.Text = "Balans automata: 0";
            // 
            // LBoxArtikli
            // 
            this.LBoxArtikli.FormattingEnabled = true;
            this.LBoxArtikli.ItemHeight = 16;
            this.LBoxArtikli.Location = new System.Drawing.Point(36, 332);
            this.LBoxArtikli.Name = "LBoxArtikli";
            this.LBoxArtikli.Size = new System.Drawing.Size(341, 116);
            this.LBoxArtikli.TabIndex = 1;
            // 
            // GBoxUbaciNovac
            // 
            this.GBoxUbaciNovac.Controls.Add(this.RB5);
            this.GBoxUbaciNovac.Controls.Add(this.BtnUbaci);
            this.GBoxUbaciNovac.Controls.Add(this.RB200);
            this.GBoxUbaciNovac.Controls.Add(this.RB100);
            this.GBoxUbaciNovac.Controls.Add(this.RB50);
            this.GBoxUbaciNovac.Controls.Add(this.RB20);
            this.GBoxUbaciNovac.Controls.Add(this.RB10);
            this.GBoxUbaciNovac.Location = new System.Drawing.Point(36, 90);
            this.GBoxUbaciNovac.Margin = new System.Windows.Forms.Padding(4);
            this.GBoxUbaciNovac.Name = "GBoxUbaciNovac";
            this.GBoxUbaciNovac.Padding = new System.Windows.Forms.Padding(4);
            this.GBoxUbaciNovac.Size = new System.Drawing.Size(341, 224);
            this.GBoxUbaciNovac.TabIndex = 2;
            this.GBoxUbaciNovac.TabStop = false;
            this.GBoxUbaciNovac.Text = "UbaciNovac";
            // 
            // BtnUbaci
            // 
            this.BtnUbaci.Location = new System.Drawing.Point(103, 154);
            this.BtnUbaci.Margin = new System.Windows.Forms.Padding(4);
            this.BtnUbaci.Name = "BtnUbaci";
            this.BtnUbaci.Size = new System.Drawing.Size(153, 53);
            this.BtnUbaci.TabIndex = 6;
            this.BtnUbaci.Text = "Ubaci";
            this.BtnUbaci.UseVisualStyleBackColor = true;
            this.BtnUbaci.Click += new System.EventHandler(this.BtnUbaci_Click);
            // 
            // RB200
            // 
            this.RB200.AutoSize = true;
            this.RB200.Location = new System.Drawing.Point(199, 101);
            this.RB200.Margin = new System.Windows.Forms.Padding(4);
            this.RB200.Name = "RB200";
            this.RB200.Size = new System.Drawing.Size(77, 21);
            this.RB200.TabIndex = 4;
            this.RB200.TabStop = true;
            this.RB200.Text = "200 rsd";
            this.RB200.UseVisualStyleBackColor = true;
            // 
            // RB100
            // 
            this.RB100.AutoSize = true;
            this.RB100.Location = new System.Drawing.Point(199, 72);
            this.RB100.Margin = new System.Windows.Forms.Padding(4);
            this.RB100.Name = "RB100";
            this.RB100.Size = new System.Drawing.Size(77, 21);
            this.RB100.TabIndex = 3;
            this.RB100.TabStop = true;
            this.RB100.Text = "100 rsd";
            this.RB100.UseVisualStyleBackColor = true;
            this.RB100.CheckedChanged += new System.EventHandler(this.RB100_CheckedChanged);
            // 
            // RB50
            // 
            this.RB50.AutoSize = true;
            this.RB50.Location = new System.Drawing.Point(199, 43);
            this.RB50.Margin = new System.Windows.Forms.Padding(4);
            this.RB50.Name = "RB50";
            this.RB50.Size = new System.Drawing.Size(69, 21);
            this.RB50.TabIndex = 2;
            this.RB50.TabStop = true;
            this.RB50.Text = "50 rsd";
            this.RB50.UseVisualStyleBackColor = true;
            // 
            // RB20
            // 
            this.RB20.AutoSize = true;
            this.RB20.Location = new System.Drawing.Point(39, 101);
            this.RB20.Margin = new System.Windows.Forms.Padding(4);
            this.RB20.Name = "RB20";
            this.RB20.Size = new System.Drawing.Size(69, 21);
            this.RB20.TabIndex = 1;
            this.RB20.TabStop = true;
            this.RB20.Text = "20 rsd";
            this.RB20.UseVisualStyleBackColor = true;
            // 
            // RB10
            // 
            this.RB10.AutoSize = true;
            this.RB10.Location = new System.Drawing.Point(39, 72);
            this.RB10.Margin = new System.Windows.Forms.Padding(4);
            this.RB10.Name = "RB10";
            this.RB10.Size = new System.Drawing.Size(69, 21);
            this.RB10.TabIndex = 0;
            this.RB10.TabStop = true;
            this.RB10.Text = "10 rsd";
            this.RB10.UseVisualStyleBackColor = true;
            // 
            // RB5
            // 
            this.RB5.AutoSize = true;
            this.RB5.Location = new System.Drawing.Point(39, 43);
            this.RB5.Name = "RB5";
            this.RB5.Size = new System.Drawing.Size(61, 21);
            this.RB5.TabIndex = 7;
            this.RB5.TabStop = true;
            this.RB5.Text = "5 rsd";
            this.RB5.UseVisualStyleBackColor = true;
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Location = new System.Drawing.Point(139, 471);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(153, 62);
            this.BtnDodaj.TabIndex = 3;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // FLPAutomat
            // 
            this.FLPAutomat.Location = new System.Drawing.Point(485, 90);
            this.FLPAutomat.Name = "FLPAutomat";
            this.FLPAutomat.Size = new System.Drawing.Size(412, 358);
            this.FLPAutomat.TabIndex = 4;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 555);
            this.Controls.Add(this.FLPAutomat);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.GBoxUbaciNovac);
            this.Controls.Add(this.LBoxArtikli);
            this.Controls.Add(this.LblBalansAutomata);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPage_FormClosed);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.GBoxUbaciNovac.ResumeLayout(false);
            this.GBoxUbaciNovac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBalansAutomata;
        private System.Windows.Forms.ListBox LBoxArtikli;
        private System.Windows.Forms.GroupBox GBoxUbaciNovac;
        private System.Windows.Forms.Button BtnUbaci;
        private System.Windows.Forms.RadioButton RB200;
        private System.Windows.Forms.RadioButton RB100;
        private System.Windows.Forms.RadioButton RB50;
        private System.Windows.Forms.RadioButton RB20;
        private System.Windows.Forms.RadioButton RB10;
        private System.Windows.Forms.RadioButton RB5;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.FlowLayoutPanel FLPAutomat;
    }
}