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
    public partial class SpoorBediening : Form
    {
        public SpoorBediening()
        {
            InitializeComponent();
            foreach(Spoor s in RemiseManager.Sporen)
            cbSpoor.Items.Add(Convert.ToString(s.Nummer));
        }

        private void btnSpoorstatus_Click(object sender, EventArgs e)
        {
            string SectorNR_string = cbSector.Text;
            int SectorNR;
            int SpoorNR = Convert.ToInt32(cbSpoor.Text);
            try
            {
                SectorNR = Convert.ToInt32(SectorNR_string);
            }
            catch
            {
                MessageBox.Show("Voer een sectornummer in");
                return;
            }
            foreach (Sector s in RemiseManager.sectorenVanSpoor(SpoorNR))
            {
                if (s.Id == SectorNR && s.Blokkade == true)
                {
                    MessageBox.Show("Sector is vrijgemaakt");
                    s.Deblokkeer();
                    foreach (Sector sec in RemiseManager.sectorenVanSpoor(SpoorNR))
                    {
                        if (sec.Id > SectorNR)
                        {
                            sec.Deblokkeer();
                            //RemiseManager.UpdateSectorStatus(sec.Id);
                        }
                    }
                }
                else if (s.Id == SectorNR && s.Blokkade == false)
                {
                    MessageBox.Show("Sector is Geblokkeerd");
                    s.Blokkeer();
                    foreach (Sector sec in RemiseManager.sectorenVanSpoor(SpoorNR))
                    {
                        if (sec.Id > SectorNR)
                        {
                            sec.Blokkeer();
                            //RemiseManager.UpdateSectorStatus(sec.Id);
                        }
                    }
                }
            }
            //RemiseManager.UpdateSectorStatus(SectorNR);
        }

        private void SpoorBediening_Load(object sender, EventArgs e)
        {

        }

        private void cbSpoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SpoorNummer = Convert.ToInt32(cbSpoor.Text);
            foreach (Sector sec in RemiseManager.sectorenVanSpoor(SpoorNummer))
            cbSector.Items.Add(sec.Id);
        }
    }
}
