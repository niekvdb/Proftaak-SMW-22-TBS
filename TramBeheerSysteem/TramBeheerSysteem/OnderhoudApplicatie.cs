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
        }

        private void btnSchoonmaakBevestiging_Click(object sender, EventArgs e)
        {
            Tram selectedTram = TramManager.tramViaId(Convert.ToInt32(lvwSchoonmaak.Items[lvwSchoonmaak.FocusedItem.Index].SubItems[0].Text));
            string opmerking = tbxSchoonmaakBevestiging.Text;
            TypeOnderhoud Schoonmaak;
            DateTime beschikbaarDatum = dtpSchoonmaak.Value;
            if (rbtSchoonmaakGroot.Checked)
            {
                Schoonmaak = TypeOnderhoud.GroteSchoonmaak;
                selectedTram.Onderhoud(Schoonmaak, opmerking, beschikbaarDatum);
            }
            else if (rbtSchoonmaakKlein.Checked)
            {
                Schoonmaak = TypeOnderhoud.KleineSchoonmaak;
                selectedTram.Onderhoud(Schoonmaak, opmerking, beschikbaarDatum);
            }
            else MessageBox.Show("Selecteer een schoonmaaktype");
        }

        private void btnReparatieBevestiging_Click(object sender, EventArgs e)
        {
            Tram selectedTram = TramManager.tramViaId(Convert.ToInt32(lvwReparatie.Items[lvwSchoonmaak.FocusedItem.Index].SubItems[0].Text));
            string opmerking = tbxReparatieBevestiging.Text;
            TypeOnderhoud reparatie;
            DateTime beschikbaarDatum = dtpReparatie.Value;
            if (rbtReparatieGroot.Checked)
            {
                reparatie = TypeOnderhoud.GroteReparatie;
                selectedTram.Onderhoud(reparatie, opmerking, beschikbaarDatum);
            }
            else if (rbtReparatieKlein.Checked)
            {
                reparatie = TypeOnderhoud.KleineReparatie;
                selectedTram.Onderhoud(reparatie, opmerking, beschikbaarDatum);
            }
            else MessageBox.Show("Selecteer een reparatietype");
        }
    }
}
