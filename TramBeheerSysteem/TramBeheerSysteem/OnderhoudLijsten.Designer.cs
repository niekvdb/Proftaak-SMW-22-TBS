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
            this.btnSchoonmaak = new System.Windows.Forms.Button();
            this.tabReparatie = new System.Windows.Forms.TabPage();
            this.btnReparatie = new System.Windows.Forms.Button();
            this.cbReparatie = new System.Windows.Forms.ComboBox();
            this.lblReparatie = new System.Windows.Forms.Label();
            this.tbxSchoonmaak = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbxSchoonmaakSpoor = new System.Windows.Forms.TextBox();
            this.tbxSchoonmaakSector = new System.Windows.Forms.TextBox();
            this.lblSchoonmaakSpoor = new System.Windows.Forms.Label();
            this.lblSchoonmaakSector = new System.Windows.Forms.Label();
            this.lblReparatieSector = new System.Windows.Forms.Label();
            this.lblReparatieSpoor = new System.Windows.Forms.Label();
            this.tbxReparatieSector = new System.Windows.Forms.TextBox();
            this.tbxReparatieSpoor = new System.Windows.Forms.TextBox();
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
            this.cbSchoonmaak.SelectedIndexChanged += new System.EventHandler(this.cbSchoonmaak_SelectedIndexChanged);
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
            this.tabSchoonmaak.Controls.Add(this.lblSchoonmaakSector);
            this.tabSchoonmaak.Controls.Add(this.lblSchoonmaakSpoor);
            this.tabSchoonmaak.Controls.Add(this.tbxSchoonmaakSector);
            this.tabSchoonmaak.Controls.Add(this.tbxSchoonmaakSpoor);
            this.tabSchoonmaak.Controls.Add(this.tbxSchoonmaak);
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
            // btnSchoonmaak
            // 
            this.btnSchoonmaak.Location = new System.Drawing.Point(9, 328);
            this.btnSchoonmaak.Name = "btnSchoonmaak";
            this.btnSchoonmaak.Size = new System.Drawing.Size(135, 58);
            this.btnSchoonmaak.TabIndex = 2;
            this.btnSchoonmaak.Text = "Schoonmaak Voltooien";
            this.btnSchoonmaak.UseVisualStyleBackColor = true;
            this.btnSchoonmaak.Click += new System.EventHandler(this.btnSchoonmaak_Click);
            // 
            // tabReparatie
            // 
            this.tabReparatie.Controls.Add(this.lblReparatieSector);
            this.tabReparatie.Controls.Add(this.lblReparatieSpoor);
            this.tabReparatie.Controls.Add(this.tbxReparatieSector);
            this.tabReparatie.Controls.Add(this.tbxReparatieSpoor);
            this.tabReparatie.Controls.Add(this.textBox1);
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
            // btnReparatie
            // 
            this.btnReparatie.Location = new System.Drawing.Point(9, 328);
            this.btnReparatie.Name = "btnReparatie";
            this.btnReparatie.Size = new System.Drawing.Size(135, 58);
            this.btnReparatie.TabIndex = 5;
            this.btnReparatie.Text = "Reparatie Voltooien";
            this.btnReparatie.UseVisualStyleBackColor = true;
            this.btnReparatie.Click += new System.EventHandler(this.btnReparatie_Click);
            // 
            // cbReparatie
            // 
            this.cbReparatie.FormattingEnabled = true;
            this.cbReparatie.Location = new System.Drawing.Point(6, 54);
            this.cbReparatie.Name = "cbReparatie";
            this.cbReparatie.Size = new System.Drawing.Size(514, 24);
            this.cbReparatie.TabIndex = 3;
            this.cbReparatie.SelectedIndexChanged += new System.EventHandler(this.cbReparatie_SelectedIndexChanged);
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
            // tbxSchoonmaak
            // 
            this.tbxSchoonmaak.Location = new System.Drawing.Point(9, 102);
            this.tbxSchoonmaak.Multiline = true;
            this.tbxSchoonmaak.Name = "tbxSchoonmaak";
            this.tbxSchoonmaak.Size = new System.Drawing.Size(385, 220);
            this.tbxSchoonmaak.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 220);
            this.textBox1.TabIndex = 6;
            // 
            // tbxSchoonmaakSpoor
            // 
            this.tbxSchoonmaakSpoor.Location = new System.Drawing.Point(420, 134);
            this.tbxSchoonmaakSpoor.Name = "tbxSchoonmaakSpoor";
            this.tbxSchoonmaakSpoor.Size = new System.Drawing.Size(100, 22);
            this.tbxSchoonmaakSpoor.TabIndex = 4;
            // 
            // tbxSchoonmaakSector
            // 
            this.tbxSchoonmaakSector.Location = new System.Drawing.Point(420, 199);
            this.tbxSchoonmaakSector.Name = "tbxSchoonmaakSector";
            this.tbxSchoonmaakSector.Size = new System.Drawing.Size(100, 22);
            this.tbxSchoonmaakSector.TabIndex = 5;
            // 
            // lblSchoonmaakSpoor
            // 
            this.lblSchoonmaakSpoor.AutoSize = true;
            this.lblSchoonmaakSpoor.Location = new System.Drawing.Point(420, 114);
            this.lblSchoonmaakSpoor.Name = "lblSchoonmaakSpoor";
            this.lblSchoonmaakSpoor.Size = new System.Drawing.Size(46, 17);
            this.lblSchoonmaakSpoor.TabIndex = 6;
            this.lblSchoonmaakSpoor.Text = "Spoor";
            // 
            // lblSchoonmaakSector
            // 
            this.lblSchoonmaakSector.AutoSize = true;
            this.lblSchoonmaakSector.Location = new System.Drawing.Point(420, 179);
            this.lblSchoonmaakSector.Name = "lblSchoonmaakSector";
            this.lblSchoonmaakSector.Size = new System.Drawing.Size(49, 17);
            this.lblSchoonmaakSector.TabIndex = 7;
            this.lblSchoonmaakSector.Text = "Sector";
            // 
            // lblReparatieSector
            // 
            this.lblReparatieSector.AutoSize = true;
            this.lblReparatieSector.Location = new System.Drawing.Point(420, 179);
            this.lblReparatieSector.Name = "lblReparatieSector";
            this.lblReparatieSector.Size = new System.Drawing.Size(49, 17);
            this.lblReparatieSector.TabIndex = 11;
            this.lblReparatieSector.Text = "Sector";
            // 
            // lblReparatieSpoor
            // 
            this.lblReparatieSpoor.AutoSize = true;
            this.lblReparatieSpoor.Location = new System.Drawing.Point(420, 114);
            this.lblReparatieSpoor.Name = "lblReparatieSpoor";
            this.lblReparatieSpoor.Size = new System.Drawing.Size(46, 17);
            this.lblReparatieSpoor.TabIndex = 10;
            this.lblReparatieSpoor.Text = "Spoor";
            // 
            // tbxReparatieSector
            // 
            this.tbxReparatieSector.Location = new System.Drawing.Point(420, 199);
            this.tbxReparatieSector.Name = "tbxReparatieSector";
            this.tbxReparatieSector.Size = new System.Drawing.Size(100, 22);
            this.tbxReparatieSector.TabIndex = 9;
            // 
            // tbxReparatieSpoor
            // 
            this.tbxReparatieSpoor.Location = new System.Drawing.Point(420, 134);
            this.tbxReparatieSpoor.Name = "tbxReparatieSpoor";
            this.tbxReparatieSpoor.Size = new System.Drawing.Size(100, 22);
            this.tbxReparatieSpoor.TabIndex = 8;
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
        private System.Windows.Forms.TextBox tbxSchoonmaak;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSchoonmaakSector;
        private System.Windows.Forms.Label lblSchoonmaakSpoor;
        private System.Windows.Forms.TextBox tbxSchoonmaakSector;
        private System.Windows.Forms.TextBox tbxSchoonmaakSpoor;
        private System.Windows.Forms.Label lblReparatieSector;
        private System.Windows.Forms.Label lblReparatieSpoor;
        private System.Windows.Forms.TextBox tbxReparatieSector;
        private System.Windows.Forms.TextBox tbxReparatieSpoor;
    }
}