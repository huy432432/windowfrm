using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10123308_NguyenDuyThuan_KTTH_WF
{
    public class clsDatabase
    {
        string chuoikn = @"Data Source=LAPTOP-899I2AVH\SQLEXPRESS;Initial Catalog=CongNgheNET;User ID=sa;Password=1234";
        public SqlConnection conn;
        public SqlDataAdapter da;
        public DataTable dt;
        public void KetNoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = chuoikn;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void NgatKetNoi()
        {
            conn = new SqlConnection(chuoikn);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable table(string query)
        {
            da = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
