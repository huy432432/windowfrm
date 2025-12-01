using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboKhuVuc.SelectedIndex)
            {
                case 0: //KV1
                    txtDinhMuc.Text = "50";
                    break;
                case 1: //KV2
                    txtDinhMuc.Text = "100";
                    break;
                case 2: //KV3
                    txtDinhMuc.Text = "150";
                    break;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                string hoTen = txtHoTen.Text.Trim();
                string soCuText = txtSoCu.Text.Trim();
                string soMoiText = txtSoMoi.Text.Trim();

                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soCuText) || string.IsNullOrEmpty(soMoiText))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                int soCu = int.Parse(soCuText);
                int soMoi = int.Parse(soMoiText);
                int dinhMuc = int.Parse(txtDinhMuc.Text);
                int tieuThu = soMoi - soCu;
                txtTieuThu.Text = tieuThu.ToString();

                int thanhTien = 0;
                if (tieuThu <= dinhMuc)
                {
                    thanhTien = tieuThu * 500; //Đơn giá trong định mức
                }
                else
                {
                    thanhTien = (dinhMuc * 500) + ((tieuThu - dinhMuc) * 1000); //Đơn giá ngoài định mức
                }

                txtThanhTien.Text = thanhTien.ToString();

                //Thêm vào ListView
                ListViewItem item = new ListViewItem(hoTen);
                item.SubItems.Add(cboKhuVuc.SelectedItem.ToString());
                item.SubItems.Add(dinhMuc.ToString());
                item.SubItems.Add(tieuThu.ToString());
                item.SubItems.Add(thanhTien.ToString());
                listView1.Items.Add(item);

                double tongTien = double.Parse(txtTongTien.Text);
                tongTien += thanhTien;
                txtTongTien.Text = tongTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSoCu.Clear();
            txtSoMoi.Clear();
            txtTieuThu.Clear();
            txtThanhTien.Clear();
            txtDinhMuc.Clear();
            cboKhuVuc.SelectedIndex = -1;
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var x = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    int thanhTienXoa = int.Parse(listView1.SelectedItems[0].SubItems[4].Text);
                    double tongTien = double.Parse(txtTongTien.Text);
                    tongTien -= thanhTienXoa;
                    txtTongTien.Text = tongTien.ToString();

                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
