using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BT4
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("server=LAPTOP-899I2AVH\\SQLEXPRESS;database=StudentDB;integrated security=true;");
        }
    

    private void Form1_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            conn.Open();
            da = new SqlDataAdapter("Select classNo, className From StudentClass", conn);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            cboClassNo.DisplayMember = "className";
            cboClassNo.ValueMember = "classNo";
            cboClassNo.DataSource = dt;
        }

        private void cboClassNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboClassNo.SelectedIndex != -1)
            {
                string classNo = cboClassNo.SelectedValue.ToString();
                LoadClassDetails(classNo);
                LoadStudentDetails(classNo);
            }
        }

        private void LoadClassDetails(string classNo)
        {
            conn.Open();
            da = new SqlDataAdapter("Select totalStudents, homeroomTeacher From StudentClass WHERE classNo = @classNo", conn);
            da.SelectCommand.Parameters.AddWithValue("@classNo", classNo);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtTotalStudents.Text = row["totalStudents"].ToString();
                txtHomeroomTeacher.Text = row["homeroomTeacher"].ToString();
            }
        }

        private void LoadStudentDetails(string classNo)
        {
            conn.Open();
            da = new SqlDataAdapter("Select stuName, stuYear, address From Student Where classNo = @classNo", conn);
            da.SelectCommand.Parameters.AddWithValue("@classNo", classNo);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            listBox1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                listBox1.Items.Add($"Name: {row["stuName"]}, Year: {row["stuYear"]:yyyy-MM-dd}, Address: {row["address"]}");
            }
        } 
    }
}
