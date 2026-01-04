using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Diagnostics;

namespace BT1
{
    public partial class frmCauHinh : Form
    {
        public frmCauHinh()
        {
            InitializeComponent();
        }
        private string quyenTruyCap;
        private string serverName;
        private string database;
        private string account;
        private string password;

        

        private void btnCauHinh_Click_1(object sender, EventArgs e)
        {
            GhiDuLieu();
            DocDuLieu();
            frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien();           
            this.Hide();
            frmQuanLyNhanVien.ShowDialog();
            this.Close();
        }

        public void GhiDuLieu()
        {
            try
            {
                string filePath = Path.Combine(@"C:\Users\Thuan\source\repos\Winform\10123308_NguyenDuyThuan_TH03\BT1\bin\Debug", "Save.txt");

                string quyenTruyCap = radWinDow.Checked ? "Windows Authentication" : "SQL Authentication";
                string serverName = txtTenMay.Text;
                string database = txtData.Text;
                string account = txtUserName.Text;
                string password = txtPass.Text;

                using (StreamWriter dw = new StreamWriter(filePath))
                {
                    dw.WriteLine($"QuyenTruyCap =  {quyenTruyCap}");
                    dw.WriteLine($"Server =  {serverName}");
                    dw.WriteLine($"Database =  {database}");
                    dw.WriteLine($"Account =  {account}");
                    dw.WriteLine($"Password =  {password}");
                }

                MessageBox.Show($"Ghi thông tin thành công! Tệp được lưu tại: {filePath}", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi dữ liệu: {ex.Message}", "Lỗi");
            }
        }
        public void DocDuLieu()
        {
            try
            {
                string filePath = Path.Combine(@"C:\Users\Thuan\source\repos\Winform\10123308_NguyenDuyThuan_TH03\BT1\bin\Debug", "Save.txt");

                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("QuyenTruyCap"))
                            {
                                quyenTruyCap = line.Split('=')[1].Trim();
                            }
                            else if (line.StartsWith("Server"))
                            {
                                serverName = line.Split('=')[1].Trim();
                            }
                            else if (line.StartsWith("Database"))
                            {
                                database = line.Split('=')[1].Trim();
                            }
                            else if (line.StartsWith("Account"))
                            {
                                account = line.Split('=')[1].Trim();
                            }
                            else if (line.StartsWith("Password"))
                            {
                                password = line.Split('=')[1].Trim();
                            }
                        }

                        if (quyenTruyCap == "Windows Authentication")
                        {
                            radWinDow.Checked = true;
                        }
                        else if (quyenTruyCap == "SQL Authentication")
                        {
                            radAcount.Checked = true;
                        }

                        txtTenMay.Text = serverName;
                        txtData.Text = database;
                        txtUserName.Text = account;
                        txtPass.Text = password;

                        MessageBox.Show("Đọc thông tin thành công!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tệp cấu hình không tồn tại!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc dữ liệu: {ex.Message}", "Lỗi");
            }
        }

    }
}
