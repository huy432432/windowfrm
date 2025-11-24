using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cong_CheckedChanged(object sender, EventArgs e)
        {
            int a ,b;
           
            bool isNumberA = int.TryParse(inA.Text, out a);
            bool isNumberB = int.TryParse(inB.Text, out b);
            if (isNumberA && isNumberB)
            {
                int result = a + b;
                OUTAB.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void tru_CheckedChanged(object sender, EventArgs e)
        {
            int a, b;

            bool isNumberA = int.TryParse(inA.Text, out a);
            bool isNumberB = int.TryParse(inB.Text, out b);
            if (isNumberA && isNumberB)
            {
                int result = a - b;
                OUTAB.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nhan_CheckedChanged(object sender, EventArgs e)
        {
            int a, b;

            bool isNumberA = int.TryParse(inA.Text, out a);
            bool isNumberB = int.TryParse(inB.Text, out b);
            if (isNumberA && isNumberB)
            {
                int result = a * b;
                OUTAB.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chia_CheckedChanged(object sender, EventArgs e)
        {
            int a, b;

            bool isNumberA = int.TryParse(inA.Text, out a);
            bool isNumberB = int.TryParse(inB.Text, out b);
            if (isNumberA && isNumberB && inA.Text != "0"  && inB.Text!= "0")
            {
                int result = a / b;
                OUTAB.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào cả hai ô.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
