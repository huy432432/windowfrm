using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class frmThongKeTheoKhoa : Form
    {
        public frmThongKeTheoKhoa()
        {
            InitializeComponent();
        }
        KetNoiDuLieu kn = new KetNoiDuLieu();
        private void frmThongKeTheoKhoa_Load(object sender, EventArgs e)
        {
            kn.myconnect();
            string sql = "SELECT * FROM Khoa";
            cboMaKhoa.DataSource = kn.taobang(sql);
            cboMaKhoa.DisplayMember = "MaKhoa";
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaKhoa.SelectedIndex != -1)
            {
                string s = "SELECT * FROM Khoa WHERE MaKhoa = '" + cboMaKhoa.Text + "'";
                DataTable d = kn.taobang(s);
                foreach (DataRow hang in d.Rows)
                {
                    txtTenKhoa.Text = hang["TenKhoa"].ToString();
                }

                string s1 = "SELECT MaSV, HoSV, TenSV, NgaySinh " +
                            "FROM SinhVien sv INNER JOIN Khoa kh ON sv.MaKhoa = kh.MaKhoa " +
                            "WHERE kh.MaKhoa = '" + cboMaKhoa.Text + "'";
                dgvKhoa.DataSource = kn.taobang(s1);

                string s2 = "SELECT COUNT(*) FROM SinhVien " +
                            "WHERE MaKhoa = '" + cboMaKhoa.Text + "' GROUP BY MaKhoa";
                DataTable dt = kn.taobang(s2);
                if (dt.Rows.Count > 0)
                {
                    txtTongSoSV.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    txtTongSoSV.Text = "0";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            kn.myclose();
        }
    }
}
