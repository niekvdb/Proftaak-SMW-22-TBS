namespace TramBeheerSysteem
{
    partial class Voeg_Tram_toe
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TramnummerTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VoegToeBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StatusCb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TramnummerTbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.VoegToeBtn);
            this.groupBox2.Location = new System.Drawing.Point(170, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(218, 257);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "        Tram";
            // 
            // StatusCb
            // 
            this.StatusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Indienst",
            "Remise",
            "Schoonmaak",
            "Defect"});
            this.StatusCb.Location = new System.Drawing.Point(12, 155);
            this.StatusCb.Margin = new System.Windows.Forms.Padding(4);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(160, 24);
            this.StatusCb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status";
            // 
            // TramnummerTbox
            // 
            this.TramnummerTbox.Location = new System.Drawing.Point(13, 78);
            this.TramnummerTbox.Margin = new System.Windows.Forms.Padding(4);
            this.TramnummerTbox.Name = "TramnummerTbox";
            this.TramnummerTbox.Size = new System.Drawing.Size(159, 22);
            this.TramnummerTbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nr";
            // 
            // VoegToeBtn
            // 
            this.VoegToeBtn.Location = new System.Drawing.Point(12, 196);
            this.VoegToeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.VoegToeBtn.Name = "VoegToeBtn";
            this.VoegToeBtn.Size = new System.Drawing.Size(157, 28);
            this.VoegToeBtn.TabIndex = 0;
            this.VoegToeBtn.Text = "Voeg Toe";
            this.VoegToeBtn.UseVisualStyleBackColor = true;
            this.VoegToeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Voeg_Tram_toe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 331);
            this.Controls.Add(this.groupBox2);
            this.Name = "Voeg_Tram_toe";
            this.Text = "Voeg tram toe";
            this.Load += new System.EventHandler(this.Voeg_Tram_toe_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TramnummerTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VoegToeBtn;
    }
}