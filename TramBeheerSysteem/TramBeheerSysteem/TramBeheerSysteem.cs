using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Threading;

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
        private bool tramopspoor = false;

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
                cbTrams.Items.Add(Convert.ToString(t.nummer));
            }
            cbTrams.Sorted = true;
            foreach (Medewerker medewerker in RemiseManager.Medewerkers)
            {
                gebruikerToolStripMenuItem.DropDownItems.Add(Convert.ToString(medewerker.Functie));
            }
        }
        /// <summary>
        /// methode om de interface te refreshen.
        /// </summary>
        private void RefreshSporen()
        {
            PanelTBS.Controls.Clear();
            xPosTb = 5;
            yPosTb = 5;
            horizontalRows = 1;
            verticalRows = 1;
            maxSectors = 0;
            List<Spoor> spoorList = new List<Spoor>();
            RemiseManager.Sectors = null;
            RemiseManager.Medewerkers = null;
            RemiseManager.Remises = null;
            RemiseManager.Sporen = null;
            RemiseManager.LaadRemises();
            RemiseManager.LaadSporen();
            // Memoryleak opgelost?
            spoorList = RemiseManager.Sporen;
            AddTextBoxes((spoorList));
        }

        public void refreshEenSpoor(Spoor spoor)
        {
            Control.ControlCollection panelCollection = PanelTBS.Controls;
            bool tramopSpoor = false;
            //SeId_SeSpNo_SeNo
            foreach (Control c in panelCollection)
            {
                string tag = string.Empty;
                string spoorid = string.Empty;
                string sectorid = string.Empty;
                int sectoridint = 0;
                if (c.Tag != null && c.Tag != "")
                {
                    tag = (String) c.Tag;
                    spoorid = tag.Substring(tag.IndexOf("_")+1, tag.IndexOf("-") - tag.IndexOf("_")-1);
                }
                if (spoorid == spoor.Id.ToString())
                {
                    sectorid = tag.Substring(0, tag.IndexOf("_"));
                    Int32.TryParse(sectorid, out sectoridint);
                    Sector sector = RemiseManager.sectorViaId(sectoridint);
                    TextBox sectortb = (TextBox) c;
                    if ((sector.Blokkade || tramopSpoor)&&sector.Tram == null) sectortb.Enabled = false;
                    if (sector.Tram != null)
                    {
                        sectortb.Text = sector.Tram.nummer.ToString();
                        tramopSpoor = true;
                    }
                }
            }
        }
        /// <summary>
        /// Functie om op dynamische wijze textboxen die de sporen en sectoren voorstellen toe te voegen.
        /// </summary>
        /// <param name="SpoorList">Lijst met sporen die toegevoegd worden</param>
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
                        Tag = Convert.ToString(se.Id)+"_"+Convert.ToString(se.SpoorNummer)+"-"+Convert.ToString(se.Nummer)
                    };
                    if ((se.Blokkade || tramopspoor)&&se.Tram == null)
                    {
                        sectorTb.Enabled = false;
                            BlokkeerSporen((sectorTb));
                    }
                    if (se.Tram != null)
                    {
                        sectorTb.Text = se.Tram.nummer.ToString();
                        tramopspoor = true;
                        sectorTb.Enabled = true;
                    }
                    sectorTb.Click += this.HandleBlockSector;
                    PanelTBS.Controls.Add(sectorTb);
                }
                tramopspoor = false;
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
            foreach (Tram tram in TramManager.Trams)
            {
                if (tram.nummer == TramNr)
                {
                    Sector sectorCheck = RemiseManager.sectorViaTram(tram);
                    if (sectorCheck != null)
                    {
                        sectorCheck.ClearSector();
                        DatabaseManager.registreerSectorStatus(sectorCheck);
                        MessageBox.Show("Tram is succesvol verwijderd");
                        RefreshSporen();
                    }
                    else
                    {
                        MessageBox.Show("Tram staat niet op een sector!");
                    }
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
        /// Start de simulatie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            Simulatie();
        }
        /// <summary>
        /// Simulatie, simuleert het binnenkomen van de trams. De trams worden ingedeeld naar de sporen/sectoren.
        /// </summary>
        public void Simulatie()
        {
            TramIndeling indeling = new TramIndeling();
            List<Tram> tramList = TramManager.Trams;
            foreach (Tram t in tramList)
            {
                    List<Sector> ingedeeldeSectors = indeling.DeelTramIn(t);
                if (ingedeeldeSectors == null)
                {
                    System.Console.WriteLine("Niet ingedeeld: " + t.Id);
                }
                else
                {
                    Control.ControlCollection controls = PanelTBS.Controls;
                    foreach (Control c in controls)
                    {
                        foreach (Sector s in ingedeeldeSectors)
                        {
                            if ((String)c.Tag == Convert.ToString(s.Id) + "_" + Convert.ToString(s.SpoorNummer) + "-" + Convert.ToString(s.Nummer))
                            {
                                c.Text = t.nummer.ToString();
                                Refresh();
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Handler als er op een textbox geklikt wordt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleBlockSector(object sender, EventArgs e)
        {
            this.OnBlockSector(sender,EventArgs.Empty);
        }
        /// <summary>
        /// Functie om spoor te blokkeren. Past ook de textboxes aan zodat ze disabled zijn.
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
            BlokkeerSporen((TextBox)sender);
        }

        private void BlokkeerSporen(TextBox clickedTextBox)
        {
            //TextBox clickedTextBox = (TextBox)sender;
            string tag = clickedTextBox.Tag.ToString();
            //MessageBox.Show("Sector id: " + tag);
            List<Sector> sectorList = new List<Sector>();
            sectorList = RemiseManager.Sectors;
            int aantal = 99;
            string sAantal = tag.Substring(tag.IndexOf("-") + 1);
            string spId = tag.Substring(tag.IndexOf("_") + 1, tag.IndexOf("-") - tag.IndexOf("_") - 1);
            string secId = tag.Substring(0, tag.IndexOf("-") + 1);
            Int32.TryParse(sAantal, out aantal);
            //id_spoornummer-aantal
            if (clickedTextBox.Text == string.Empty)
            {
                foreach (Sector s in sectorList)
                {
                    if (s.SpoorNummer.ToString() == spId && s.Nummer >= aantal)
                    {
                        s.Blokkeer();
                        foreach (Control c in PanelTBS.Controls)
                        {
                            if (c.Tag != null)
                            {
                                if (c.Tag.ToString() ==
                                    Convert.ToString(s.Id) + "_" + Convert.ToString(s.SpoorNummer) + "-" +
                                    Convert.ToString(s.Nummer))
                                {
                                    c.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Kan sector niet blokkeren als er een tram op staat.");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Spoor sp = new Spoor(15,null,34,0,false,false,null);
            refreshEenSpoor(sp);
            // Mogelijk?
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshSporen();
        }

        private void reparatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tramInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TramInfo traminfo=new TramInfo();
            traminfo.Show();
        }

        private void spoorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpoorInfo spoorinfo = new SpoorInfo();
            spoorinfo.Show();
        }

        private void onderhoudlijstenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnderhoudLijsten o = new OnderhoudLijsten();
            o.Show();
        }

        private void FunctiesPerGebruiker(string gebruiker)
        {
            if (gebruiker == "Beheerder")
            {
                PanelTBS.Enabled = true;
                PanelTBS.Visible = true;
                foreach (Control c in gbBediening.Controls)
                {
                    c.Enabled = true;
                    c.Visible = true;
                    if (c.Name == "gbSimulatie")
                    {
                        foreach (Control con in c.Controls)
                        {
                            con.Enabled = true;
                            con.Visible = true;
                        }
                    }
                }
                foreach (ToolStripItem i in this.menuStrip1.Items)
                {
                     i.Enabled = true;
                     i.Visible = true;
                }
            }
            else if (gebruiker == "Wagenparkbeheerder")
            {
                PanelTBS.Enabled = true;
                PanelTBS.Visible = true;
                foreach (Control c in gbBediening.Controls)
                {
                    c.Enabled = true;
                    c.Visible = true;
                    if (c.Name == "gbSimulatie")
                    {
                        foreach (Control con in c.Controls)
                        {
                            con.Enabled = true;
                            con.Visible = true;
                        }
                    }
                }
                foreach (ToolStripItem i in this.menuStrip1.Items)
                {
                    if (i.Text != "Tram" && i.Text != "Gebruiker" && i.Text != "Spoor")
                    {
                        i.Enabled = false;
                        i.Visible = false;
                    }
                }
            }
            else if (gebruiker == "Bestuurder")
            {
                PanelTBS.Enabled = false;
                //PanelTBS.Visible = false;
                foreach (Control c in gbBediening.Controls)
                {
                    if (c.Name == "gbSimulatie")
                    {
                        foreach (Control con in c.Controls)
                        {
                            if (con.Name != "btnReset")
                            {
                                con.Enabled = false;
                                con.Visible = false;
                            }
                        }
                    }
                    else
                    {
                        c.Enabled = false;
                        c.Visible = false;
                    }
                }
                foreach (ToolStripItem i in this.menuStrip1.Items)
                {
                    if (i.Text != "Tram" && i.Text != "Gebruiker" && i.Text != "Onderhoud")
                    {
                        i.Enabled = false;
                        i.Visible = false;
                    }
                    else
                    {
                        i.Enabled = true;
                        i.Visible = true;
                    }
                }
            }
            else if (gebruiker == "Schoonmaker")
            {
                PanelTBS.Enabled = false;
                //PanelTBS.Visible = false;
                foreach (Control c in gbBediening.Controls)
                {
                    if (c.Name == "gbSimulatie")
                    {
                        foreach (Control con in c.Controls)
                        {
                            if (con.Name != "btnReset")
                            {
                                con.Enabled = false;
                                con.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        c.Enabled = false;
                        c.Visible = false;
                    }
                }
                foreach (ToolStripItem i in this.menuStrip1.Items)
                {
                    if ( i.Text != "Gebruiker" && i.Text != "Onderhoudlijsten")
                    {
                        i.Enabled = false;
                        i.Visible = false;
                    }
                    else
                    {
                        i.Enabled = true;
                        i.Visible = true;
                    }
                }
            }
            else if (gebruiker == "Technicus")
            {
                PanelTBS.Enabled = false;
                //PanelTBS.Visible = false;
                foreach (Control c in gbBediening.Controls)
                {
                    if (c.Name == "gbSimulatie")
                    {
                        foreach (Control con in c.Controls)
                        {
                            if (con.Name != "btnReset")
                            {
                                con.Enabled = false;
                                con.Visible = false;
                            }
                        }
                    }
                    else
                    {
                        c.Enabled = false;
                        c.Visible = false;
                    }
                }
                foreach (ToolStripItem i in this.menuStrip1.Items)
                {
                    if (i.Text != "Gebruiker" && i.Text != "Onderhoudlijsten")
                    {
                        i.Enabled = false;
                        i.Visible = false;
                    }
                    else
                    {
                        i.Enabled = true;
                        i.Visible = true;
                    }
                    Console.WriteLine(i.Text);
                }
            }
        }

        private void gebruikerToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string functie = e.ClickedItem.Text;
            FunctiesPerGebruiker(functie);
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            VoegTramToe vTt = new VoegTramToe("2001");
            vTt.Show();
        }

    }
}
