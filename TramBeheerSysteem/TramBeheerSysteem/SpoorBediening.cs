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
            int SectorNR;
            int SpoorNR;
            if (!int.TryParse(cbSector.Text, out SectorNR) || !int.TryParse(cbSpoor.Text, out SpoorNR))
            {
                MessageBox.Show("Voer geldige nummers in");
                return;
            }
            Spoor spoor = RemiseManager.spoorViaNummer(SpoorNR);
            foreach (Sector sector in spoor.SectorList)
            {
                if (sector.Nummer == SectorNR && sector.Blokkade == true)
                {
                    MessageBox.Show("Sector is vrijgemaakt");
                    sector.Deblokkeer();
                    DatabaseManager.registreerSectorStatus(sector);
                    foreach (Sector sector1 in spoor.SectorList)
                    {
                        if (sector1.Nummer > SectorNR && sector1.Blokkade == true)
                        {
                            sector1.Deblokkeer();
                            DatabaseManager.registreerSectorStatus(sector1);
                        }
                        }
                    }
                else if (sector.Nummer == SectorNR && sector.Blokkade == false)
                {
                    MessageBox.Show("Sector is Geblokkeerd");
                    sector.Blokkeer();
                    DatabaseManager.registreerSectorStatus(sector);
                    foreach (Sector sector1 in spoor.SectorList)
                    {
                        if (sector1.Nummer > SectorNR)
                        {
                            sector1.Blokkeer();
                            DatabaseManager.registreerSectorStatus(sector1);
                        }
                    }
                }
            }
            
        }

        private void SpoorBediening_Load(object sender, EventArgs e)
        {

        }

        private void cbSpoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SpoorNummer = Convert.ToInt32(cbSpoor.Text);
            Spoor spoor = RemiseManager.spoorViaNummer(SpoorNummer);
            cbSector.Items.Clear();
            foreach (Sector sec in spoor.SectorList)
            cbSector.Items.Add(sec.Nummer);
        }
    }
}
