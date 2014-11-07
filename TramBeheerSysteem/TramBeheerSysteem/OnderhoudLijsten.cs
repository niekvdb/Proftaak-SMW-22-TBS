using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TramBeheerSysteem
{
    public partial class OnderhoudLijsten : Form
    {
        private List<Tramonderhoud> Schoonmaken = new List<Tramonderhoud>();
        private List<Tramonderhoud> Reparaties = new List<Tramonderhoud>(); 

        public OnderhoudLijsten(string gebruiker)
        {
            InitializeComponent();
            if (gebruiker == "Beheerder")
            {
                foreach (Tramonderhoud onderhoud in TramManager.onderhoudsBeurten)
                {
                    if (onderhoud.TypeOnderhoud == TypeOnderhoud.GroteSchoonmaak ||
                        onderhoud.TypeOnderhoud == TypeOnderhoud.KleineSchoonmaak)
                    {
                        Schoonmaken.Add(onderhoud);
                        cbSchoonmaak.Items.Add(onderhoud.ToString());
                }
                    else if (onderhoud.TypeOnderhoud == TypeOnderhoud.GroteReparatie ||
                             onderhoud.TypeOnderhoud == TypeOnderhoud.KleineReparatie)
                    {
                        Reparaties.Add(onderhoud);
                        cbReparatie.Items.Add(onderhoud.ToString());
                    }
                }
            }
            else if (gebruiker == "Schoonmaker")
            {
                tabReparatie.Visible = false;
                tabReparatie.Enabled = false;
                foreach (Tramonderhoud onderhoud in TramManager.onderhoudsBeurten)
                {
                    if (onderhoud.TypeOnderhoud == TypeOnderhoud.GroteSchoonmaak ||
                        onderhoud.TypeOnderhoud == TypeOnderhoud.KleineSchoonmaak)
                    {
                        Schoonmaken.Add(onderhoud);
                        cbSchoonmaak.Items.Add(onderhoud.ToString());
                    }
                }
            }
            else if (gebruiker == "Technicus")
            {
                tbcLijsten.SelectedTab = tabReparatie;
                tabSchoonmaak.Visible = false;
                tabSchoonmaak.Enabled = false;
                foreach (Tramonderhoud onderhoud in TramManager.onderhoudsBeurten)
                {
                     if (onderhoud.TypeOnderhoud == TypeOnderhoud.GroteReparatie ||
                             onderhoud.TypeOnderhoud == TypeOnderhoud.KleineReparatie)
                    {
                        Reparaties.Add(onderhoud);
                        cbReparatie.Items.Add(onderhoud.ToString());
                    }
                }
            }
        }


        private void cbReparatie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string onderhoudString = cbReparatie.SelectedText;
            Tramonderhoud selectedOnderhoud = TramManager.OnderhoudFromString(onderhoudString);
            tbxReparatie.Text = selectedOnderhoud.Opmerking;
            tbxReparatieSector.Text = Convert.ToString(RemiseManager.sectorViaTram(selectedOnderhoud.Tram).Nummer);
            tbxReparatieSpoor.Text = Convert.ToString(RemiseManager.sectorViaTram(selectedOnderhoud.Tram).SpoorNummer);
        }

        private void cbSchoonmaak_SelectedIndexChanged(object sender, EventArgs e)
        {
            string onderhoudString = Convert.ToString(cbSchoonmaak.SelectedItem);
            Tramonderhoud selectedOnderhoud = TramManager.OnderhoudFromString(onderhoudString);
            tbxSchoonmaak.Text = selectedOnderhoud.Opmerking;
            if (RemiseManager.sectorViaTram(selectedOnderhoud.Tram) != null)
            {
                tbxSchoonmaakSector.Text = Convert.ToString(RemiseManager.sectorViaTram(selectedOnderhoud.Tram).Nummer);
            }
            else tbxSchoonmaakSector.Text = "geen";

            if (RemiseManager.sectorViaTram(selectedOnderhoud.Tram) != null)
            {
                tbxSchoonmaakSpoor.Text =
                Convert.ToString(RemiseManager.sectorViaTram(selectedOnderhoud.Tram).SpoorNummer);
            }
            else tbxSchoonmaakSpoor.Text = "geen";
        }

        private void reloadForm()
        {
            cbReparatie.Items.Clear();
            cbSchoonmaak.Items.Clear();
            Schoonmaken.Clear();
            Reparaties.Clear();
            cbReparatie.Text = "";
            cbSchoonmaak.Text = "";
            tbxSchoonmaak.Text = "";
            tbxReparatie.Text = "";
            tbxReparatieSector.Text = "";
            tbxReparatieSpoor.Text = "";
            tbxSchoonmaakSector.Text = "";
            tbxSchoonmaakSpoor.Text = "";

            TramManager.onderhoudsBeurten = DatabaseManager.LaadTramonderhoud();

            foreach (Tramonderhoud onderhoud in TramManager.onderhoudsBeurten)
            {
                if (onderhoud.TypeOnderhoud == TypeOnderhoud.GroteSchoonmaak ||
                    onderhoud.TypeOnderhoud == TypeOnderhoud.KleineSchoonmaak)
                {
                    Schoonmaken.Add(onderhoud);
                    cbSchoonmaak.Items.Add(onderhoud.ToString());
                }
                else if (onderhoud.TypeOnderhoud == TypeOnderhoud.GroteReparatie ||
                         onderhoud.TypeOnderhoud == TypeOnderhoud.KleineReparatie)
                {
                    Reparaties.Add(onderhoud);
                    cbReparatie.Items.Add(onderhoud.ToString());
                }
            }
        }

        private void btnSchoonmaak_Click(object sender, EventArgs e)
        {
            string onderhoudString = Convert.ToString(cbSchoonmaak.SelectedItem);
            Tramonderhoud selectedOnderhoud = TramManager.OnderhoudFromString(onderhoudString);
            DatabaseManager.VoltooiOnderhoud(selectedOnderhoud);
            MessageBox.Show("Opgeslagen!");
            TramManager.onderhoudsBeurten = DatabaseManager.LaadTramonderhoud();
            reloadForm();
        }

        private void btnReparatie_Click(object sender, EventArgs e)
        {
            string onderhoudString = Convert.ToString(cbSchoonmaak.SelectedItem);
            Tramonderhoud selectedOnderhoud = TramManager.OnderhoudFromString(onderhoudString);
            DatabaseManager.VoltooiOnderhoud(selectedOnderhoud);
            MessageBox.Show("Opgeslagen!");
            TramManager.onderhoudsBeurten = DatabaseManager.LaadTramonderhoud();
            reloadForm();
        }

        private void btnRefreshReparatie_Click(object sender, EventArgs e)
        {
            reloadForm();
        }

        private void btnRefreshSchoonmaak_Click(object sender, EventArgs e)
        {
            reloadForm();
        }
    }
}
