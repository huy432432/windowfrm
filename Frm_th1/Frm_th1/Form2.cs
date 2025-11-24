using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_th1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_ketqua_Click(object sender, EventArgs e)
        {
            string hoten = this.textBox1.Text.Trim();
            if (this.rad_chuthuong.Checked == true)
                textBox2.Text = hoten.ToLower();
            if (this.rad_chuhoa.Checked == true)
                textBox2.Text = hoten.ToUpper();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.rad_chuthuong.Checked = true;
            this.textBox1.Focus();
        }
    }
}
