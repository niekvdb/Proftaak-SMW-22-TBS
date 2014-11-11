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
    public partial class WijzigTramStatus : Form
    {
        public WijzigTramStatus()
        {
            InitializeComponent();
            foreach (Tram t in TramManager.Trams)
            {
                cbTramnummer.Items.Add(Convert.ToString(t.nummer));
            }
        }

        private void Voeg_Tram_toe_Load(object sender, EventArgs e)
        {

        }

        private void btnWijzig_Click(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een status");               
                return;
            }
            if (cbTramnummer.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een tram");
                return;
            } 
            string Status = cbStatus.Text;
            int tramnummer = Convert.ToInt32(cbTramnummer.Text);
            foreach (Tram tram in TramManager.Trams)
            {               
                if (tram.nummer == tramnummer)
                {
                    if (tram.status == cbStatus.Text)
                    {
                        MessageBox.Show("Tram heeft deze status al!");
                    }
                    else
                    {
                        tram.VeranderTramstatus(cbStatus.Text);
                        DatabaseManager.registreerTramStatus(tram);
                        if (cbStatus.Text == "Defect" || cbStatus.Text == "Schoonmaak")
                        MessageBox.Show("Tramstatus is gewijzigd");
                    }
                }
            }
            this.Close();
        }
    }
}
