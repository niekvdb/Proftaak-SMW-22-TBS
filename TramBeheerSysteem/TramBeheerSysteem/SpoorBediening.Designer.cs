namespace TramBeheerSysteem
{
    partial class SpoorBediening
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
            this.btnSpoorstatus = new System.Windows.Forms.Button();
            this.cbSpoor = new System.Windows.Forms.ComboBox();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.lbSpoor = new System.Windows.Forms.Label();
            this.lbSector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpoorstatus
            // 
            this.btnSpoorstatus.Location = new System.Drawing.Point(209, 45);
            this.btnSpoorstatus.Name = "btnSpoorstatus";
            this.btnSpoorstatus.Size = new System.Drawing.Size(105, 64);
            this.btnSpoorstatus.TabIndex = 0;
            this.btnSpoorstatus.Text = "(de)Blokkeer";
            this.btnSpoorstatus.UseVisualStyleBackColor = true;
            this.btnSpoorstatus.Click += new System.EventHandler(this.btnSpoorstatus_Click);
            // 
            // cbSpoor
            // 
            this.cbSpoor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpoor.FormattingEnabled = true;
            this.cbSpoor.Location = new System.Drawing.Point(125, 45);
            this.cbSpoor.Name = "cbSpoor";
            this.cbSpoor.Size = new System.Drawing.Size(45, 24);
            this.cbSpoor.TabIndex = 2;
            this.cbSpoor.SelectedIndexChanged += new System.EventHandler(this.cbSpoor_SelectedIndexChanged);
            // 
            // cbSector
            // 
            this.cbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Location = new System.Drawing.Point(125, 85);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(45, 24);
            this.cbSector.TabIndex = 3;
            // 
            // lbSpoor
            // 
            this.lbSpoor.AutoSize = true;
            this.lbSpoor.Location = new System.Drawing.Point(53, 48);
            this.lbSpoor.Name = "lbSpoor";
            this.lbSpoor.Size = new System.Drawing.Size(46, 17);
            this.lbSpoor.TabIndex = 4;
            this.lbSpoor.Text = "Spoor";
            // 
            // lbSector
            // 
            this.lbSector.AutoSize = true;
            this.lbSector.Location = new System.Drawing.Point(53, 92);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(49, 17);
            this.lbSector.TabIndex = 5;
            this.lbSector.Text = "Sector";
            // 
            // SpoorBediening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 167);
            this.Controls.Add(this.lbSector);
            this.Controls.Add(this.lbSpoor);
            this.Controls.Add(this.cbSector);
            this.Controls.Add(this.cbSpoor);
            this.Controls.Add(this.btnSpoorstatus);
            this.Name = "SpoorBediening";
            this.Text = "SpoorBediening";
            this.Load += new System.EventHandler(this.SpoorBediening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpoorstatus;
        private System.Windows.Forms.ComboBox cbSpoor;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.Label lbSpoor;
        private System.Windows.Forms.Label lbSector;
    }
}