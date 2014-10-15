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
    public partial class TramBeheerSysteem : Form
    {
        public TramBeheerSysteem()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void schoonmaakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchoonMaakLijst s = new SchoonMaakLijst();
            s.Show();
        }

        private void voegToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voeg_Tram_toe v = new Voeg_Tram_toe();
            v.Show();
            
        }

        private void verwijderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voeg_Tram_toe v = new Voeg_Tram_toe();
            v.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
