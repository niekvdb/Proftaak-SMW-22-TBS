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
    public partial class OnderhoudApplicatie : Form
    {
        public OnderhoudApplicatie()
        {
            InitializeComponent();
            //voegt alle medewerkersnamen toe in de comboboxes
            foreach (Medewerker medewerker in RemiseManager.Medewerkers)
            {
                cbReparatieMedewerker.Items.Add(medewerker.Naam);
                cbSchoonmaakMedewerker.Items.Add(medewerker.Naam);
            }
            string spoornummer;
            string sectornummer;
            //voegt alle trams+info toe in de listview
            foreach (Tram tram in TramManager.Trams)
            {
                    if (RemiseManager.sectorViaTram(tram) == null)
                    {
                        spoornummer = "geen";
                        sectornummer = "geen";
                    }
                    else
                    {
                        spoornummer = Convert.ToString(RemiseManager.sectorViaTram(tram).SpoorNummer);
                        sectornummer = Convert.ToString(RemiseManager.sectorViaTram(tram).Nummer);
                    }
                    var tram1 = new ListViewItem(new[] {Convert.ToString(tram.Id), Convert.ToString(tram.nummer), Convert.ToString(tram.tramtype), spoornummer, sectornummer, Convert.ToString(tram.vervuild), Convert.ToString(tram.vervuild), Convert.ToString(tram.defect), Convert.ToString(tram.vervuild) });
                    var tram2 = new ListViewItem(new[] {Convert.ToString(tram.Id), Convert.ToString(tram.nummer), Convert.ToString(tram.tramtype), spoornummer, sectornummer, Convert.ToString(tram.vervuild), Convert.ToString(tram.vervuild), Convert.ToString(tram.defect), Convert.ToString(tram.defect) });
                    lvwSchoonmaak.Items.Add(tram1);
                    lvwReparatie.Items.Add(tram2);
            }
        }

        private void btnSchoonmaakBevestiging_Click(object sender, EventArgs e)
        {
            Tram selectedTram = TramManager.tramViaId(Convert.ToInt32(lvwSchoonmaak.Items[lvwSchoonmaak.FocusedItem.Index].SubItems[0].Text));
            string opmerking = tbxSchoonmaakBevestiging.Text;
            TypeOnderhoud Schoonmaak;
            Medewerker medewerker = RemiseManager.medewerkerViaNaam(Convert.ToString(cbSchoonmaakMedewerker.SelectedItem));
            DateTime beschikbaarDatum = dtpSchoonmaak.Value;
            if (rbtSchoonmaakGroot.Checked)
            {
                Schoonmaak = TypeOnderhoud.GroteSchoonmaak;
                selectedTram.Onderhoud(Schoonmaak, opmerking, beschikbaarDatum, medewerker);
                MessageBox.Show("toegevoegd!");
            }
            else if (rbtSchoonmaakKlein.Checked)
            {
                Schoonmaak = TypeOnderhoud.KleineSchoonmaak;
                selectedTram.Onderhoud(Schoonmaak, opmerking, beschikbaarDatum, medewerker);
                MessageBox.Show("toegevoegd!");
            }
            else MessageBox.Show("Selecteer een schoonmaaktype");
        }

        private void btnReparatieBevestiging_Click(object sender, EventArgs e)
        {
            Tram selectedTram = TramManager.tramViaId(Convert.ToInt32(lvwReparatie.Items[lvwSchoonmaak.FocusedItem.Index].SubItems[0].Text));
            string opmerking = tbxReparatieBevestiging.Text;
            TypeOnderhoud reparatie;
            Medewerker medewerker = RemiseManager.medewerkerViaNaam(Convert.ToString(cbSchoonmaakMedewerker.SelectedItem));
            DateTime beschikbaarDatum = dtpReparatie.Value;
            if (rbtReparatieGroot.Checked)
            {
                reparatie = TypeOnderhoud.GroteReparatie;
                selectedTram.Onderhoud(reparatie, opmerking, beschikbaarDatum, medewerker);
                MessageBox.Show("toegevoegd!");
            }
            else if (rbtReparatieKlein.Checked)
            {
                reparatie = TypeOnderhoud.KleineReparatie;
                selectedTram.Onderhoud(reparatie, opmerking, beschikbaarDatum, medewerker);
                MessageBox.Show("toegevoegd!");
            }
            else MessageBox.Show("Selecteer een reparatietype");
        }
    }
}
