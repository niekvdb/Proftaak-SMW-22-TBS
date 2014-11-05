using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TramBeheerSysteem
{
    public partial class TramBeheerSysteem : Form
    {
        public event EventHandler BlockSector;

        int xPosTb = 5;
        int yPosTb = 5;
        int horizontalRows = 1;
        int verticalRows = 1;
        private int maxSectors = 0;

        public TramBeheerSysteem()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            VoegSporenToeVoorbeeld();
            foreach (Tram t in DatabaseManager.HaalTramsOp())
            {
                cbTrams.Items.Add(t.nummer);
            }
        }

        private List<Sector> GenerateSectorList(int Lengte)
        {
            int id = 1;
            List<Sector> SctrList = new List<Sector>();
            for (int i = 1; i <= Lengte; i++)
            {
                Sector sector = new Sector(id,i,null,true,false);
                id++;
                SctrList.Add((sector));
            }
            return SctrList;
        }

        private void VoegSporenToeVoorbeeld()
        {
            //Deze lijst wordt uit de database gehaald
            List<Spoor> spoorList = new List<Spoor>
            {
                new Spoor(1, null, 38, 4, true, false, false, GenerateSectorList((4))),
                new Spoor(2, null, 37, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(2, null, 36, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(2, null, 35, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(2, null, 34, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(2, null, 33, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(2, null, 32, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(2, null, 31, 3, true, false, false, GenerateSectorList(3)),
                new Spoor(2, null, 30, 3, true, false, false, GenerateSectorList(3)),
                new Spoor(3, null, 40, 7, true, false, false, GenerateSectorList(7)),
                new Spoor(3, null, 41, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(3, null, 42, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(3, null, 43, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(3, null, 44, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(3, null, 45, 9, true, false, false, GenerateSectorList(9)),
                new Spoor(3, null, 58, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(3, null, 57, 8, true, false, false, GenerateSectorList(8)),
                new Spoor(3, null, 56, 8, true, false, false, GenerateSectorList(8)),
                new Spoor(3, null, 55, 8, true, false, false, GenerateSectorList(8)),
                new Spoor(3, null, 54, 7, true, false, false, GenerateSectorList(7)),
                new Spoor(3, null, 53, 7, true, false, false, GenerateSectorList(7)),
                new Spoor(3, null, 52, 7, true, false, false, GenerateSectorList(7)),
                new Spoor(3, null, 51, 6, true, false, false, GenerateSectorList(6)),
                new Spoor(3, null, 64, 5, true, false, false, GenerateSectorList(5)),
                new Spoor(3, null, 63, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(3, null, 62, 3, true, false, false, GenerateSectorList(3)),
                new Spoor(3, null, 61, 3, true, false, false, GenerateSectorList(3)),
                new Spoor(3, null, 74, 5, true, false, false, GenerateSectorList(5)),
                new Spoor(3, null, 75, 4, true, false, false, GenerateSectorList(4)),
                new Spoor(3, null, 76, 5, true, false, false, GenerateSectorList(5)),
                new Spoor(3, null, 77, 6, true, false, false, GenerateSectorList(6)),
                new Spoor(3, null, 12, 1, true, false, false, GenerateSectorList(1)),
                new Spoor(3, null, 13, 1, true, false, false, GenerateSectorList(1)),
                new Spoor(3, null, 14, 1, true, false, false, GenerateSectorList(1)),
                new Spoor(3, null, 15, 1, true, false, false, GenerateSectorList(1)),
                new Spoor(3, null, 16, 1, true, false, false, GenerateSectorList(1)),
                new Spoor(3, null, 17, 1, true, false, false, GenerateSectorList(1)),
                new Spoor(3, null, 18, 1, true, false, false, GenerateSectorList(1)),
                new Spoor(3, null, 19, 1, true, false, false, GenerateSectorList(1)),
                new Spoor(3, null, 20, 1, true, false, false, GenerateSectorList(1)),
                new Spoor(3, null, 21, 1, true, false, false, GenerateSectorList(1))
            };
            AddTextBoxes((spoorList));
        }

        private void AddTextBoxes(List<Spoor> SpoorList)
        {
            foreach (Spoor sp in SpoorList)
            {
                Size tbSize = new Size(35, 20);
                TextBox spoorTb = new TextBox
                {
                    Text = sp.Nummer.ToString(),
                    Size = tbSize,
                    TextAlign = HorizontalAlignment.Center,
                    ReadOnly = true,
                    Location = new System.Drawing.Point(xPosTb, yPosTb)
                };
                PanelTBS.Controls.Add(spoorTb);
                //for (int i = 1; i <= spoor.Lengte; i++)
                foreach(Sector se in sp.SectorList)
                {
                    TextBox sectorTb = new TextBox
                    {
                        Size = tbSize,
                        Location = new System.Drawing.Point(xPosTb, yPosTb + (5*se.Nummer) + (tbSize.Height*se.Nummer)),
                        TextAlign = HorizontalAlignment.Center,
                        Tag = "Spoor" + sp.Nummer + "_" + se.Nummer
                    };
                    sectorTb.Click += this.HandleBlockSector;
                    PanelTBS.Controls.Add(sectorTb);
                }
                xPosTb = xPosTb + tbSize.Width + 5;
                horizontalRows++;
                if (sp.SectorList.Count() > maxSectors)
                {
                    maxSectors = sp.SectorList.Count();
                }
                if (xPosTb + tbSize.Width + 25 > PanelTBS.Width)
                {
                    yPosTb = yPosTb + (tbSize.Height*(maxSectors + 4));
                    xPosTb = 5;
                    verticalRows++;
                    horizontalRows = 1;
                }
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
            VoegTramToe v = new VoegTramToe();
            v.Show();         
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (cbTrams.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een tram");
                return;
            }           
            int NR = Convert.ToInt32(cbTramnummer.Text);
            foreach (Tram t in DatabaseManager.HaalTramsOp)
            {
                if (t.nummer != NR)
                {
                    MessageBox.Show("Tram-nummer bestaat niet");
                }
                else
                {
                    DatabaseManager.VerwijderTram(NR);
                    MessageBox.Show("Tram is succesvol verwijderd");
                }
            }

        }

        private void TramBeheerSysteem_Load(object sender, EventArgs e)
        {

        }

        private void wijzigStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WijzigTramStatus v = new WijzigTramStatus();
            v.Show();
        }

        private void statusVeranderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpoorBediening s = new SpoorBediening();
            s.Show();
        }
        /// <summary>
        /// Tijdelijk gebruikt om te debuggen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Snel voorbeeld van controls zoeken d.m.v. Tag
            Control.ControlCollection controls = PanelTBS.Controls;
            foreach (Control c in controls)
            {

                if ((String)c.Tag == "Spoor34_3")
                {
                    c.Text = "found";
                }
            }
        }

        private void HandleBlockSector(object sender, EventArgs e)
        {
            this.OnBlockSector(sender,EventArgs.Empty);
        }
        /// <summary>
        /// Functie om spoor te blokkeren. Laat op dit moment alleen nog een textbox zien.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnBlockSector(object sender,EventArgs e)
        {
            EventHandler handler = this.BlockSector;
            if (handler != null)
            {
                handler(this, e);
            }
            TextBox clickedTextBox = (TextBox) sender;
            string tag = clickedTextBox.Tag.ToString();
            string spoor = string.Empty;
            string sector = string.Empty;
            spoor = tag.Substring(5);
            spoor = spoor.Substring(0, spoor.IndexOf("_"));
            sector = tag.Substring((tag.IndexOf("_")+1));
            MessageBox.Show("Spoor: "+spoor+System.Environment.NewLine + "Sector: "+sector);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}
