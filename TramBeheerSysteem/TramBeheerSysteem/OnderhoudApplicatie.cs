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
            if (rbtSchoonmaakGroot.Checked)
            {
                Schoonmaak = TypeOnderhoud.GroteSchoonmaak;
                selectedTram.Onderhoud(Schoonmaak, opmerking);
            }
            else if (rbtSchoonmaakKlein.Checked)
            {
                Schoonmaak = TypeOnderhoud.KleineSchoonmaak;
                selectedTram.Onderhoud(Schoonmaak, opmerking);
            }
            else MessageBox.Show("Selecteer een schoonmaaktype");
        }

        private void btnReparatieBevestiging_Click(object sender, EventArgs e)
        {
            Tram selectedTram = DatabaseManager.TramInformatie(Convert.ToInt32(lvwReparatie.Items[lvwReparatie.FocusedItem.Index].SubItems[0].Text));
            string opmerking = tbxReparatieBevestiging.Text;
            //DatabaseManager.TramGerepareerd(selectedTram, opmerking, gerepareerd);
        }
    }
}
