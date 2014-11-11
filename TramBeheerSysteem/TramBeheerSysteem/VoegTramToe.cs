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
        private readonly TramBeheerSysteem mainForm;
        public VoegTramToe(TramBeheerSysteem form)
        {
            InitializeComponent();

            mainForm = form;
        }

        public VoegTramToe(string tramnummer)
        {
            InitializeComponent();
            tbTramnummer.Text = tramnummer;
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
                        if (lbSectornummer.Text != "Sectornummer")
                        {
                            TramIndeling tI = new TramIndeling();
                            Tram tram = TramManager.tramViaNummer(tramNr);
                            Sector sector = RemiseManager.sectorViaNummer(sectorNr, spoor);
                            string message = tI.DeelTramInOpSector(tram, sector);
                            MessageBox.Show(message);
                        }
                        else
                        {
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
                                        mainForm.refreshEenSpoor(RemiseManager.spoorViaId(sectorCheck.SpoorNummer));
                                    }
                                    if (sector.Blokkade == true)
                                    {
                                        MessageBox.Show("Sector is geblokkeerd");
                                        return;
                                    }
                                    sector.VoegTramToe(trammetje);
                                    mainForm.refreshEenSpoor(RemiseManager.spoorViaId(sector.SpoorNummer));
                                    DatabaseManager.registreerSectorStatus(sector);
                                    MessageBox.Show("Tram is toegevoegd");
                                    this.Close();
                                    return;
                                }
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

        private void VoegTramToe_Load(object sender, EventArgs e)
        {

        }

        private void tbTramnummer_Leave(object sender, EventArgs e)
        {
            int tramnummer = -1;
            Int32.TryParse(tbTramnummer.Text, out tramnummer);
            Tram tram = TramManager.tramViaNummer(tramnummer);
            if (tram != null)
            {
                if (tram.lengte > 1)lbSectornummer.Text = "Eerste sectornummer";
            }
            else MessageBox.Show("Tram bestaat niet");
        }
    }
}
