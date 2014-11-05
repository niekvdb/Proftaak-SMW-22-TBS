using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TramBeheerSysteem
{
    public partial class VoegTramToe : Form
    {
        public VoegTramToe()
        {
            InitializeComponent();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            string NR_tram = tbTramnummer.Text;
            string NR_spoor = tbSpoornummer.Text;
            string NR_sector = tbSectornummer.Text;
            int NR;
            int NR1;
            int NR2;

            // Check of textbox ID te converteren is naar Int32
            try
            {
                NR = Convert.ToInt32(NR_tram);
                NR1 = Convert.ToInt32(NR_spoor);
                NR2 = Convert.ToInt32(NR_sector);
            }
            catch
            {
                MessageBox.Show("Voer geldige nummers in");
                return;
            }

            if (TramManager.HaalTramOp(NR))
            {
                if (RemiseManager.HaalSpoorOp(NR1))
                {
                    foreach (Sector sec in RemiseManager.sectorenVanSpoor(NR1))
                        if (sec.Id == NR2)
                        {
                            RemiseManager.VoegTramToeAanSector(NR2,NR);
                        }
                }
                else
                {
                    MessageBox.Show("Spoor bestaat niet");
                }
            }
            else
            {
                MessageBox.Show("Tram bestaat niet");
            }

        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VoegTramToe_Load(object sender, EventArgs e)
        {

        }
    }
}
