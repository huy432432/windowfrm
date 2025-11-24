using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach ( var item in dssouoc.Items)
            {
                tong += int.Parse(item.ToString());
            }
            MessageBox.Show("Tổng các ước số là: " + tong, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           txtso.Focus();
            this.AcceptButton = btncapnhap;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dssouoc.Items.Clear();

            if (comboBox1.SelectedItem == null)
            {
                return;
            }
            //
            int n = int.Parse(comboBox1.SelectedItem.ToString());
            for (int i = 1; i <= n ; i++)
            {
                if (n % i == 0)
                {
                    dssouoc.Items.Add(i);
                }

            }
            ;
        }
        private void btncapnhap_Click(object sender, EventArgs e)
        {
            int n;
            bool isNumber = int.TryParse(txtso.Text, out n);
            if (isNumber == false) {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtso.Clear();
                txtso.Focus();
                return;

            }
            comboBox1.Items.Add(n);

            txtso.Clear();
            txtso.Focus();

        }

        private void btnslchan_Click(object sender, EventArgs e)
        {
            int sl = 0;
            foreach (var item in dssouoc.Items)
            {
                if (int.Parse(item.ToString()) % 2 == 0)
                    sl += 1;
            }
            MessageBox.Show("Tổng số lượng ước số chẵn là: " + sl   , "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private void btnbutton4_Click(object sender, EventArgs e)
        {
            int sl = 0;
            foreach( int item in dssouoc.Items)
            {
                if (KiemTraNguyenTo(item))
                {
                    sl += 1;
                }
            }
            MessageBox.Show("Tổng số lượng ước số nguyên tố: " + sl, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
