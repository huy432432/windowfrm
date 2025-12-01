using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT5
{
    public partial class b5 : Form
    {
        public b5()
        {
            InitializeComponent();
            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("MaSV", "Mã Sinh Viên");
            dataGridView1.Columns.Add("TenSV", "Tên Sinh Viên");
            dataGridView1.Columns.Add("QueQuan", "Quê Quán");
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            string queQuan = txtQueQuan.Text;

            if (!string.IsNullOrEmpty(maSV) && !string.IsNullOrEmpty(hoTen) && !string.IsNullOrEmpty(queQuan))
            {
                dataGridView1.Rows.Add(maSV, hoTen, queQuan);

                txtMaSV.Clear();
                txtHoTen.Clear();
                txtQueQuan.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            string queQuan = txtQueQuan.Text;

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSV"].Value != null && row.Cells["MaSV"].Value.ToString() == maSV)
                {
                    row.Cells["TenSV"].Value = hoTen;
                    row.Cells["QueQuan"].Value = queQuan;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Mã sinh viên không tìm thấy trong danh sách.", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần xóa.", "Thông báo");
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSV"].Value != null && row.Cells["MaSV"].Value.ToString() == maSV)
                {
                    dataGridView1.Rows.Remove(row);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Mã sinh viên không tìm thấy trong danh sách.", "Thông báo");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;

            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần tìm.", "Thông báo");
                return;
            }

            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSV"].Value != null && row.Cells["MaSV"].Value.ToString() == maSV)
                {
                    dataGridView1.CurrentCell = row.Cells[0];
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Mã sinh viên không tìm thấy trong danh sách.", "Thông báo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtMaSV.Text = selectedRow.Cells["MaSV"].Value.ToString();
                txtHoTen.Text = selectedRow.Cells["TenSV"].Value.ToString();
                txtQueQuan.Text = selectedRow.Cells["QueQuan"].Value.ToString();
            }
        }
    }
}
