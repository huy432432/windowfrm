using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BT1
{
    public class ClsCSDL
    {
        private SqlConnection conn;

        public void KetNoi(string connectionString)
        {
            try
            {
                connectionString = "Server=LAPTOP-899I2AVH\\SQLEXPRESS;Database=QuanLyThuVien;Integrated Security=True";
                conn = new SqlConnection(connectionString);
                conn.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kết nối thất bại: {ex.Message}", "Lỗi");
            }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            try
            {
                if (conn == null || conn.State == ConnectionState.Closed)
                {
                    throw new InvalidOperationException("Kết nối chưa được khởi tạo hoặc đã đóng.");
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực thi truy vấn SELECT: {ex.Message}", "Lỗi");
                return null;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực thi truy vấn hành động: {ex.Message}", "Lỗi");
                return -1;
            }
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
        public DataTable FillDataTable(string query)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
           
        }
        public void UpdateTableToDataBase(DataTable dt, string tenbang)
        {
            if (dt == null || string.IsNullOrEmpty(tenbang)) return;

            SqlConnection conn = new SqlConnection("Server=LAPTOP-899I2AVH\\SQLEXPRESS;Database=QuanLyThuVien;Integrated Security=True");
            conn.Open();

            string query = $"SELECT * FROM {tenbang}";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);

            da.Update(dt);

            MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo");
        }

        //Bài 2 
        public void UpdateTable(DataTable tb, object[] gt)
        {
            if (tb == null || gt == null || gt.Length < 2)
            {
                MessageBox.Show("Dữ liệu không hợp lệ.", "Lỗi");
                return;
            }
            string locBanGhi = $"MaNhanVien = '{gt[0]}'";
            DataView dv = new DataView(tb)
            {
                RowFilter = locBanGhi
            };

            if (dv.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy dòng với mã nhân viên: {gt[0]}", "Thông báo");
                return;
            }

            DataRowView rUp = dv[0];
            for (int i = 1; i < gt.Length && i < tb.Columns.Count; i++)
            {
                rUp[i] = gt[i] ?? DBNull.Value; 
            }

            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            
        }
        public int LocDuLieu(DataTable dt, string Dk)
        {
            if (dt == null || dt.Rows.Count == 0 || string.IsNullOrEmpty(Dk))
            {
                MessageBox.Show("Dữ liệu hoặc điều kiện không hợp lệ.", "Lỗi");
                return -1;
            }
            DataView dv = new DataView(dt)
            {
                RowFilter = Dk
            };
            if (dv.Count > 0)
            {
                DataRowView rowView = dv[0]; 
                return dt.Rows.IndexOf(rowView.Row);
            }
            return -1;
            
        }
        public void DeleteTable(DataTable tb, string MaNV)
        {           
            if (tb == null || string.IsNullOrEmpty(MaNV))
            {
                MessageBox.Show("Dữ liệu hoặc mã nhân viên không hợp lệ.", "Lỗi");
                return;
            }
            string locBanGhi1 = $"MaNhanVien = '{MaNV}'";
            DataView dv = new DataView(tb)
            {
                RowFilter = locBanGhi1
            };
            if (dv.Count > 0)
            {
                DataRowView rowToDelete = dv[0];
                tb.Rows.Remove(rowToDelete.Row); 
           
                MessageBox.Show("Xóa dòng thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show($"Không tìm thấy dòng với mã nhân viên: {MaNV}", "Thông báo");
            }
        }
    }
}

