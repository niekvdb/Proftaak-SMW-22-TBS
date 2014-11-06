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
    public partial class OnderhoudLijsten : Form
    {
        private List<Tramonderhoud> Schoonmaken = new List<Tramonderhoud>();
        private List<Tramonderhoud> Reparaties = new List<Tramonderhoud>();

        public OnderhoudLijsten()
        {
            InitializeComponent();

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
            else tbxSchoonmaakSector.Text = "--";

            if (RemiseManager.sectorViaTram(selectedOnderhoud.Tram) != null)
            {
                tbxSchoonmaakSpoor.Text =
                    Convert.ToString(RemiseManager.sectorViaTram(selectedOnderhoud.Tram).SpoorNummer);
            }
            else tbxSchoonmaakSpoor.Text = "--";
        }

        private void btnSchoonmaak_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void btnReparatie_Click(object sender, EventArgs e)
        {
            //todo
        }
    }
}
