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
            RemiseManager.LaadRemises();
            TramManager.LaadTrams();
            RemiseManager.LaadSporen();
            RefreshSporen();
            foreach (Tram t in TramManager.Trams)
            {
                cbTrams.Items.Add(Convert.ToString(t.Id));
            }
            foreach (Medewerker medewerker in RemiseManager.Medewerkers)
            {
                gebruikerToolStripMenuItem.DropDownItems.Add(Convert.ToString(medewerker.Functie));
        }
        }

        private List<Sector> GenerateSectorList(int Lengte)
        {
            int id = 1;
            List<Sector> SctrList = new List<Sector>();
            for (int i = 1; i <= Lengte; i++)
            {
                Sector sector = new Sector(id,i,null,1,true,false);
                id++;
                SctrList.Add((sector));
            }
            return SctrList;
        }

        private void RefreshSporen()
        {
            PanelTBS.Controls.Clear();
            xPosTb = 5;
            yPosTb = 5;
            horizontalRows = 1;
            verticalRows = 1;
            maxSectors = 0;
            List<Spoor> spoorList = new List<Spoor>();
            spoorList = RemiseManager.Sporen;
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
                foreach(Sector se in sp.SectorList)
                {
                    TextBox sectorTb = new TextBox
                    {
                        Size = tbSize,
                        Location = new System.Drawing.Point(xPosTb, yPosTb + (5*se.Nummer) + (tbSize.Height*se.Nummer)),
                        TextAlign = HorizontalAlignment.Center,
                        Tag = Convert.ToString(se.Id)
                    };
                    if (se.SpoorNummer == 13)
                    {
                        //breakpoint
                    }
                    if (se.Tram != null)
                    {
                        sectorTb.Text = se.Tram.Id.ToString();
                    }
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
            OnderhoudApplicatie o = new OnderhoudApplicatie();
            o.Show();
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
            int TramNr = Convert.ToInt32(cbTrams.Text);
            foreach (Tram t in TramManager.Trams)
            {
                if (t.Id == TramNr)
                {
                    //TramManager.VerwijderTram(NR);
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
            /*
             * string spoor = string.Empty;
            string sector = string.Empty;
            spoor = tag.Substring(5);
            spoor = spoor.Substring(0, spoor.IndexOf("_"));
            sector = tag.Substring((tag.IndexOf("_")+1));
             * */
            MessageBox.Show("Sector id: " + tag); //"Spoor: "+spoor+System.Environment.NewLine + "Sector: "+sector);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TramIndeling indeling = new TramIndeling();
            Tram tram = new Tram(1, Tramtype.Combino, 9999, 4, string.Empty, null, false, false, true, true);
            List<Sector> ingedeeldeSectors = indeling.DeelTramIn(tram);
            if (ingedeeldeSectors != null)
            {
                foreach (Sector s in ingedeeldeSectors)
                {
                    MessageBox.Show(s.Id.ToString());
                }
            }
            else
            {
                MessageBox.Show("Geen vrije sectoren gevonden.");
            }
    }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshSporen();
        }

        private void reparatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
