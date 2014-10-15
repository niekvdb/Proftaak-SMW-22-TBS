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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.voegToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wijzigStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tramInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusVeranderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spoorInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoonmaakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reparatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.PanelTBS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelTBS.Name = "PanelTBS";
            this.PanelTBS.Size = new System.Drawing.Size(1093, 444);
            this.PanelTBS.TabIndex = 21;
            // 
            // gbBediening
            // 
            this.gbBediening.Controls.Add(this.gbTram);
            this.gbBediening.Controls.Add(this.gbSimulatie);
            this.gbBediening.Location = new System.Drawing.Point(43, 59);
            this.gbBediening.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBediening.Name = "gbBediening";
            this.gbBediening.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBediening.Size = new System.Drawing.Size(221, 444);
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
            this.gbTram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTram.Name = "gbTram";
            this.gbTram.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTram.Size = new System.Drawing.Size(191, 126);
            this.gbTram.TabIndex = 3;
            this.gbTram.TabStop = false;
            this.gbTram.Text = "Tram";
            // 
            // cbTrams
            // 
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
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.gbSimulatie.Controls.Add(this.btnStop);
            this.gbSimulatie.Controls.Add(this.btnStart);
            this.gbSimulatie.Location = new System.Drawing.Point(8, 42);
            this.gbSimulatie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSimulatie.Name = "gbSimulatie";
            this.gbSimulatie.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSimulatie.Size = new System.Drawing.Size(191, 126);
            this.gbSimulatie.TabIndex = 2;
            this.gbSimulatie.TabStop = false;
            this.gbSimulatie.Text = "Simulatie";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(7, 97);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 28);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(8, 59);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 23);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(161, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.schoonmaakToolStripMenuItem,
            this.reparatieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1464, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voegToeToolStripMenuItem,
            this.wijzigStatusToolStripMenuItem,
            this.tramInfoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem1.Text = "Tram";
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
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusVeranderenToolStripMenuItem,
            this.spoorInfoToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 24);
            this.toolStripMenuItem2.Text = "Spoor";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
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
            // 
            // schoonmaakToolStripMenuItem
            // 
            this.schoonmaakToolStripMenuItem.Name = "schoonmaakToolStripMenuItem";
            this.schoonmaakToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.schoonmaakToolStripMenuItem.Text = "Schoonmaak";
            this.schoonmaakToolStripMenuItem.Click += new System.EventHandler(this.schoonmaakToolStripMenuItem_Click);
            // 
            // reparatieToolStripMenuItem
            // 
            this.reparatieToolStripMenuItem.Name = "reparatieToolStripMenuItem";
            this.reparatieToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.reparatieToolStripMenuItem.Text = "Reparatie";
            // 
            // TramBeheerSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 553);
            this.Controls.Add(this.PanelTBS);
            this.Controls.Add(this.gbBediening);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem voegToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wijzigStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tramInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusVeranderenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spoorInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoonmaakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reparatieToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbTram;
        private System.Windows.Forms.ComboBox cbTrams;
        private System.Windows.Forms.Button btnVerwijder;

    }
}

