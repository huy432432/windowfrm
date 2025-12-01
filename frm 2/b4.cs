using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT4
{
    public partial class b4 : Form
    {
        public b4()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string ngaySinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string lop = cboLop.SelectedItem.ToString();

            ListViewItem newItem = new ListViewItem(new string[] {maSV,hoTen,diaChi,ngaySinh,lop});

            lvTTSV.Items.Add(newItem);
            newItem.ImageIndex = 0;

            txtHoTen.Clear();
            txtMaSV.Clear();
            txtDiaChi.Clear();
            cboLop.Items.Clear();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvTTSV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTTSV.SelectedItems[0];

                selectedItem.SubItems[0].Text = txtMaSV.Text;  
                selectedItem.SubItems[1].Text = txtHoTen.Text; 
                selectedItem.SubItems[2].Text = txtDiaChi.Text; 
                selectedItem.SubItems[3].Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");   
                selectedItem.SubItems[4].Text = cboLop.SelectedItem.ToString();   
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để cập nhật!", "Cảnh báo");
            }
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            if (lvTTSV.SelectedItems.Count > 0)
            {
                lvTTSV.Items.Remove(lvTTSV.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Cảnh báo");
            }
        }

        private void lvTTSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTTSV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTTSV.SelectedItems[0];

                txtMaSV.Text = selectedItem.SubItems[0].Text;
                txtHoTen.Text = selectedItem.SubItems[1].Text;
                txtDiaChi.Text = selectedItem.SubItems[2].Text;
                dateTimePicker1.Value = DateTime.ParseExact(selectedItem.SubItems[3].Text, "dd/MM/yyyy", null);
                cboLop.SelectedItem = selectedItem.SubItems[4].Text;
            }
        }
    }
}
