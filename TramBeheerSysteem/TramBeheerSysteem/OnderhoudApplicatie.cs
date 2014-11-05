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
            Tram selectedTram = DatabaseManager.TramInformatie(Convert.ToInt32(lvwSchoonmaak.Items[lvwSchoonmaak.FocusedItem.Index].SubItems[0].Text));
            string opmerking = tbxSchoonmaakBevestiging.Text;
            bool schoongemaakt = chkSchoonmaak.Checked;
            //DatabaseManager.TramSchoongemaakt(selectedTram, opmerking, schoongemaakt);
        }

        private void btnReparatieBevestiging_Click(object sender, EventArgs e)
        {
            Tram selectedTram = DatabaseManager.TramInformatie(Convert.ToInt32(lvwReparatie.Items[lvwReparatie.FocusedItem.Index].SubItems[0].Text));
            string opmerking = tbxReparatieBevestiging.Text;
            bool gerepareerd = chkReparatie.Checked;
            //DatabaseManager.TramGerepareerd(selectedTram, opmerking, gerepareerd);
        }
    }
}
