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
    public partial class TramBeheerSysteem : Form
    {
        public TramBeheerSysteem()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void schoonmaakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoonMaakLijst s = new SchoonMaakLijst();
            s.Show();
        }

        private void voegToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voeg_Tram_toe v = new Voeg_Tram_toe(0);
            v.Show();
            
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            string NR_string = cbTrams.Text;
            int NR;
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
            //     if (t.nummer != NR)
            //    {
            //        MessageBox.Show("Tram-nummer bestaat niet");
            //        return;
            //    }
            //      else
            //    {
            //      DatabaseManager.VerwijderTram(NR);
            //     }
            //}
            
        }

        private void TramBeheerSysteem_Load(object sender, EventArgs e)
        {

        }

        private void wijzigStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voeg_Tram_toe v = new Voeg_Tram_toe(1);
            v.Show();
        }

        private void statusVeranderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpoorBediening s = new SpoorBediening();
            s.Show();
        }
    }
}
