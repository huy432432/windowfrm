using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT6
{
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }

        private void frmTreeView_Load(object sender, EventArgs e)
        {
            for (int i = 65; i <= 90; i++)
            {
                string kt = ((char)i).ToString();
                tvDSTen.Nodes.Add(kt, kt);
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            String key = txtFirstName.Text.Trim()[0].ToString();
            tvDSTen.Nodes[key].Nodes.Add(txtFirstName.Text + "," + txtLastName.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
