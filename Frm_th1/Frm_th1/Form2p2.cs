using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void inNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int a;
            bool isnumber = int.TryParse(inNhap.Text, out a);
            if (isnumber) {
                danhsach.Items.Add(a);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
            inNhap.Focus();
            inNhap.Clear();
        }

        private void btn_tong_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Tổng các số trong danh sách là: " + danhsach.Items.Count.ToString());


        }

        private void btn_rmv_start_end_Click(object sender, EventArgs e)
        {
            if (danhsach.Items.Count < 2)
            {
                MessageBox.Show("Danh sách không đủ phần tử để xóa!");

                return;
            }
            danhsach.Items.RemoveAt(0);
            danhsach.Items.RemoveAt(danhsach.Items.Count - 1);



        }

        private void btn_plus2_Click(object sender, EventArgs e)
        {
            if (danhsach.Items == null)
            {
                MessageBox.Show("ko co ds");
            }
            for (int i = 0; i < danhsach.Items.Count; i++) {
               
                danhsach.Items[i] = (int)danhsach.Items[i] + 2;
                
            
            }
        }

        private void inNhap_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inNhap.Focus();
        }

        private void btn_sqr_Click(object sender, EventArgs e)
        {
            if (danhsach.Items == null)
            {
                MessageBox.Show("ko co ds");
            }
            for (int i = 0; i < danhsach.Items.Count; i++)
            {

                danhsach.Items[i] = (int)danhsach.Items[i] * (int)danhsach.Items[i];


            }
        }

        private void btn_even_Click(object sender, EventArgs e)
        {
            for (int i =danhsach.Items.Count-1;i>=0;i--)
            {
                
                    if ((int)danhsach.Items[i] %2 !=0)
                    {
                       danhsach.Items.RemoveAt(i);
                    }
 
            }
        }

        private void btn_odd_Click(object sender, EventArgs e)
        {
            for (int i = danhsach.Items.Count - 1; i >= 0; i--)
            {

                if ((int)danhsach.Items[i] % 2 == 0)
                {
                    danhsach.Items.RemoveAt(i);
                }

            }
        }
    }
}
