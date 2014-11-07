namespace TramBeheerSysteem
{
    partial class TramBeheerSysteem
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
            this.PanelTBS = new System.Windows.Forms.Panel();
            this.gbBediening = new System.Windows.Forms.GroupBox();
            this.gbTram = new System.Windows.Forms.GroupBox();
            this.cbTrams = new System.Windows.Forms.ComboBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.gbSimulatie = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gebruikerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voegToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wijzigStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tramInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpoorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusVeranderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spoorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onderhoudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onderhoudlijstenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.gbBediening.SuspendLayout();
            this.gbTram.SuspendLayout();
            this.gbSimulatie.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTBS
            // 
            this.PanelTBS.AutoScroll = true;
            this.PanelTBS.AutoSize = true;
            this.PanelTBS.Location = new System.Drawing.Point(300, 59);
            this.PanelTBS.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTBS.Name = "PanelTBS";
            this.PanelTBS.Size = new System.Drawing.Size(1093, 444);
            this.PanelTBS.TabIndex = 21;
            // 
            // gbBediening
            // 
            this.gbBediening.Controls.Add(this.gbTram);
            this.gbBediening.Controls.Add(this.gbSimulatie);
            this.gbBediening.Location = new System.Drawing.Point(13, 146);
            this.gbBediening.Margin = new System.Windows.Forms.Padding(4);
            this.gbBediening.Name = "gbBediening";
            this.gbBediening.Padding = new System.Windows.Forms.Padding(4);
            this.gbBediening.Size = new System.Drawing.Size(206, 357);
            this.gbBediening.TabIndex = 18;
            this.gbBediening.TabStop = false;
            this.gbBediening.Text = "Bediening";
            this.gbBediening.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbTram
            // 
            this.gbTram.Controls.Add(this.cbTrams);
            this.gbTram.Controls.Add(this.btnVerwijder);
            this.gbTram.Location = new System.Drawing.Point(8, 201);
            this.gbTram.Margin = new System.Windows.Forms.Padding(4);
            this.gbTram.Name = "gbTram";
            this.gbTram.Padding = new System.Windows.Forms.Padding(4);
            this.gbTram.Size = new System.Drawing.Size(191, 117);
            this.gbTram.TabIndex = 3;
            this.gbTram.TabStop = false;
            this.gbTram.Text = "Tram";
            // 
            // cbTrams
            // 
            this.cbTrams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrams.FormattingEnabled = true;
            this.cbTrams.Location = new System.Drawing.Point(8, 37);
            this.cbTrams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrams.Name = "cbTrams";
            this.cbTrams.Size = new System.Drawing.Size(160, 24);
            this.cbTrams.TabIndex = 3;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(7, 68);
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(161, 28);
            this.btnVerwijder.TabIndex = 2;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // gbSimulatie
            // 
            this.gbSimulatie.Controls.Add(this.btnReset);
            this.gbSimulatie.Controls.Add(this.btnStart);
            this.gbSimulatie.Location = new System.Drawing.Point(8, 42);
            this.gbSimulatie.Margin = new System.Windows.Forms.Padding(4);
            this.gbSimulatie.Name = "gbSimulatie";
            this.gbSimulatie.Padding = new System.Windows.Forms.Padding(4);
            this.gbSimulatie.Size = new System.Drawing.Size(191, 108);
            this.gbSimulatie.TabIndex = 2;
            this.gbSimulatie.TabStop = false;
            this.gbSimulatie.Text = "Simulatie";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(7, 59);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 28);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 23);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gebruikerToolStripMenuItem,
            this.TramToolStripMenuItem,
            this.SpoorToolStripMenuItem,
            this.onderhoudToolStripMenuItem,
            this.onderhoudlijstenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1464, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gebruikerToolStripMenuItem
            // 
            this.gebruikerToolStripMenuItem.Name = "gebruikerToolStripMenuItem";
            this.gebruikerToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.gebruikerToolStripMenuItem.Text = "Gebruiker";
            this.gebruikerToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.gebruikerToolStripMenuItem_DropDownItemClicked);
            // 
            // TramToolStripMenuItem
            // 
            this.TramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voegToeToolStripMenuItem,
            this.wijzigStatusToolStripMenuItem,
            this.tramInfoToolStripMenuItem});
            this.TramToolStripMenuItem.Name = "TramToolStripMenuItem";
            this.TramToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.TramToolStripMenuItem.Text = "Tram";
            // 
            // voegToeToolStripMenuItem
            // 
            this.voegToeToolStripMenuItem.Name = "voegToeToolStripMenuItem";
            this.voegToeToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.voegToeToolStripMenuItem.Text = "Voeg Toe";
            this.voegToeToolStripMenuItem.Click += new System.EventHandler(this.voegToeToolStripMenuItem_Click);
            // 
            // wijzigStatusToolStripMenuItem
            // 
            this.wijzigStatusToolStripMenuItem.Name = "wijzigStatusToolStripMenuItem";
            this.wijzigStatusToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.wijzigStatusToolStripMenuItem.Text = "Wijzig status";
            this.wijzigStatusToolStripMenuItem.Click += new System.EventHandler(this.wijzigStatusToolStripMenuItem_Click);
            // 
            // tramInfoToolStripMenuItem
            // 
            this.tramInfoToolStripMenuItem.Name = "tramInfoToolStripMenuItem";
            this.tramInfoToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.tramInfoToolStripMenuItem.Text = "Tram Info";
            this.tramInfoToolStripMenuItem.Click += new System.EventHandler(this.tramInfoToolStripMenuItem_Click);
            // 
            // SpoorToolStripMenuItem
            // 
            this.SpoorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusVeranderenToolStripMenuItem,
            this.spoorInfoToolStripMenuItem});
            this.SpoorToolStripMenuItem.Name = "SpoorToolStripMenuItem";
            this.SpoorToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.SpoorToolStripMenuItem.Text = "Spoor";
            this.SpoorToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // statusVeranderenToolStripMenuItem
            // 
            this.statusVeranderenToolStripMenuItem.Name = "statusVeranderenToolStripMenuItem";
            this.statusVeranderenToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.statusVeranderenToolStripMenuItem.Text = "Status Veranderen";
            this.statusVeranderenToolStripMenuItem.Click += new System.EventHandler(this.statusVeranderenToolStripMenuItem_Click);
            // 
            // spoorInfoToolStripMenuItem
            // 
            this.spoorInfoToolStripMenuItem.Name = "spoorInfoToolStripMenuItem";
            this.spoorInfoToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.spoorInfoToolStripMenuItem.Text = "Spoor Info";
            this.spoorInfoToolStripMenuItem.Click += new System.EventHandler(this.spoorInfoToolStripMenuItem_Click);
            // 
            // onderhoudToolStripMenuItem
            // 
            this.onderhoudToolStripMenuItem.Name = "onderhoudToolStripMenuItem";
            this.onderhoudToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.onderhoudToolStripMenuItem.Text = "Onderhoud";
            this.onderhoudToolStripMenuItem.Click += new System.EventHandler(this.schoonmaakToolStripMenuItem_Click);
            // 
            // onderhoudlijstenToolStripMenuItem
            // 
            this.onderhoudlijstenToolStripMenuItem.Name = "onderhoudlijstenToolStripMenuItem";
            this.onderhoudlijstenToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.onderhoudlijstenToolStripMenuItem.Text = "Onderhoudlijsten";
            this.onderhoudlijstenToolStripMenuItem.Click += new System.EventHandler(this.onderhoudlijstenToolStripMenuItem_Click);
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGebruiker.Location = new System.Drawing.Point(35, 74);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(109, 24);
            this.lblGebruiker.TabIndex = 4;
            this.lblGebruiker.Text = "Beheerder";
            // 
            // TramBeheerSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 553);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.PanelTBS);
            this.Controls.Add(this.gbBediening);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TramBeheerSysteem";
            this.Text = "TramBeheerSysteem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TramBeheerSysteem_Load);
            this.gbBediening.ResumeLayout(false);
            this.gbTram.ResumeLayout(false);
            this.gbSimulatie.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTBS;
        private System.Windows.Forms.GroupBox gbBediening;
        private System.Windows.Forms.GroupBox gbSimulatie;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpoorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voegToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wijzigStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tramInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusVeranderenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spoorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onderhoudToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTram;
        private System.Windows.Forms.ComboBox cbTrams;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ToolStripMenuItem gebruikerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onderhoudlijstenToolStripMenuItem;
        private System.Windows.Forms.Label lblGebruiker;

    }
}

