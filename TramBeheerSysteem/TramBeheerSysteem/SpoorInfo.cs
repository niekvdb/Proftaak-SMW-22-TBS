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
    public partial class SpoorInfo : Form
    {
        public SpoorInfo()
        {
            InitializeComponent();
            foreach (Spoor spoor in RemiseManager.Sporen)
            {
                cbSporen.Items.Add(Convert.ToString(spoor.Nummer));
            }
            cbSporen.Sorted = true;
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            if (cbSporen.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst een spoor!");
                return;
            }
            foreach (Spoor spoor in RemiseManager.Sporen)
            {
                if (spoor.Nummer == Convert.ToInt32(cbSporen.Text))
                {
                    var spoor1 = new ListViewItem(new[] { Convert.ToString(spoor.Nummer), Convert.ToString(spoor.Remise), "test", Convert.ToString(spoor.Beschikbaar) });
                    lvwTrams.Items.Add(spoor1);
                }
            }
        }
    }
}
