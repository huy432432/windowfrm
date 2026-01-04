using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class KetNoiDuLieu
    {
        public SqlConnection conn = new SqlConnection("server=LAPTOP-899I2AVH\\SQLEXPRESS;database=QLSinhVien;integrated security=true;");
        public void myconnect()
        {
            conn.Open();
        }
        public void myclose()
        {
            conn.Close();
        }
        public DataTable taobang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
    }
}
