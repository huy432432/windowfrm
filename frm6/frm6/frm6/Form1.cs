using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10123308_NguyenDuyThuan_KTTH_WF
{
    public partial class frmCongNgheNET : Form
    {
        public frmCongNgheNET()
        {
            InitializeComponent();
        }
        clsDatabase db = new clsDatabase();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        private void frmCongNgheNET_Load(object sender, EventArgs e)
        {
            LoadPhiKN();            
        }
        void LoadPhiKN()
        {
            db.KetNoi();
            string query = "select * from tbSach";
            dt = db.table(query);
            dgSach.DataSource = dt;
            db.NgatKetNoi();
        }
        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                this.errorProvider1.SetError(txtSL, "Vui lòng nhập số"); 
            }
            else this.errorProvider1.Clear();
        }
        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 && dgSach.Rows[i].Cells[0].Value != null)
            {
                txtMaSach.Text = dgSach[0, i].Value.ToString();
                txtTenSach.Text = dgSach[1, i].Value.ToString();
                txtTacGia.Text = dgSach[2, i].Value.ToString();
                txtNXB.Text = dgSach[3, i].Value.ToString();
                txtSL.Text = dgSach[4, i].Value.ToString();
            } 
        }
        private void btMoi_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNXB.Clear();
            txtSL.Clear();

            txtMaSach.Focus();
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSach.Text == "")
                {
                    MessageBox.Show("vui lòng nhập mã sách!", "Thông báo");
                    return;
                }
                db.KetNoi();
                string query = "Insert into tbSach Values('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',N'" + txtTacGia.Text + "',N'" + txtNXB.Text + "','" + txtSL.Text + "')";
                cmd = new SqlCommand(query, db.conn);
                cmd.ExecuteNonQuery();

                LoadPhiKN();
                MessageBox.Show("Thêm thành công!", "Thông báo");
                db.NgatKetNoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message, "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {          
                string ma = txtMaSach.Text;
                string ten = txtTenSach.Text;
                string tacGia = txtTacGia.Text;
                string NXB = txtNXB.Text;
                string sl = txtSL.Text;

                if (ten == "" || tacGia == "" || NXB == "" || sl == "")
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }
                db.KetNoi();
                string sql = "Update tbSach Set TenSach = N'" + ten + "', TacGia = N'" + tacGia + "', " +
                             "NhaXuatBan = N'" + NXB + "', SoLuong = '" + sl + "' where MaSach = '" + ma + "'";
                cmd = new SqlCommand(sql, db.conn);
                cmd.ExecuteNonQuery();

                LoadPhiKN();
                MessageBox.Show("Sửa thành công!", "Thông báo");
                db.NgatKetNoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaSach.Text;
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    db.KetNoi();            
                    string sql = "Delete from tbSach where MaSach = '" + ma + "'";
                    cmd = new SqlCommand(sql, db.conn);
                    cmd.ExecuteNonQuery();

                    LoadPhiKN();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    db.NgatKetNoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
