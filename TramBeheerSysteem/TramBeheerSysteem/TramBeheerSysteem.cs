using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TramBeheerSysteem
{
    public partial class TramBeheerSysteem : Form
    {

        int xPosTb = 5;
        int yPosTb = 5;
        private int maxSectors = 0;

        public TramBeheerSysteem()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            voegSporenToeVoorbeeld();
        }

        private void voegSporenToeVoorbeeld()
        {
            // VoorbeeldData
            List<Sector> sL = new List<Sector>();
            for (int i = 0; i < 4; i++)
            {
                Sector s = new Sector(i, i + 1, null, true, false);
                sL.Add(s);
            }
            Spoor sp1 = new Spoor(1, null, 38, 4, true, false, false, sL);
            Spoor sp2 = new Spoor(2, null, 37, 4, true, false, false, sL);
            AddTextBoxes(sp1);
            AddTextBoxes(sp2);
            AddTextBoxes(new Spoor(3, null, 36, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 35, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 34, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 33, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 32, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 31, 3, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 30, 3, true, false, false, sL));

            AddTextBoxes(new Spoor(3, null, 40, 7, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 41, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 42, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 43, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 44, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 45, 9, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 58, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 57, 8, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 56, 8, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 55, 8, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 54, 7, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 53, 7, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 52, 7, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 51, 6, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 64, 5, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 63, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 62, 3, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 61, 3, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 74, 5, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 75, 4, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 76, 5, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 77, 6, true, false, false, sL));

            AddTextBoxes(new Spoor(3, null, 12, 1, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 13, 1, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 14, 1, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 15, 1, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 16, 1, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 17, 1, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 18, 1, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 19, 1, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 20, 1, true, false, false, sL));
            AddTextBoxes(new Spoor(3, null, 21, 1, true, false, false, sL));
        }

        private void AddTextBoxes(Spoor spoor)
        {
            Size tbSize = new Size(35,20);
            TextBox spoorTb = new TextBox
            {
                Text = spoor.Nummer.ToString(),
                Size = tbSize,
                TextAlign = HorizontalAlignment.Center,
                ReadOnly = true,
                Location = new System.Drawing.Point(xPosTb, yPosTb)
            };
            PanelTBS.Controls.Add(spoorTb);
            for (int i = 1; i <= spoor.Lengte; i++)
            {
                TextBox sectorTb = new TextBox
                {
                    Size = tbSize,
                    Location = new System.Drawing.Point(xPosTb, yPosTb + (5*i) + (tbSize.Height*i)),
                    TextAlign = HorizontalAlignment.Center
                };
                PanelTBS.Controls.Add(sectorTb);
            }
            xPosTb = xPosTb + tbSize.Width + 5;
            if (spoor.Lengte > maxSectors)
            {
                maxSectors = spoor.Lengte;
            }
            if (xPosTb + tbSize.Width + 25> PanelTBS.Width)
            {
                yPosTb = yPosTb + (tbSize.Height*(maxSectors +4));
                xPosTb = 5;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void schoonmaakToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
