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
using Phidgets;
using Phidgets.Events;

namespace TramBeheerSysteem
{
    
    
    public partial class TramBeheerSysteem : Form
    {
        Dictionary<string, int> rfidTramDictionary = new Dictionary<string, int>()
	    {
	        {"28002b2dd4", 2045},
	        {"2800366f27", 909},
	        {"2800c1b4bf", 2204}
	    };
        public event EventHandler BlockSector;
        private List<Sector> simulatieSectors = new List<Sector>(); 
        int xPosTb = 5;
        int yPosTb = 5;
        int horizontalRows = 1;
        int verticalRows = 1;
        private int maxSectors = 0;
        private bool tramopspoor = false;

        private RFID rfid;

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

            laadRFID();
        }

        public void laadRFID()
        {
            lblTagInfo.Text = "";
            lblScannerInfo.Text = "Phidget RFID not connected";

            rfid = new RFID();

            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.Detach += new DetachEventHandler(rfid_Detach);

            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);

            openCmdLine(rfid);
        }

        #region Command line open functions
        private void openCmdLine(Phidget p)
        {
            openCmdLine(p, null);
        }
        private void openCmdLine(Phidget p, String pass)
        {
            int serial = -1;
            String logFile = null;
            int port = 5001;
            String host = null;
            bool remote = false, remoteIP = false;
            string[] args = Environment.GetCommandLineArgs();
            String appName = args[0];

            try
            { //Parse the flags
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                        switch (args[i].Remove(0, 1).ToLower())
                        {
                            case "l":
                                logFile = (args[++i]);
                                break;
                            case "n":
                                serial = int.Parse(args[++i]);
                                break;
                            case "r":
                                remote = true;
                                break;
                            case "s":
                                remote = true;
                                host = args[++i];
                                break;
                            case "p":
                                pass = args[++i];
                                break;
                            case "i":
                                remoteIP = true;
                                host = args[++i];
                                if (host.Contains(":"))
                                {
                                    port = int.Parse(host.Split(':')[1]);
                                    host = host.Split(':')[0];
                                }
                                break;
                            default:
                                goto usage;
                        }
                    else
                        goto usage;
                }
                if (logFile != null)
                    Phidget.enableLogging(Phidget.LogLevel.PHIDGET_LOG_INFO, logFile);
                if (remoteIP)
                    p.open(serial, host, port, pass);
                else if (remote)
                    p.open(serial, host, pass);
                else
                    p.open(serial);
                return; //success
            }
            catch { }
        usage:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invalid Command line arguments." + Environment.NewLine);
            sb.AppendLine("Usage: " + appName + " [Flags...]");
            sb.AppendLine("Flags:\t-n   serialNumber\tSerial Number, omit for any serial");
            sb.AppendLine("\t-l   logFile\tEnable phidget21 logging to logFile.");
            sb.AppendLine("\t-r\t\tOpen remotely");
            sb.AppendLine("\t-s   serverID\tServer ID, omit for any server");
            sb.AppendLine("\t-i   ipAddress:port\tIp Address and Port. Port is optional, defaults to 5001");
            sb.AppendLine("\t-p   password\tPassword, omit for no password" + Environment.NewLine);
            sb.AppendLine("Examples: ");
            sb.AppendLine(appName + " -n 50098");
            sb.AppendLine(appName + " -r");
            sb.AppendLine(appName + " -s myphidgetserver");
            sb.AppendLine(appName + " -n 45670 -i 127.0.0.1:5001 -p paswrd");
            MessageBox.Show(sb.ToString(), "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }
        #endregion

        #region RFID Methods
        void rfid_Tag(object sender, TagEventArgs e)
        {
            TramIndeling indeling = new TramIndeling();
            List<Sector> toegewezenSectors = new List<Sector>();
            Tram tram;
            Spoor spoor;
            Sector sector;            
            int tramId;
            

            lblTagInfo.Text = e.Tag;
            rfid.LED = true;

            tramId = rfidTramDictionary[e.Tag];
            tram = TramManager.tramViaNummer(tramId);
            sector = RemiseManager.sectorViaTram(tram);

            if (sector != null)
            {
                sector.ClearSector();
                refreshEenSpoor(RemiseManager.spoorViaId(sector.SpoorNummer));
                DatabaseManager.registreerSectorStatus(sector);
            }

            else
            {
                toegewezenSectors = indeling.DeelTramIn(tram);
                spoor = RemiseManager.spoorViaId(toegewezenSectors[0].SpoorNummer);
                refreshEenSpoor(spoor);

                foreach (Sector toegewezenSector in toegewezenSectors)
                {
                    DatabaseManager.registreerSectorStatus(toegewezenSector);
                }
            }
        }

        void rfid_TagLost(object sender, TagEventArgs e)
        {
            lblTagInfo.Text = "";
            rfid.LED = false;
        }
        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;

            lblScannerInfo.Text = "Phidget RFID Connected ("+attached.SerialNumber+")";

            if (rfid.outputs.Count > 0)
            {
                rfid.Antenna = true;
            }
        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;

            lblTagInfo.Text = "";
            lblScannerInfo.Text = "Phidget RFID not connected";
        }
        #endregion

        /// <summary>
        /// methode om de interface te refreshen.
        /// </summary>
        private void RefreshSporen()
        {
            if (PanelTBS.Controls.Count == 0)
            {
                xPosTb = 5;
                yPosTb = 5;
                horizontalRows = 1;
                verticalRows = 1;
                maxSectors = 0;
                AddTextBoxes(RemiseManager.Sporen);
            }

            else
            {
                foreach (Sector simulatieSector in simulatieSectors)
                {
                    simulatieSector.ClearSector();
                }

                foreach (Spoor spoor in RemiseManager.Sporen)
                {
                    refreshEenSpoor(spoor);
                }

                simulatieSectors.Clear();
            }
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
                    if ((sector.Blokkade || tramopSpoor) && sector.Tram == null) sectortb.Enabled = false;
                    else sectortb.Enabled = true;
                    if (sector.Tram != null)
                    {
                        sectortb.Text = sector.Tram.nummer.ToString();
                        tramopSpoor = true;
                    }
                    else sectortb.Text = "";
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
            VoegTramToe v = new VoegTramToe(this);
            v.Show();         
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            bool tramgevonden = false;
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
                    foreach (Sector s in RemiseManager.Sectors)
                    {
                        Sector sectorCheck = RemiseManager.sectorViaTram(tram);
                        if (sectorCheck != null)
                        {
                            sectorCheck.ClearSector();
                            refreshEenSpoor(RemiseManager.spoorViaId(sectorCheck.SpoorNummer));
                            tramgevonden = true;
                            DatabaseManager.registreerSectorStatus(sectorCheck);

                        }
                    }
                }
            }

            if (tramgevonden) MessageBox.Show("Tram is succesvol verwijderd");
            else MessageBox.Show("Tram staat niet op een sector!");
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
            SpoorBediening s = new SpoorBediening(this);
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
                
                if (ingedeeldeSectors == null) Console.WriteLine("Niet ingedeeld: " + t.Id);
                else
                {
                    simulatieSectors.AddRange(ingedeeldeSectors);
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshSporen();
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
            OnderhoudLijsten o = new OnderhoudLijsten(lblGebruiker.Text);
            o.Show();
        }

        private void FunctiesPerGebruiker(string gebruiker)
        {
            if (gebruiker == "Beheerder")
            {
                lblGebruiker.Text = "Beheerder";
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
                lblGebruiker.Text = "Wagenparkbeheerder";
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
                lblGebruiker.Text = "Bestuurder";
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
                lblGebruiker.Text = "Schoonmaker";
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
                lblGebruiker.Text = "Technicus";
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
    }
}
