namespace TramBeheerSysteem
{
    partial class TramInfo
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
            this.cbTrams = new System.Windows.Forms.ComboBox();
            this.lvwTrams = new System.Windows.Forms.ListView();
            this.clmTramInfoTramnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTramInfoTramType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSchoonmaakSpoor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTramInfoSector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTramInfoStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTramInfoVervuild = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTramInfoDefect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTram = new System.Windows.Forms.Label();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.clmTramInfoBeschikbaar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbTrams
            // 
            this.cbTrams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrams.FormattingEnabled = true;
            this.cbTrams.Location = new System.Drawing.Point(32, 91);
            this.cbTrams.Margin = new System.Windows.Forms.Padding(2);
            this.cbTrams.Name = "cbTrams";
            this.cbTrams.Size = new System.Drawing.Size(92, 21);
            this.cbTrams.TabIndex = 0;
            // 
            // lvwTrams
            // 
            this.lvwTrams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTramInfoTramnummer,
            this.clmTramInfoTramType,
            this.clmSchoonmaakSpoor,
            this.clmTramInfoSector,
            this.clmTramInfoStatus,
            this.clmTramInfoVervuild,
            this.clmTramInfoDefect,
            this.clmTramInfoBeschikbaar});
            this.lvwTrams.FullRowSelect = true;
            this.lvwTrams.HideSelection = false;
            this.lvwTrams.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvwTrams.Location = new System.Drawing.Point(158, 40);
            this.lvwTrams.MultiSelect = false;
            this.lvwTrams.Name = "lvwTrams";
            this.lvwTrams.Size = new System.Drawing.Size(493, 238);
            this.lvwTrams.TabIndex = 5;
            this.lvwTrams.UseCompatibleStateImageBehavior = false;
            this.lvwTrams.View = System.Windows.Forms.View.Details;
            // 
            // clmTramInfoTramnummer
            // 
            this.clmTramInfoTramnummer.Text = "Tramnummer";
            this.clmTramInfoTramnummer.Width = 105;
            // 
            // clmTramInfoTramType
            // 
            this.clmTramInfoTramType.Text = "TramType";
            this.clmTramInfoTramType.Width = 100;
            // 
            // clmSchoonmaakSpoor
            // 
            this.clmSchoonmaakSpoor.Text = "Spoor";
            this.clmSchoonmaakSpoor.Width = 79;
            // 
            // clmTramInfoSector
            // 
            this.clmTramInfoSector.Text = "Sector";
            // 
            // clmTramInfoStatus
            // 
            this.clmTramInfoStatus.Text = "Status";
            this.clmTramInfoStatus.Width = 105;
            // 
            // clmTramInfoVervuild
            // 
            this.clmTramInfoVervuild.Text = "Vervuild";
            this.clmTramInfoVervuild.Width = 105;
            // 
            // clmTramInfoDefect
            // 
            this.clmTramInfoDefect.Text = "Defect";
            this.clmTramInfoDefect.Width = 70;
            // 
            // lblTram
            // 
            this.lblTram.AutoSize = true;
            this.lblTram.Location = new System.Drawing.Point(26, 60);
            this.lblTram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTram.Name = "lblTram";
            this.lblTram.Size = new System.Drawing.Size(96, 13);
            this.lblTram.TabIndex = 6;
            this.lblTram.Text = "Selecteer een tram";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(32, 150);
            this.btnBevestig.Margin = new System.Windows.Forms.Padding(2);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(91, 26);
            this.btnBevestig.TabIndex = 7;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.button1_Click);
            // 
            // TramInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 308);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.lblTram);
            this.Controls.Add(this.lvwTrams);
            this.Controls.Add(this.cbTrams);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TramInfo";
            this.Text = "TramInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTrams;
        private System.Windows.Forms.ListView lvwTrams;
        private System.Windows.Forms.ColumnHeader clmTramInfoTramnummer;
        private System.Windows.Forms.ColumnHeader clmTramInfoTramType;
        private System.Windows.Forms.ColumnHeader clmSchoonmaakSpoor;
        private System.Windows.Forms.ColumnHeader clmTramInfoVervuild;
        private System.Windows.Forms.Label lblTram;
        private System.Windows.Forms.ColumnHeader clmTramInfoDefect;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.ColumnHeader clmTramInfoSector;
        private System.Windows.Forms.ColumnHeader clmTramInfoStatus;
        private System.Windows.Forms.ColumnHeader clmTramInfoBeschikbaar;
    }
}