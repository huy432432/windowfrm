using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }
        KetNoiDuLieu kn = new KetNoiDuLieu();
        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            kn.myconnect();
            string sql = "SELECT * FROM MonHoc";
            cboMaMH.DataSource = kn.taobang(sql);
            cboMaMH.DisplayMember = "MaMH";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            kn.myclose();
        }

        private void cboMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaMH.SelectedIndex != -1)
            {
                string s = "SELECT * FROM MonHoc WHERE MaMH = '" + cboMaMH.Text + "'";
                DataTable d = kn.taobang(s);
                foreach (DataRow hang in d.Rows)
                {
                    txtTenMH.Text = hang["TenMH"].ToString();
                    txtSoTiet.Text = hang["SoTiet"].ToString();
                }

                string s2 = "SELECT sv.MaSV, HoSV, TenSV, NgaySinh, Diem " +
                            "FROM SinhVien sv INNER JOIN KetQua kq ON sv.MaSV = kq.MaSV " +
                            "WHERE kq.MaMH = '" + cboMaMH.Text + "'";
                dgvQLSP.DataSource = kn.taobang(s2);
            }
        }
    }
}
