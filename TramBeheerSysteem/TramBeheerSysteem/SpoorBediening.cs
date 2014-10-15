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
    public partial class SpoorBediening : Form
    {
        public SpoorBediening()
        {
            InitializeComponent();
            //foreach(spoor s in Database.HaalSporenOp())
            //cbSpoor.Items.Add(s.nummer);
        }

        private void btnSpoorstatus_Click(object sender, EventArgs e)
        {
            string SpoorNR_string = cbSpoor.Text;
            string SectorNR_string = cbSector.Text;
            int SectorNR;
            int SpoorNR;
            try
            {
                SpoorNR = Convert.ToInt32(SpoorNR_string);
            }
            catch
            {
                MessageBox.Show("Voer een spoornummer in");
                return;
            }
            try
            {
                SectorNR = Convert.ToInt32(SectorNR_string);
            }
            catch
            {
                MessageBox.Show("Voer een sectornummer in");
                return;
            }
            // foreach (Sector s in DatabaseManager.HaalSectorenOp(SpoorNR))
            //  {
            //     if (s.nummer == SectorNR && s.blokkade ==true)
            //    {
            //        MessageBox.Show("Sector is vrijgemaakt");
            //        s.blokkade==false;      
            //      foreach (Sector sec in DatabaseManager.HaalSectorenOp(SpoorNR))
            //      {
            //          if(sec.nummer>SectorNR)
            //          {
            //              sec.blokkade=false;
            //          }
            //      }
            //    }
            //      else
            //    {
            //      MessageBox.Show("Sector is Geblokkeerd");
            //      s.blokkade==true;
            //      foreach (Sector sec in DatabaseManager.HaalSectorenOp(SpoorNR))
            //      {
            //          if(sec.nummer>SectorNR)
            //          {
            //              sec.blokkeer();
            //          }
            //      }
            //     }
            //}
            // DatabaseManager.UpdateSpoorStatus(NR);
        }

        private void SpoorBediening_Load(object sender, EventArgs e)
        {

        }

        private void cbSpoor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SpoorNummer = Convert.ToInt32(cbSpoor.Text);
            //foreach(sector sec in Database.HaalSectorenOp(SpoorNummer))
            //cbSector.Items.Add(sec.nummer);
        }
    }
}
