using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class frmQuanLyNhanVien : Form
    {
        ClsCSDL dataHelper = new ClsCSDL();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr = null;
        string connectionString = "Server=LAPTOP-899I2AVH\\SQLEXPRESS;Database=QuanLyThuVien;Integrated Security=True";
        public frmQuanLyNhanVien()
        {
            InitializeComponent();           
        }
        private void frmQuanLyNhanVien_Load_1(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        public void LoadNhanVien()
        {            
            //Khởi tạo kn
            dataHelper.KetNoi(connectionString);

            string query = "SELECT MaNhanVien, HoTen, DiaChi, TenDangNhap,MatKhau, QuyenHan FROM NhanVien";
            DataTable dtNhanVien = dataHelper.FillDataTable(query);
            dgvNhanVien.DataSource = dtNhanVien;
            if (dgvNhanVien.Columns.Contains("MatKhau"))
            {
                dgvNhanVien.Columns["MatKhau"].Visible = false;
            }
            dataHelper.CloseConnection();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.Rows[e.RowIndex];

                txtMa.Text = selectedRow.Cells[0].Value.ToString();
                txtTen.Text = selectedRow.Cells[1].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells[2].Value.ToString();
                txtTenDangNhap.Text = selectedRow.Cells[3].Value.ToString();
                cboQuyen.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" ||txtTenDangNhap.Text == "" || cboQuyen.Text == "")   
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            DataTable dtNhanVien = (DataTable)dgvNhanVien.DataSource;

            object[] newRecord = { txtMa.Text, txtTen.Text, txtDiaChi.Text, txtTenDangNhap.Text, cboQuyen.Text };
            dataHelper.UpdateTable(dtNhanVien, newRecord);
            dataHelper.UpdateTableToDataBase(dtNhanVien, "NhanVien");

            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
            LoadNhanVien();
        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtTenDangNhap.Text == "" || cboQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            DataTable dtNhanVien = (DataTable)dgvNhanVien.DataSource;

            object[] updatedRecord = { txtMa.Text, txtTen.Text, txtDiaChi.Text, txtTenDangNhap.Text, cboQuyen.Text };
            dataHelper.UpdateTable(dtNhanVien, updatedRecord);
            dataHelper.UpdateTableToDataBase(dtNhanVien, "NhanVien");

            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
            LoadNhanVien();
        }
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để xóa!", "Thông báo");
                return;
            }

            DataTable dtNhanVien = (DataTable)dgvNhanVien.DataSource;
            dataHelper.DeleteTable(dtNhanVien, txtMa.Text);
            dataHelper.UpdateTableToDataBase(dtNhanVien, "NhanVien");

            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
            LoadNhanVien();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Thông báo");
                return;
            }

            DataTable dtNhanVien = (DataTable)dgvNhanVien.DataSource;
            int rowIndex = dataHelper.LocDuLieu(dtNhanVien, $"MaNhanVien = '{txtMa.Text}'");

            if (rowIndex >= 0)
            {
                dgvNhanVien.ClearSelection();
                dgvNhanVien.Rows[rowIndex].Selected = true;
                dgvNhanVien.CurrentCell = dgvNhanVien.Rows[rowIndex].Cells[0];
            }
            else
            {
                MessageBox.Show($"Không tìm thấy nhân viên với mã: {txtMa.Text}", "Thông báo");
            }
        }

    }
}
