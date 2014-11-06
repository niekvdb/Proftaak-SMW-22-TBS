namespace TramBeheerSysteem
{
    partial class SpoorInfo
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.btnBevestig = new System.Windows.Forms.Button();
            this.lblSpoor = new System.Windows.Forms.Label();
            this.cbSporen = new System.Windows.Forms.ComboBox();
            this.lvwTrams = new System.Windows.Forms.ListView();
            this.clmSpoorInfoSpoorNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSpoorInfoRemise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSpoorInfoLengte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSpoorInfoBeschikbaar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(52, 159);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(121, 32);
            this.btnBevestig.TabIndex = 10;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // lblSpoor
            // 
            this.lblSpoor.AutoSize = true;
            this.lblSpoor.Location = new System.Drawing.Point(45, 49);
            this.lblSpoor.Name = "lblSpoor";
            this.lblSpoor.Size = new System.Drawing.Size(136, 17);
            this.lblSpoor.TabIndex = 9;
            this.lblSpoor.Text = "Selecteer een spoor";
            // 
            // cbSporen
            // 
            this.cbSporen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSporen.FormattingEnabled = true;
            this.cbSporen.Location = new System.Drawing.Point(52, 87);
            this.cbSporen.Name = "cbSporen";
            this.cbSporen.Size = new System.Drawing.Size(121, 24);
            this.cbSporen.TabIndex = 8;
            // 
            // lvwTrams
            // 
            this.lvwTrams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSpoorInfoSpoorNummer,
            this.clmSpoorInfoRemise,
            this.clmSpoorInfoLengte,
            this.clmSpoorInfoBeschikbaar});
            this.lvwTrams.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvwTrams.Location = new System.Drawing.Point(248, 38);
            this.lvwTrams.Margin = new System.Windows.Forms.Padding(4);
            this.lvwTrams.Name = "lvwTrams";
            this.lvwTrams.Size = new System.Drawing.Size(465, 230);
            this.lvwTrams.TabIndex = 11;
            this.lvwTrams.UseCompatibleStateImageBehavior = false;
            this.lvwTrams.View = System.Windows.Forms.View.Details;
            // 
            // clmSpoorInfoSpoorNummer
            // 
            this.clmSpoorInfoSpoorNummer.Text = "SpoorNummer";
            this.clmSpoorInfoSpoorNummer.Width = 105;
            // 
            // clmSpoorInfoRemise
            // 
            this.clmSpoorInfoRemise.Text = "Remise";
            this.clmSpoorInfoRemise.Width = 144;
            // 
            // clmSpoorInfoLengte
            // 
            this.clmSpoorInfoLengte.Text = "Lengte";
            this.clmSpoorInfoLengte.Width = 61;
            // 
            // clmSpoorInfoBeschikbaar
            // 
            this.clmSpoorInfoBeschikbaar.Text = "Beschikbaar";
            this.clmSpoorInfoBeschikbaar.Width = 91;
            // 
            // SpoorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 305);
            this.Controls.Add(this.lvwTrams);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.lblSpoor);
            this.Controls.Add(this.cbSporen);
            this.Name = "SpoorInfo";
            this.Text = "SpoorInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Label lblSpoor;
        private System.Windows.Forms.ComboBox cbSporen;
        private System.Windows.Forms.ListView lvwTrams;
        private System.Windows.Forms.ColumnHeader clmSpoorInfoSpoorNummer;
        private System.Windows.Forms.ColumnHeader clmSpoorInfoRemise;
        private System.Windows.Forms.ColumnHeader clmSpoorInfoLengte;
        private System.Windows.Forms.ColumnHeader clmSpoorInfoBeschikbaar;
    }
}