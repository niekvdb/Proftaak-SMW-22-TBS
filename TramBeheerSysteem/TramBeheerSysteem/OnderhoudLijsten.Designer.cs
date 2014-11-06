namespace TramBeheerSysteem
{
    partial class OnderhoudLijsten
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
            this.cbSchoonmaak = new System.Windows.Forms.ComboBox();
            this.lblSchoonmaak = new System.Windows.Forms.Label();
            this.tbcLijsten = new System.Windows.Forms.TabControl();
            this.tabSchoonmaak = new System.Windows.Forms.TabPage();
            this.tabReparatie = new System.Windows.Forms.TabPage();
            this.btnSchoonmaak = new System.Windows.Forms.Button();
            this.btnReparatie = new System.Windows.Forms.Button();
            this.cbReparatie = new System.Windows.Forms.ComboBox();
            this.lblReparatie = new System.Windows.Forms.Label();
            this.tbcLijsten.SuspendLayout();
            this.tabSchoonmaak.SuspendLayout();
            this.tabReparatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSchoonmaak
            // 
            this.cbSchoonmaak.FormattingEnabled = true;
            this.cbSchoonmaak.Location = new System.Drawing.Point(6, 54);
            this.cbSchoonmaak.Name = "cbSchoonmaak";
            this.cbSchoonmaak.Size = new System.Drawing.Size(514, 24);
            this.cbSchoonmaak.TabIndex = 0;
            // 
            // lblSchoonmaak
            // 
            this.lblSchoonmaak.AutoSize = true;
            this.lblSchoonmaak.Location = new System.Drawing.Point(6, 20);
            this.lblSchoonmaak.Name = "lblSchoonmaak";
            this.lblSchoonmaak.Size = new System.Drawing.Size(214, 17);
            this.lblSchoonmaak.TabIndex = 1;
            this.lblSchoonmaak.Text = "Nog niet voltooide schoonmaken";
            // 
            // tbcLijsten
            // 
            this.tbcLijsten.Controls.Add(this.tabSchoonmaak);
            this.tbcLijsten.Controls.Add(this.tabReparatie);
            this.tbcLijsten.Location = new System.Drawing.Point(4, 12);
            this.tbcLijsten.Name = "tbcLijsten";
            this.tbcLijsten.SelectedIndex = 0;
            this.tbcLijsten.Size = new System.Drawing.Size(548, 421);
            this.tbcLijsten.TabIndex = 2;
            // 
            // tabSchoonmaak
            // 
            this.tabSchoonmaak.Controls.Add(this.btnSchoonmaak);
            this.tabSchoonmaak.Controls.Add(this.cbSchoonmaak);
            this.tabSchoonmaak.Controls.Add(this.lblSchoonmaak);
            this.tabSchoonmaak.Location = new System.Drawing.Point(4, 25);
            this.tabSchoonmaak.Name = "tabSchoonmaak";
            this.tabSchoonmaak.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchoonmaak.Size = new System.Drawing.Size(540, 392);
            this.tabSchoonmaak.TabIndex = 0;
            this.tabSchoonmaak.Text = "Schoonmaak";
            this.tabSchoonmaak.UseVisualStyleBackColor = true;
            // 
            // tabReparatie
            // 
            this.tabReparatie.Controls.Add(this.btnReparatie);
            this.tabReparatie.Controls.Add(this.cbReparatie);
            this.tabReparatie.Controls.Add(this.lblReparatie);
            this.tabReparatie.Location = new System.Drawing.Point(4, 25);
            this.tabReparatie.Name = "tabReparatie";
            this.tabReparatie.Padding = new System.Windows.Forms.Padding(3);
            this.tabReparatie.Size = new System.Drawing.Size(540, 392);
            this.tabReparatie.TabIndex = 1;
            this.tabReparatie.Text = "Reparatie";
            this.tabReparatie.UseVisualStyleBackColor = true;
            // 
            // btnSchoonmaak
            // 
            this.btnSchoonmaak.Location = new System.Drawing.Point(9, 328);
            this.btnSchoonmaak.Name = "btnSchoonmaak";
            this.btnSchoonmaak.Size = new System.Drawing.Size(135, 58);
            this.btnSchoonmaak.TabIndex = 2;
            this.btnSchoonmaak.Text = "Schoonmaak Voltooien";
            this.btnSchoonmaak.UseVisualStyleBackColor = true;
            // 
            // btnReparatie
            // 
            this.btnReparatie.Location = new System.Drawing.Point(9, 328);
            this.btnReparatie.Name = "btnReparatie";
            this.btnReparatie.Size = new System.Drawing.Size(135, 58);
            this.btnReparatie.TabIndex = 5;
            this.btnReparatie.Text = "Reparatie Voltooien";
            this.btnReparatie.UseVisualStyleBackColor = true;
            // 
            // cbReparatie
            // 
            this.cbReparatie.FormattingEnabled = true;
            this.cbReparatie.Location = new System.Drawing.Point(6, 54);
            this.cbReparatie.Name = "cbReparatie";
            this.cbReparatie.Size = new System.Drawing.Size(514, 24);
            this.cbReparatie.TabIndex = 3;
            // 
            // lblReparatie
            // 
            this.lblReparatie.AutoSize = true;
            this.lblReparatie.Location = new System.Drawing.Point(6, 20);
            this.lblReparatie.Name = "lblReparatie";
            this.lblReparatie.Size = new System.Drawing.Size(190, 17);
            this.lblReparatie.TabIndex = 4;
            this.lblReparatie.Text = "Nog niet voltooide reparaties";
            // 
            // OnderhoudLijsten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 445);
            this.Controls.Add(this.tbcLijsten);
            this.Name = "OnderhoudLijsten";
            this.Text = "OnderhoudLijsten";
            this.tbcLijsten.ResumeLayout(false);
            this.tabSchoonmaak.ResumeLayout(false);
            this.tabSchoonmaak.PerformLayout();
            this.tabReparatie.ResumeLayout(false);
            this.tabReparatie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSchoonmaak;
        private System.Windows.Forms.Label lblSchoonmaak;
        private System.Windows.Forms.TabControl tbcLijsten;
        private System.Windows.Forms.TabPage tabSchoonmaak;
        private System.Windows.Forms.Button btnSchoonmaak;
        private System.Windows.Forms.TabPage tabReparatie;
        private System.Windows.Forms.Button btnReparatie;
        private System.Windows.Forms.ComboBox cbReparatie;
        private System.Windows.Forms.Label lblReparatie;
    }
}