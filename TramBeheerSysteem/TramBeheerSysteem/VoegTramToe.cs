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

            int NR_tram;
            int NR_spoor;
            int NR_sector;

            // Check of textbox ID te converteren is naar Int32
            try
            {
                NR_tram = Convert.ToInt32(tbTramnummer.Text);
                NR_spoor = Convert.ToInt32(tbSpoornummer.Text);
                NR_sector = Convert.ToInt32(tbSectornummer.Text);
            }
            catch
            {
                MessageBox.Show("Voer geldige nummers in");
                return;
            }

            if (TramManager.HaalTramOp(NR_tram))
            {
                if (RemiseManager.HaalSpoorOp(NR_spoor))
                {
                    foreach (Sector sec in RemiseManager.sectorenVanSpoor(NR_spoor))
                        if (sec.Id == NR_sector)
                        {
                            RemiseManager.VoegTramToeAanSector(NR_sector, NR_tram);
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
