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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TramsCbox = new System.Windows.Forms.ComboBox();
            this.VerwijderBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
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
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(300, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 444);
            this.panel1.TabIndex = 21;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(1098, 59);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(221, 444);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trams (Indienst)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 140);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 276);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Location = new System.Drawing.Point(17, 31);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(191, 71);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Selecteer een status";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Indienst",
            "Remise",
            "Schoonmaak",
            "Defect"});
            this.comboBox2.Location = new System.Drawing.Point(8, 30);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(43, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(221, 444);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TramsCbox);
            this.groupBox2.Controls.Add(this.VerwijderBtn);
            this.groupBox2.Location = new System.Drawing.Point(8, 201);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(191, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tram";
            // 
            // TramsCbox
            // 
            this.TramsCbox.FormattingEnabled = true;
            this.TramsCbox.Location = new System.Drawing.Point(8, 37);
            this.TramsCbox.Name = "TramsCbox";
            this.TramsCbox.Size = new System.Drawing.Size(160, 24);
            this.TramsCbox.TabIndex = 3;
            // 
            // VerwijderBtn
            // 
            this.VerwijderBtn.Location = new System.Drawing.Point(7, 68);
            this.VerwijderBtn.Margin = new System.Windows.Forms.Padding(4);
            this.VerwijderBtn.Name = "VerwijderBtn";
            this.VerwijderBtn.Size = new System.Drawing.Size(161, 28);
            this.VerwijderBtn.TabIndex = 2;
            this.VerwijderBtn.Text = "Verwijder";
            this.VerwijderBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResetBtn);
            this.groupBox3.Controls.Add(this.StopBtn);
            this.groupBox3.Controls.Add(this.StartBtn);
            this.groupBox3.Location = new System.Drawing.Point(8, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(191, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulatie";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(7, 97);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(161, 28);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(8, 59);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(161, 28);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(8, 23);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(161, 28);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TramBeheerSysteem";
            this.Text = "TramBeheerSysteem";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ResetBtn;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox TramsCbox;
        private System.Windows.Forms.Button VerwijderBtn;

    }
}

