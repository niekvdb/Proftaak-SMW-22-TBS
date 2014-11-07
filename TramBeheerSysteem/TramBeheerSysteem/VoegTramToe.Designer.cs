namespace TramBeheerSysteem
{
    partial class VoegTramToe
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
            this.tbTramnummer = new System.Windows.Forms.TextBox();
            this.tbSpoornummer = new System.Windows.Forms.TextBox();
            this.tbSectornummer = new System.Windows.Forms.TextBox();
            this.lbTramnummer = new System.Windows.Forms.Label();
            this.lbSpoornummer = new System.Windows.Forms.Label();
            this.lbSectornummer = new System.Windows.Forms.Label();
            this.btnBevestig = new System.Windows.Forms.Button();
            this.btnAnnuleer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTramnummer
            // 
            this.tbTramnummer.Location = new System.Drawing.Point(25, 86);
            this.tbTramnummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTramnummer.Name = "tbTramnummer";
            this.tbTramnummer.Size = new System.Drawing.Size(59, 20);
            this.tbTramnummer.TabIndex = 0;
            this.tbTramnummer.Leave += new System.EventHandler(this.tbTramnummer_Leave);
            // 
            // tbSpoornummer
            // 
            this.tbSpoornummer.Location = new System.Drawing.Point(106, 86);
            this.tbSpoornummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSpoornummer.Name = "tbSpoornummer";
            this.tbSpoornummer.Size = new System.Drawing.Size(59, 20);
            this.tbSpoornummer.TabIndex = 1;
            // 
            // tbSectornummer
            // 
            this.tbSectornummer.Location = new System.Drawing.Point(205, 86);
            this.tbSectornummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSectornummer.Name = "tbSectornummer";
            this.tbSectornummer.Size = new System.Drawing.Size(59, 20);
            this.tbSectornummer.TabIndex = 2;
            // 
            // lbTramnummer
            // 
            this.lbTramnummer.AutoSize = true;
            this.lbTramnummer.Location = new System.Drawing.Point(22, 55);
            this.lbTramnummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTramnummer.Name = "lbTramnummer";
            this.lbTramnummer.Size = new System.Drawing.Size(68, 13);
            this.lbTramnummer.TabIndex = 3;
            this.lbTramnummer.Text = "Tramnummer";
            // 
            // lbSpoornummer
            // 
            this.lbSpoornummer.AutoSize = true;
            this.lbSpoornummer.Location = new System.Drawing.Point(104, 55);
            this.lbSpoornummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpoornummer.Name = "lbSpoornummer";
            this.lbSpoornummer.Size = new System.Drawing.Size(72, 13);
            this.lbSpoornummer.TabIndex = 4;
            this.lbSpoornummer.Text = "Spoornummer";
            // 
            // lbSectornummer
            // 
            this.lbSectornummer.AutoSize = true;
            this.lbSectornummer.Location = new System.Drawing.Point(202, 55);
            this.lbSectornummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSectornummer.Name = "lbSectornummer";
            this.lbSectornummer.Size = new System.Drawing.Size(75, 13);
            this.lbSectornummer.TabIndex = 5;
            this.lbSectornummer.Text = "Sectornummer";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(36, 134);
            this.btnBevestig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(74, 38);
            this.btnBevestig.TabIndex = 6;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.Location = new System.Drawing.Point(189, 134);
            this.btnAnnuleer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(74, 37);
            this.btnAnnuleer.TabIndex = 7;
            this.btnAnnuleer.Text = "Annuleer";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // VoegTramToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 202);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.lbSectornummer);
            this.Controls.Add(this.lbSpoornummer);
            this.Controls.Add(this.lbTramnummer);
            this.Controls.Add(this.tbSectornummer);
            this.Controls.Add(this.tbSpoornummer);
            this.Controls.Add(this.tbTramnummer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VoegTramToe";
            this.Text = "VoegTramToe";
            this.Load += new System.EventHandler(this.VoegTramToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTramnummer;
        private System.Windows.Forms.TextBox tbSpoornummer;
        private System.Windows.Forms.TextBox tbSectornummer;
        private System.Windows.Forms.Label lbTramnummer;
        private System.Windows.Forms.Label lbSpoornummer;
        private System.Windows.Forms.Label lbSectornummer;
        private System.Windows.Forms.Button btnBevestig;
        private System.Windows.Forms.Button btnAnnuleer;
    }
}