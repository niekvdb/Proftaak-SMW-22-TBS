namespace TramBeheerSysteem
{
    partial class OnderhoudApplicatie
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.tabOnderhoud = new System.Windows.Forms.TabControl();
            this.tabSchoonmaak = new System.Windows.Forms.TabPage();
            this.cbSchoonmaakMedewerker = new System.Windows.Forms.ComboBox();
            this.dtpSchoonmaak = new System.Windows.Forms.DateTimePicker();
            this.rbtSchoonmaakGroot = new System.Windows.Forms.RadioButton();
            this.rbtSchoonmaakKlein = new System.Windows.Forms.RadioButton();
            this.lblSchoonmaakBevestiging = new System.Windows.Forms.Label();
            this.tbxSchoonmaakBevestiging = new System.Windows.Forms.TextBox();
            this.btnSchoonmaakBevestiging = new System.Windows.Forms.Button();
            this.lblSchoonmaak = new System.Windows.Forms.Label();
            this.pnlSchoonmaak = new System.Windows.Forms.Panel();
            this.lvwSchoonmaak = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabReparatie = new System.Windows.Forms.TabPage();
            this.cbReparatieMedewerker = new System.Windows.Forms.ComboBox();
            this.dtpReparatie = new System.Windows.Forms.DateTimePicker();
            this.rbtReparatieGroot = new System.Windows.Forms.RadioButton();
            this.rbtReparatieKlein = new System.Windows.Forms.RadioButton();
            this.lblReparatieBevestiging = new System.Windows.Forms.Label();
            this.tbxReparatieBevestiging = new System.Windows.Forms.TextBox();
            this.btnReparatieBevestiging = new System.Windows.Forms.Button();
            this.lblReparatie = new System.Windows.Forms.Label();
            this.pnlReparatie = new System.Windows.Forms.Panel();
            this.lvwReparatie = new System.Windows.Forms.ListView();
            this.clmTramnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTramType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSpoor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDefect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clmSchoonmaakInfoTramId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTramId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabOnderhoud.SuspendLayout();
            this.tabSchoonmaak.SuspendLayout();
            this.pnlSchoonmaak.SuspendLayout();
            this.tabReparatie.SuspendLayout();
            this.pnlReparatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOnderhoud
            // 
            this.tabOnderhoud.Controls.Add(this.tabSchoonmaak);
            this.tabOnderhoud.Controls.Add(this.tabReparatie);
            this.tabOnderhoud.Location = new System.Drawing.Point(0, 0);
            this.tabOnderhoud.Name = "tabOnderhoud";
            this.tabOnderhoud.SelectedIndex = 0;
            this.tabOnderhoud.Size = new System.Drawing.Size(1221, 536);
            this.tabOnderhoud.TabIndex = 0;
            // 
            // tabSchoonmaak
            // 
            this.tabSchoonmaak.Controls.Add(this.cbSchoonmaakMedewerker);
            this.tabSchoonmaak.Controls.Add(this.dtpSchoonmaak);
            this.tabSchoonmaak.Controls.Add(this.rbtSchoonmaakGroot);
            this.tabSchoonmaak.Controls.Add(this.rbtSchoonmaakKlein);
            this.tabSchoonmaak.Controls.Add(this.lblSchoonmaakBevestiging);
            this.tabSchoonmaak.Controls.Add(this.tbxSchoonmaakBevestiging);
            this.tabSchoonmaak.Controls.Add(this.btnSchoonmaakBevestiging);
            this.tabSchoonmaak.Controls.Add(this.lblSchoonmaak);
            this.tabSchoonmaak.Controls.Add(this.pnlSchoonmaak);
            this.tabSchoonmaak.Location = new System.Drawing.Point(4, 25);
            this.tabSchoonmaak.Name = "tabSchoonmaak";
            this.tabSchoonmaak.Size = new System.Drawing.Size(1213, 507);
            this.tabSchoonmaak.TabIndex = 0;
            this.tabSchoonmaak.Text = "Schoonmaak";
            this.tabSchoonmaak.UseVisualStyleBackColor = true;
            // 
            // cbSchoonmaakMedewerker
            // 
            this.cbSchoonmaakMedewerker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchoonmaakMedewerker.FormattingEnabled = true;
            this.cbSchoonmaakMedewerker.Location = new System.Drawing.Point(724, 269);
            this.cbSchoonmaakMedewerker.Name = "cbSchoonmaakMedewerker";
            this.cbSchoonmaakMedewerker.Size = new System.Drawing.Size(246, 24);
            this.cbSchoonmaakMedewerker.TabIndex = 24;
            // 
            // dtpSchoonmaak
            // 
            this.dtpSchoonmaak.Location = new System.Drawing.Point(724, 241);
            this.dtpSchoonmaak.Name = "dtpSchoonmaak";
            this.dtpSchoonmaak.Size = new System.Drawing.Size(246, 22);
            this.dtpSchoonmaak.TabIndex = 23;
            // 
            // rbtSchoonmaakGroot
            // 
            this.rbtSchoonmaakGroot.AutoSize = true;
            this.rbtSchoonmaakGroot.Location = new System.Drawing.Point(884, 48);
            this.rbtSchoonmaakGroot.Name = "rbtSchoonmaakGroot";
            this.rbtSchoonmaakGroot.Size = new System.Drawing.Size(151, 21);
            this.rbtSchoonmaakGroot.TabIndex = 22;
            this.rbtSchoonmaakGroot.TabStop = true;
            this.rbtSchoonmaakGroot.Text = "Grote Schoonmaak";
            this.rbtSchoonmaakGroot.UseVisualStyleBackColor = true;
            // 
            // rbtSchoonmaakKlein
            // 
            this.rbtSchoonmaakKlein.AutoSize = true;
            this.rbtSchoonmaakKlein.Location = new System.Drawing.Point(724, 48);
            this.rbtSchoonmaakKlein.Name = "rbtSchoonmaakKlein";
            this.rbtSchoonmaakKlein.Size = new System.Drawing.Size(154, 21);
            this.rbtSchoonmaakKlein.TabIndex = 21;
            this.rbtSchoonmaakKlein.TabStop = true;
            this.rbtSchoonmaakKlein.Text = "Kleine Schoonmaak";
            this.rbtSchoonmaakKlein.UseVisualStyleBackColor = true;
            // 
            // lblSchoonmaakBevestiging
            // 
            this.lblSchoonmaakBevestiging.AutoSize = true;
            this.lblSchoonmaakBevestiging.Location = new System.Drawing.Point(721, 17);
            this.lblSchoonmaakBevestiging.Name = "lblSchoonmaakBevestiging";
            this.lblSchoonmaakBevestiging.Size = new System.Drawing.Size(148, 17);
            this.lblSchoonmaakBevestiging.TabIndex = 14;
            this.lblSchoonmaakBevestiging.Text = "Bevestig Schoonmaak";
            // 
            // tbxSchoonmaakBevestiging
            // 
            this.tbxSchoonmaakBevestiging.Location = new System.Drawing.Point(724, 88);
            this.tbxSchoonmaakBevestiging.Multiline = true;
            this.tbxSchoonmaakBevestiging.Name = "tbxSchoonmaakBevestiging";
            this.tbxSchoonmaakBevestiging.Size = new System.Drawing.Size(286, 147);
            this.tbxSchoonmaakBevestiging.TabIndex = 13;
            // 
            // btnSchoonmaakBevestiging
            // 
            this.btnSchoonmaakBevestiging.Location = new System.Drawing.Point(724, 299);
            this.btnSchoonmaakBevestiging.Name = "btnSchoonmaakBevestiging";
            this.btnSchoonmaakBevestiging.Size = new System.Drawing.Size(81, 31);
            this.btnSchoonmaakBevestiging.TabIndex = 12;
            this.btnSchoonmaakBevestiging.Text = "Bevestig";
            this.btnSchoonmaakBevestiging.UseVisualStyleBackColor = true;
            this.btnSchoonmaakBevestiging.Click += new System.EventHandler(this.btnSchoonmaakBevestiging_Click);
            // 
            // lblSchoonmaak
            // 
            this.lblSchoonmaak.AutoSize = true;
            this.lblSchoonmaak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoonmaak.Location = new System.Drawing.Point(14, 0);
            this.lblSchoonmaak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchoonmaak.Name = "lblSchoonmaak";
            this.lblSchoonmaak.Size = new System.Drawing.Size(44, 25);
            this.lblSchoonmaak.TabIndex = 10;
            this.lblSchoonmaak.Text = "Info";
            // 
            // pnlSchoonmaak
            // 
            this.pnlSchoonmaak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSchoonmaak.Controls.Add(this.lvwSchoonmaak);
            this.pnlSchoonmaak.Location = new System.Drawing.Point(9, 17);
            this.pnlSchoonmaak.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSchoonmaak.Name = "pnlSchoonmaak";
            this.pnlSchoonmaak.Size = new System.Drawing.Size(667, 326);
            this.pnlSchoonmaak.TabIndex = 9;
            // 
            // lvwSchoonmaak
            // 
            this.lvwSchoonmaak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSchoonmaakInfoTramId,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwSchoonmaak.FullRowSelect = true;
            this.lvwSchoonmaak.HideSelection = false;
            this.lvwSchoonmaak.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvwSchoonmaak.Location = new System.Drawing.Point(10, 11);
            this.lvwSchoonmaak.Margin = new System.Windows.Forms.Padding(4);
            this.lvwSchoonmaak.MultiSelect = false;
            this.lvwSchoonmaak.Name = "lvwSchoonmaak";
            this.lvwSchoonmaak.Size = new System.Drawing.Size(656, 292);
            this.lvwSchoonmaak.TabIndex = 7;
            this.lvwSchoonmaak.UseCompatibleStateImageBehavior = false;
            this.lvwSchoonmaak.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tramnummer";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TramType";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Spoor";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sector";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vervuild";
            this.columnHeader5.Width = 105;
            // 
            // tabReparatie
            // 
            this.tabReparatie.Controls.Add(this.cbReparatieMedewerker);
            this.tabReparatie.Controls.Add(this.dtpReparatie);
            this.tabReparatie.Controls.Add(this.rbtReparatieGroot);
            this.tabReparatie.Controls.Add(this.rbtReparatieKlein);
            this.tabReparatie.Controls.Add(this.lblReparatieBevestiging);
            this.tabReparatie.Controls.Add(this.tbxReparatieBevestiging);
            this.tabReparatie.Controls.Add(this.btnReparatieBevestiging);
            this.tabReparatie.Controls.Add(this.lblReparatie);
            this.tabReparatie.Controls.Add(this.pnlReparatie);
            this.tabReparatie.Location = new System.Drawing.Point(4, 25);
            this.tabReparatie.Name = "tabReparatie";
            this.tabReparatie.Size = new System.Drawing.Size(1213, 507);
            this.tabReparatie.TabIndex = 1;
            this.tabReparatie.Text = "Reparatie";
            this.tabReparatie.UseVisualStyleBackColor = true;
            // 
            // cbReparatieMedewerker
            // 
            this.cbReparatieMedewerker.FormattingEnabled = true;
            this.cbReparatieMedewerker.Location = new System.Drawing.Point(724, 269);
            this.cbReparatieMedewerker.Name = "cbReparatieMedewerker";
            this.cbReparatieMedewerker.Size = new System.Drawing.Size(246, 24);
            this.cbReparatieMedewerker.TabIndex = 25;
            // 
            // dtpReparatie
            // 
            this.dtpReparatie.Location = new System.Drawing.Point(724, 241);
            this.dtpReparatie.Name = "dtpReparatie";
            this.dtpReparatie.Size = new System.Drawing.Size(246, 22);
            this.dtpReparatie.TabIndex = 24;
            // 
            // rbtReparatieGroot
            // 
            this.rbtReparatieGroot.AutoSize = true;
            this.rbtReparatieGroot.Location = new System.Drawing.Point(864, 48);
            this.rbtReparatieGroot.Name = "rbtReparatieGroot";
            this.rbtReparatieGroot.Size = new System.Drawing.Size(131, 21);
            this.rbtReparatieGroot.TabIndex = 20;
            this.rbtReparatieGroot.TabStop = true;
            this.rbtReparatieGroot.Text = "Grote Reparatie";
            this.rbtReparatieGroot.UseVisualStyleBackColor = true;
            // 
            // rbtReparatieKlein
            // 
            this.rbtReparatieKlein.AutoSize = true;
            this.rbtReparatieKlein.Location = new System.Drawing.Point(724, 48);
            this.rbtReparatieKlein.Name = "rbtReparatieKlein";
            this.rbtReparatieKlein.Size = new System.Drawing.Size(134, 21);
            this.rbtReparatieKlein.TabIndex = 19;
            this.rbtReparatieKlein.TabStop = true;
            this.rbtReparatieKlein.Text = "Kleine Reparatie";
            this.rbtReparatieKlein.UseVisualStyleBackColor = true;
            // 
            // lblReparatieBevestiging
            // 
            this.lblReparatieBevestiging.AutoSize = true;
            this.lblReparatieBevestiging.Location = new System.Drawing.Point(721, 17);
            this.lblReparatieBevestiging.Name = "lblReparatieBevestiging";
            this.lblReparatieBevestiging.Size = new System.Drawing.Size(128, 17);
            this.lblReparatieBevestiging.TabIndex = 18;
            this.lblReparatieBevestiging.Text = "Bevestig Reparatie";
            // 
            // tbxReparatieBevestiging
            // 
            this.tbxReparatieBevestiging.Location = new System.Drawing.Point(724, 88);
            this.tbxReparatieBevestiging.Multiline = true;
            this.tbxReparatieBevestiging.Name = "tbxReparatieBevestiging";
            this.tbxReparatieBevestiging.Size = new System.Drawing.Size(286, 147);
            this.tbxReparatieBevestiging.TabIndex = 17;
            // 
            // btnReparatieBevestiging
            // 
            this.btnReparatieBevestiging.Location = new System.Drawing.Point(724, 299);
            this.btnReparatieBevestiging.Name = "btnReparatieBevestiging";
            this.btnReparatieBevestiging.Size = new System.Drawing.Size(81, 31);
            this.btnReparatieBevestiging.TabIndex = 16;
            this.btnReparatieBevestiging.Text = "Bevestig";
            this.btnReparatieBevestiging.UseVisualStyleBackColor = true;
            this.btnReparatieBevestiging.Click += new System.EventHandler(this.btnReparatieBevestiging_Click);
            // 
            // lblReparatie
            // 
            this.lblReparatie.AutoSize = true;
            this.lblReparatie.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblReparatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparatie.Location = new System.Drawing.Point(14, 0);
            this.lblReparatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReparatie.Name = "lblReparatie";
            this.lblReparatie.Size = new System.Drawing.Size(44, 25);
            this.lblReparatie.TabIndex = 10;
            this.lblReparatie.Text = "Info";
            // 
            // pnlReparatie
            // 
            this.pnlReparatie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReparatie.Controls.Add(this.lvwReparatie);
            this.pnlReparatie.Location = new System.Drawing.Point(9, 17);
            this.pnlReparatie.Margin = new System.Windows.Forms.Padding(4);
            this.pnlReparatie.Name = "pnlReparatie";
            this.pnlReparatie.Size = new System.Drawing.Size(667, 326);
            this.pnlReparatie.TabIndex = 9;
            // 
            // lvwReparatie
            // 
            this.lvwReparatie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTramId,
            this.clmTramnummer,
            this.clmTramType,
            this.clmSpoor,
            this.clmSector,
            this.clmDefect});
            this.lvwReparatie.FullRowSelect = true;
            this.lvwReparatie.HideSelection = false;
            this.lvwReparatie.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvwReparatie.Location = new System.Drawing.Point(9, 11);
            this.lvwReparatie.Margin = new System.Windows.Forms.Padding(4);
            this.lvwReparatie.MultiSelect = false;
            this.lvwReparatie.Name = "lvwReparatie";
            this.lvwReparatie.Size = new System.Drawing.Size(656, 292);
            this.lvwReparatie.TabIndex = 8;
            this.lvwReparatie.UseCompatibleStateImageBehavior = false;
            this.lvwReparatie.View = System.Windows.Forms.View.Details;
            // 
            // clmTramnummer
            // 
            this.clmTramnummer.Text = "Tramnummer";
            this.clmTramnummer.Width = 105;
            // 
            // clmTramType
            // 
            this.clmTramType.Text = "TramType";
            this.clmTramType.Width = 100;
            // 
            // clmSpoor
            // 
            this.clmSpoor.Text = "Spoor";
            this.clmSpoor.Width = 79;
            // 
            // clmSector
            // 
            this.clmSector.Text = "Sector";
            // 
            // clmDefect
            // 
            this.clmDefect.Text = "Defect";
            this.clmDefect.Width = 105;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clmSchoonmaakInfoTramId
            // 
            this.clmSchoonmaakInfoTramId.Text = "Tram Id";
            // 
            // clmTramId
            // 
            this.clmTramId.Text = "Tram Id";
            // 
            // OnderhoudApplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 539);
            this.Controls.Add(this.tabOnderhoud);
            this.Name = "OnderhoudApplicatie";
            this.Text = "OnderhoudApplicatie";
            this.tabOnderhoud.ResumeLayout(false);
            this.tabSchoonmaak.ResumeLayout(false);
            this.tabSchoonmaak.PerformLayout();
            this.pnlSchoonmaak.ResumeLayout(false);
            this.tabReparatie.ResumeLayout(false);
            this.tabReparatie.PerformLayout();
            this.pnlReparatie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOnderhoud;
        private System.Windows.Forms.TabPage tabSchoonmaak;
        private System.Windows.Forms.TabPage tabReparatie;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblSchoonmaak;
        private System.Windows.Forms.Panel pnlSchoonmaak;
        private System.Windows.Forms.Label lblReparatie;
        private System.Windows.Forms.Panel pnlReparatie;
        private System.Windows.Forms.Label lblSchoonmaakBevestiging;
        private System.Windows.Forms.TextBox tbxSchoonmaakBevestiging;
        private System.Windows.Forms.Button btnSchoonmaakBevestiging;
        private System.Windows.Forms.Label lblReparatieBevestiging;
        private System.Windows.Forms.TextBox tbxReparatieBevestiging;
        private System.Windows.Forms.Button btnReparatieBevestiging;
        private System.Windows.Forms.RadioButton rbtReparatieGroot;
        private System.Windows.Forms.RadioButton rbtReparatieKlein;
        private System.Windows.Forms.RadioButton rbtSchoonmaakGroot;
        private System.Windows.Forms.RadioButton rbtSchoonmaakKlein;
        private System.Windows.Forms.DateTimePicker dtpSchoonmaak;
        private System.Windows.Forms.DateTimePicker dtpReparatie;
        private System.Windows.Forms.ComboBox cbSchoonmaakMedewerker;
        private System.Windows.Forms.ComboBox cbReparatieMedewerker;
        private System.Windows.Forms.ListView lvwSchoonmaak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvwReparatie;
        private System.Windows.Forms.ColumnHeader clmTramnummer;
        private System.Windows.Forms.ColumnHeader clmTramType;
        private System.Windows.Forms.ColumnHeader clmSpoor;
        private System.Windows.Forms.ColumnHeader clmSector;
        private System.Windows.Forms.ColumnHeader clmDefect;
        private System.Windows.Forms.ColumnHeader clmSchoonmaakInfoTramId;
        private System.Windows.Forms.ColumnHeader clmTramId;
    }
}