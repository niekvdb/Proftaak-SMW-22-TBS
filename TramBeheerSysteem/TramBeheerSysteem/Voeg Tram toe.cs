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
    public partial class Voeg_Tram_toe : Form
    {
        public Voeg_Tram_toe()
        {
            InitializeComponent();
        }
         public Voeg_Tram_toe(int KnopNummer)
        {
            InitializeComponent();
             if (KnopNummer == 1)
             {
                 Button wijzig = this.Controls.Find("btnVoegToe",true).FirstOrDefault()as Button;
                 wijzig.Text = "Wijzig Status";
                 this.Text = "Wijzig Status";
                 wijzig.Click += new EventHandler(this.wijzig_onclick);
             }
             if (KnopNummer == 0)
             {
                 Button voegtoe = this.Controls.Find("btnVoegToe", true).FirstOrDefault() as Button;
                 voegtoe.Text = "Voeg Toe";
                 this.Text = "Voeg Toe";
                 voegtoe.Click+=new EventHandler(this.voegtoe_onclick);
             }
        }

         private void voegtoe_onclick(object sender, EventArgs e)
         {
             if (cbStatus.SelectedItem == null)
             {
                 MessageBox.Show("Selecteer een status");
                 return;
             }

             string NR_string = tbTramnummer.Text;
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

             // foreach (Tram t in db.HaalTramsOp)
             //  {
             //     if (t.nummer == NR)
             //    {
             //        MessageBox.Show("Tram-nummer bestaat al, probeer een ander nummer");
             //        return;
             //    }
             //}

             //   Tram tram = new Tram()
             // DatabaseManager.VoegTramToe(tram);
             MessageBox.Show("Tram is toegevoegd");
             this.Close();
         }

         private void wijzig_onclick(object sender, EventArgs e)
         {
             if (cbStatus.SelectedItem == null)
             {
                 MessageBox.Show("Selecteer een status");
                 return;
             }
             string NR_string = tbTramnummer.Text;
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
             // foreach (Tram t in db.HaalTramsOp)
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


        private void button3_Click(object sender, EventArgs e)
        {
         


        }

        private void Voeg_Tram_toe_Load(object sender, EventArgs e)
        {

        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {

        }
    }
}
