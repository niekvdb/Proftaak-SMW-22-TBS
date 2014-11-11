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
    public partial class TramInfo : Form
    {
        public TramInfo()
        {
            InitializeComponent();
            foreach (Tram t in TramManager.Trams)
            {
                cbTrams.Items.Add(Convert.ToString(t.nummer));
            }
            cbTrams.Sorted = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string spoornummer;
            string sectornummer;
            if (cbTrams.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst een tram!");
                return;
            }
            foreach (Tram tram in TramManager.Trams)
            {
                if (tram.nummer == Convert.ToInt32(cbTrams.Text))
                {
                    if (RemiseManager.sectorViaTram(tram) == null)
                    {
                        spoornummer = "geen";
                        sectornummer = "geen";
                    }
                    else
                    {
                        sectornummer = Convert.ToString(RemiseManager.sectorViaTram(tram).Nummer);
                        Spoor spoor = RemiseManager.spoorViaId(RemiseManager.sectorViaTram(tram).SpoorNummer);
                        spoornummer = Convert.ToString(spoor.Nummer);
                    }
                    string status = tram.status;
                    var tram1 = new ListViewItem(new[] { Convert.ToString(tram.nummer), Convert.ToString(tram.tramtype), spoornummer, sectornummer, status, Convert.ToString(tram.vervuild), Convert.ToString(tram.vervuild), Convert.ToString(tram.defect), Convert.ToString(tram.beschikbaar) });
                    lvwTrams.Items.Add(tram1);
                }
            }
        }

    }
}
