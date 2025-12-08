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
        DataHelper dataHelper = new DataHelper();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = null;
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
            try
            {           
                //tạo kn
                dataHelper.InitializeConnection(connectionString);
                string query = "SELECT MaNhanVien, HoTen, DiaChi, TenDangNhap, QuyenHan FROM NhanVien";
                SqlDataReader dr = dataHelper.ExecuteReader(query);
                dgvNhanVien.Rows.Clear();
                while (dr.Read())
                {
                    dgvNhanVien.Rows.Add(
                        dr["MaNhanVien"].ToString(),
                        dr["HoTen"].ToString(),
                        dr["DiaChi"].ToString(),
                        dr["TenDangNhap"].ToString(),
                        dr["QuyenHan"].ToString()
                    );
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu nhân viên: {ex.Message}", "Lỗi");
            }
            dataHelper.CloseConnection();
        }


        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            string st = "insert into NhanVien values('" + txtMa.Text + "','" + txtTen.Text +"','" + txtDiaChi.Text + "','" + txtTenDangNhap.Text + "','123','" + cboQuyen.Text + "')";
            int kq = dataHelper.ExecuteNonQuery(st);

            if (kq > 0) 
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");

                dgvNhanVien.Rows.Add(txtMa.Text,txtTen.Text,txtDiaChi.Text,txtTenDangNhap.Text,cboQuyen.Text);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
            }
        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text == "" || txtTen.Text == "" || txtDiaChi.Text == "" || txtTenDangNhap.Text == "" || cboQuyen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                string storedProcedure = "sp_UpdateNhanVien";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaNhanVien", txtMa.Text),
                    new SqlParameter("@HoTen", txtTen.Text),
                    new SqlParameter("@DiaChi", txtDiaChi.Text),
                    new SqlParameter("@TenDangNhap", txtTenDangNhap.Text),
                    new SqlParameter("@QuyenHan", cboQuyen.Text)
                };

                int kq1 = dataHelper.StoreNonQuery(storedProcedure, parameters);
                if (kq1 > 0)
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo");
                    LoadNhanVien();
                }
                else MessageBox.Show("Không tìm thấy mã nhân viên cần sửa!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa thông tin nhân viên: {ex.Message}", "Lỗi");
            }
            dataHelper.CloseConnection();
        }
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMa.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên để xóa!", "Thông báo");
                    return;
                }
                DialogResult ok = MessageBox.Show( "Bạn có chắc muốn xóa nhân viên không?", "Xác nhận xóa", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (ok == DialogResult.Yes)
                {
                    string query = $"delete from NhanVien where MaNhanVien = '{txtMa.Text.Trim()}'";
                    int result = dataHelper.ExecuteNonQuery(query);
                    if (result > 0) 
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                        LoadNhanVien();
                    }
                    else MessageBox.Show("Không tìm thấy mã nhân viên cần xóa!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi");
            }
            finally
            {
                dataHelper.CloseConnection();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.Rows[e.RowIndex];

                txtMa.Text = selectedRow.Cells[0].Value?.ToString();
                txtTen.Text = selectedRow.Cells[1].Value?.ToString();
                txtDiaChi.Text = selectedRow.Cells[2].Value?.ToString();
                txtTenDangNhap.Text = selectedRow.Cells[3].Value?.ToString();
                cboQuyen.Text = selectedRow.Cells[4].Value?.ToString();
            }
        }       
    }
}
