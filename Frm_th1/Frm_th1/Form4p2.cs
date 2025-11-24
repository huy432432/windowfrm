using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace p2_b4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cboNienKhoa.Items.AddRange(new string[] { "2020", "2021", "2022", "2023", "2024", "2025" });
            cboLop.Items.AddRange(new string[] { "TH01", "TH02", "TH03", "ATTT", "CTK44" });

            clbMonHoc.Items.AddRange(new string[] { "LT Windows", "LT Internet", "Mạng máy tính", "UML", "Java", "Cấu trúc dữ liệu" });

            cboNienKhoa.SelectedIndex = 0;
            cboLop.SelectedIndex = 0;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ MSSV và Họ tên!");
                return;
            }

            string hocky = "";
            if (radHK1.Checked) hocky = "I";
            if (radHK2.Checked) hocky = "II";
            if (radHK3.Checked) hocky = "III";
            if (radHK4.Checked) hocky = "IV";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sinh viên: " + txtHoTen.Text);
            sb.AppendLine("Lớp: " + cboLop.Text);
            sb.AppendLine("Niên khóa: " + cboNienKhoa.Text);
            sb.AppendLine("Đã đăng ký học Học kỳ " + hocky + " Các môn học sau:");

            int count = 1;
            foreach (var item in clbMonHoc.CheckedItems)
            {
                sb.AppendLine(count + ". " + item.ToString());
                count++;
            }

            MessageBox.Show(sb.ToString(), "Kết quả đăng ký");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            cboNienKhoa.SelectedIndex = 0;
            cboLop.SelectedIndex = 0;
            radHK1.Checked = true;

            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }

            txtMSSV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}