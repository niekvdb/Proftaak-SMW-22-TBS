namespace TramBeheerSysteem
{
    partial class WijzigTramStatus
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
            this.gbTram = new System.Windows.Forms.GroupBox();
            this.cbTramnummer = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbTramnummer = new System.Windows.Forms.Label();
            this.btnWijzig = new System.Windows.Forms.Button();
            this.gbTram.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTram
            // 
            this.gbTram.Controls.Add(this.cbTramnummer);
            this.gbTram.Controls.Add(this.cbStatus);
            this.gbTram.Controls.Add(this.lbStatus);
            this.gbTram.Controls.Add(this.lbTramnummer);
            this.gbTram.Controls.Add(this.btnWijzig);
            this.gbTram.Location = new System.Drawing.Point(170, 28);
            this.gbTram.Margin = new System.Windows.Forms.Padding(4);
            this.gbTram.Name = "gbTram";
            this.gbTram.Padding = new System.Windows.Forms.Padding(4);
            this.gbTram.Size = new System.Drawing.Size(218, 257);
            this.gbTram.TabIndex = 2;
            this.gbTram.TabStop = false;
            this.gbTram.Text = "        Tram";
            // 
            // cbTramnummer
            // 
            this.cbTramnummer.FormattingEnabled = true;
            this.cbTramnummer.Location = new System.Drawing.Point(7, 76);
            this.cbTramnummer.Name = "cbTramnummer";
            this.cbTramnummer.Size = new System.Drawing.Size(160, 24);
            this.cbTramnummer.TabIndex = 14;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Indienst",
            "Remise",
            "Schoonmaak",
            "Defect"});
            this.cbStatus.Location = new System.Drawing.Point(12, 155);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(160, 24);
            this.cbStatus.TabIndex = 13;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(8, 135);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(48, 17);
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Text = "Status";
            // 
            // lbTramnummer
            // 
            this.lbTramnummer.AutoSize = true;
            this.lbTramnummer.Location = new System.Drawing.Point(8, 32);
            this.lbTramnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTramnummer.Name = "lbTramnummer";
            this.lbTramnummer.Size = new System.Drawing.Size(23, 17);
            this.lbTramnummer.TabIndex = 6;
            this.lbTramnummer.Text = "Nr";
            // 
            // btnWijzig
            // 
            this.btnWijzig.Location = new System.Drawing.Point(12, 196);
            this.btnWijzig.Margin = new System.Windows.Forms.Padding(4);
            this.btnWijzig.Name = "btnWijzig";
            this.btnWijzig.Size = new System.Drawing.Size(160, 28);
            this.btnWijzig.TabIndex = 0;
            this.btnWijzig.Text = "Wijzig";
            this.btnWijzig.UseVisualStyleBackColor = true;
            this.btnWijzig.Click += new System.EventHandler(this.btnWijzig_Click);
            // 
            // WijzigTramStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 331);
            this.Controls.Add(this.gbTram);
            this.Name = "WijzigTramStatus";
            this.Text = "Voeg tram toe";
            this.Load += new System.EventHandler(this.Voeg_Tram_toe_Load);
            this.gbTram.ResumeLayout(false);
            this.gbTram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTram;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbTramnummer;
        private System.Windows.Forms.Button btnWijzig;
        private System.Windows.Forms.ComboBox cbTramnummer;
    }
}