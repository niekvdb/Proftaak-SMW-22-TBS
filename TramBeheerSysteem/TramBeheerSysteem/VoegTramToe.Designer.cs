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
            this.tbTramnummer.Location = new System.Drawing.Point(33, 106);
            this.tbTramnummer.Name = "tbTramnummer";
            this.tbTramnummer.Size = new System.Drawing.Size(77, 22);
            this.tbTramnummer.TabIndex = 0;
            // 
            // tbSpoornummer
            // 
            this.tbSpoornummer.Location = new System.Drawing.Point(142, 106);
            this.tbSpoornummer.Name = "tbSpoornummer";
            this.tbSpoornummer.Size = new System.Drawing.Size(77, 22);
            this.tbSpoornummer.TabIndex = 1;
            // 
            // tbSectornummer
            // 
            this.tbSectornummer.Location = new System.Drawing.Point(273, 106);
            this.tbSectornummer.Name = "tbSectornummer";
            this.tbSectornummer.Size = new System.Drawing.Size(77, 22);
            this.tbSectornummer.TabIndex = 2;
            // 
            // lbTramnummer
            // 
            this.lbTramnummer.AutoSize = true;
            this.lbTramnummer.Location = new System.Drawing.Point(30, 68);
            this.lbTramnummer.Name = "lbTramnummer";
            this.lbTramnummer.Size = new System.Drawing.Size(92, 17);
            this.lbTramnummer.TabIndex = 3;
            this.lbTramnummer.Text = "Tramnummer";
            // 
            // lbSpoornummer
            // 
            this.lbSpoornummer.AutoSize = true;
            this.lbSpoornummer.Location = new System.Drawing.Point(139, 68);
            this.lbSpoornummer.Name = "lbSpoornummer";
            this.lbSpoornummer.Size = new System.Drawing.Size(97, 17);
            this.lbSpoornummer.TabIndex = 4;
            this.lbSpoornummer.Text = "Spoornummer";
            // 
            // lbSectornummer
            // 
            this.lbSectornummer.AutoSize = true;
            this.lbSectornummer.Location = new System.Drawing.Point(270, 68);
            this.lbSectornummer.Name = "lbSectornummer";
            this.lbSectornummer.Size = new System.Drawing.Size(100, 17);
            this.lbSectornummer.TabIndex = 5;
            this.lbSectornummer.Text = "Sectornummer";
            // 
            // btnBevestig
            // 
            this.btnBevestig.Location = new System.Drawing.Point(48, 165);
            this.btnBevestig.Name = "btnBevestig";
            this.btnBevestig.Size = new System.Drawing.Size(99, 47);
            this.btnBevestig.TabIndex = 6;
            this.btnBevestig.Text = "Bevestig";
            this.btnBevestig.UseVisualStyleBackColor = true;
            this.btnBevestig.Click += new System.EventHandler(this.btnBevestig_Click);
            // 
            // btnAnnuleer
            // 
            this.btnAnnuleer.Location = new System.Drawing.Point(252, 165);
            this.btnAnnuleer.Name = "btnAnnuleer";
            this.btnAnnuleer.Size = new System.Drawing.Size(98, 46);
            this.btnAnnuleer.TabIndex = 7;
            this.btnAnnuleer.Text = "Annuleer";
            this.btnAnnuleer.UseVisualStyleBackColor = true;
            this.btnAnnuleer.Click += new System.EventHandler(this.btnAnnuleer_Click);
            // 
            // VoegTramToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 248);
            this.Controls.Add(this.btnAnnuleer);
            this.Controls.Add(this.btnBevestig);
            this.Controls.Add(this.lbSectornummer);
            this.Controls.Add(this.lbSpoornummer);
            this.Controls.Add(this.lbTramnummer);
            this.Controls.Add(this.tbSectornummer);
            this.Controls.Add(this.tbSpoornummer);
            this.Controls.Add(this.tbTramnummer);
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