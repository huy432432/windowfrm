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
        public void InsertTable(DataTable tb, object[] gt)
        {
            if (tb == null || gt == null || tb.Columns.Count != gt.Length) return;

            DataRow newRow = tb.NewRow();

            for (int i = 0; i < gt.Length; i++)
            {
                newRow[i] = gt[i] ?? DBNull.Value; 
            }

            tb.Rows.Add(newRow);
        }

        public void UpdateTable(DataTable tb, object[] gt)
        {
            if (tb == null || gt == null || gt.Length < 2) return;


            DataRow r = null;
            foreach (DataRow row in tb.Rows)
            {
                if (row[0].Equals(gt[0]))
                {
                    r = row;
                    break;
                }
            }

            if (r == null) return;

            for (int i = 1; i < gt.Length && i < tb.Columns.Count; i++)
            {
                r[i] = gt[i] ?? DBNull.Value;
            }
        }
        public void DeleteTable(DataTable tb, string MaNV)
        {
            if (tb == null || string.IsNullOrEmpty(MaNV)) return;

            DataRow dtr = null;
            foreach (DataRow row in tb.Rows)
            {
                if (row[0].ToString() == MaNV)
                {
                    dtr = row;
                    break;
                }
            }
            if (dtr != null)
            {
                tb.Rows.Remove(dtr);
                MessageBox.Show("Xóa dòng thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show($"Không tìm thấy dòng với mã nhân viên: {MaNV}.", "Lỗi");
            }
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
    }
}

