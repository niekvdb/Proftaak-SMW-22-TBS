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
            string NR_tram = tbTramnummer.Text;
            string NR_spoor = tbSpoornummer.Text;
            string NR_sector = tbSectornummer.Text;
            int NR;

            // Check of textbox ID te converteren is naar Int32
            try
            {
                NR = Convert.ToInt32(NR_tram);
            }
            catch
            {
                MessageBox.Show("Voer een tram-nummer in");
                return;
            }
        }
    }
}
