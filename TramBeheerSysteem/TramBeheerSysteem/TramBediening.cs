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
            foreach (Tram t in TramManager.LaadTrams())
            {
                cbTramnummer.Items.Add(Convert.ToString(t.Id));
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
            int NR = Convert.ToInt32(cbTramnummer.Text);
            foreach (Tram t in TramManager.LaadTrams())
            {
                if (t.Id == NR)
                {
                    if (t.status == cbStatus.Text)
                    {
                        MessageBox.Show("Tram heeft deze status al!");
                    }
                    else 
                    {
                        MessageBox.Show("Tramstatus is gewijzigd");
                        DatabaseManager.WijzigTramStatus(NR,Status);
                    }
                }
                else
                {
                    MessageBox.Show("Tramnummer bestaat niet");
                }
            }
            this.Close();
        }


    }
}
