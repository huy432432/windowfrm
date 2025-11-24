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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            this.txt_dangnhap.Clear(); this.txt_matkhau.Clear(); this.txt_dangnhap.Focus();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txt_dangnhap.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += this.txt_matkhau.Text;
            if (this.chk_1.Checked == true)
            {
                thongbao += "\n\rBạn có ghi nhớ.";
            }
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void btn_Dung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
