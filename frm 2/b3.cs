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
    public partial class b3 : Form
    {
        public b3()
        {
            InitializeComponent();
        }

        private void largerIconToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem(textBox1.Text);
            it.SubItems.Add(textBox2.Text); 
            it.SubItems.Add(textBox3.Text); 
            listView1.Items.Add(it);

        }
    }
}
