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
            int tramNr;
            int spoorNr;
            int sectorNr;
            if (!int.TryParse(tbTramnummer.Text, out tramNr) || !int.TryParse(tbSpoornummer.Text, out spoorNr) || !int.TryParse(tbSectornummer.Text, out sectorNr))
            {
                MessageBox.Show("Voer geldige nummers in");
                return;
            }

           if (TramManager.tramViaNummer(tramNr) != null)
            {
                if (RemiseManager.spoorViaNummer(spoorNr) != null)
                {
                    Spoor spoor = RemiseManager.spoorViaNummer(spoorNr);
                    foreach (Sector sector in spoor.SectorList)
                    {
                        if (sector.Nummer == sectorNr)
                        {
                            Tram trammetje = TramManager.tramViaNummer(tramNr);
                            Sector sectorCheck = RemiseManager.sectorViaTram(trammetje);
                            if (sectorCheck != null)
                            {
                                sectorCheck.ClearSector();
                                DatabaseManager.registreerSectorStatus(sectorCheck);
                            }
                            if (sector.Blokkade == true)
                            {
                                MessageBox.Show("Sector is geblokkeerd");
                                return;
                            }
                            sector.VoegTramToe(trammetje);
                            DatabaseManager.registreerSectorStatus(sector);
                            MessageBox.Show("Tram is toegevoegd");
                            return;
                        }
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
