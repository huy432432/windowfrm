using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BT1
{
    public class DataHelper
    {
        private SqlConnection conn;

        public void InitializeConnection(string connectionString)
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

        public int StoreNonQuery(string storedProcedureName, SqlParameter[] parameters = null)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(storedProcedureName, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực thi Stored Procedure (NonQuery): {ex.Message}", "Lỗi");
                return -1;
            }
        }

        public SqlDataReader StoreReader(string storedProcedureName, SqlParameter[] parameters = null)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(storedProcedureName, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực thi Stored Procedure (Reader): {ex.Message}", "Lỗi");
                return null;
            }
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
