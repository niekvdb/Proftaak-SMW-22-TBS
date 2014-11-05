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
        }
         public WijzigTramStatus(int KnopNummer)
        {
            InitializeComponent();
                 //foreach(Tram t in DatabaseManager.HaalTramsOp())
                 //cbTramnummer.Items.Add(t.nummer)

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
            string NR_string = cbTramnummer.Text;
            string Status = cbStatus.Text;
            int NR;

            // Check of textbox ID te converteren is naar Int32
            try
            {
                NR = Convert.ToInt32(NR_string);
            }
            catch
            {
                MessageBox.Show("Voer een tram-nummer in");
                return;
            }
            // foreach (Tram t in DatabaseManager.HaalTramsOp)
            //  {
            //     if (t.nummer == NR && t.status== StatusCb.text)
            //    {
            //        MessageBox.Show("Tram heeft deze status al!");
            //    }
            //     else 
            //    {
            //      MessageBox.Show("Tramstatus is gewijzigd");
            //      DatabaseManager.WijzigTramStatus(NR);
            //    }
            //}

            MessageBox.Show("Tramstatus is gewijzigd");
            this.Close();
        }


    }
}
