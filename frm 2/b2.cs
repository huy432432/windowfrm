using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day2
{
    public partial class b2 : Form
    {
        public b2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rad_VietNam_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.VietNam;
        }

        private void rad_Italian_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Italy;
        }

        private void rad_USA_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.USA;
        }

        private void rad_Philippine_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = Properties.Resources.Philippine;
        }
    }
}
