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

        private void button3_Click(object sender, EventArgs e)
        {
            if (StatusCb.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een status");
                return;
            }

            string NR_string = TramnummerTbox.Text;
            string Status = StatusCb.Text;
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
            //     if (t.ID == ID)
            //    {
            //        MessageBox.Show("Tram-nummer bestaat al, probeer een ander nummer");
            //        return;
            //    }
            //}

            //   Tram tram = new Tram()
            // db.VoegTramToe(tram);
            MessageBox.Show("Tram is toegevoegd");
            this.Close();


        }

        private void Voeg_Tram_toe_Load(object sender, EventArgs e)
        {

        }
    }
}
