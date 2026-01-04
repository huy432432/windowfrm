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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection con = new SqlConnection("server=LAPTOP-899I2AVH\\SQLEXPRESS;database=QL;integrated security=true;");
        DataSet ds;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            txtMaSach.Enabled = false;
            txtTieuDe.Enabled = false;
            txtGia.Enabled = false;
            txtSL.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;

            con.Open();
            da = new SqlDataAdapter("select * from Category", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            cboLoaiSach.DataSource = dt;
            cboLoaiSach.DisplayMember = "CategoryName";
            cboLoaiSach.ValueMember = "CategoryID";
        }

        private void LoadData()
        {
            con.Open();
            da = new SqlDataAdapter("select * from Products", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dgvTT.DataSource = dt;

            txtMaSach.DataBindings.Clear();
            txtTieuDe.DataBindings.Clear();
            txtGia.DataBindings.Clear();
            txtSL.DataBindings.Clear();

            txtMaSach.DataBindings.Add("Text", dgvTT.DataSource, "ProductCode");
            txtTieuDe.DataBindings.Add("Text", dgvTT.DataSource, "Description");
            txtGia.DataBindings.Add("Text", dgvTT.DataSource, "UnitPrice");
            txtSL.DataBindings.Add("Text", dgvTT.DataSource, "OnHandQuantity");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = true;
            txtTieuDe.Enabled = true;
            txtGia.Enabled = true;
            txtSL.Enabled = true;

            txtMaSach.Text = "";
            txtTieuDe.Text = "";
            txtGia.Text = "";
            txtSL.Text = "";

            txtMaSach.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            cmd = new SqlCommand("INSERT INTO Products (ProductCode, Description, UnitPrice, OnHandQuantity, CategoryID) VALUES ('"
                                            + txtMaSach.Text + "', '"
                                            + txtTieuDe.Text + "', '"
                                            + txtGia.Text + "', '"
                                            + txtSL.Text + "', '"
                                            + cboLoaiSach.SelectedValue.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();

            txtMaSach.Enabled = false;
            txtTieuDe.Enabled = false;
            txtGia.Enabled = false;
            txtSL.Enabled = false;

            txtMaSach.Text = "";
            txtTieuDe.Text = "";
            txtGia.Text = "";
            txtSL.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
        }
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            txtTieuDe.Enabled = false;
            txtGia.Enabled = false;
            txtSL.Enabled = false;

            txtMaSach.Text = "";
            txtTieuDe.Text = "";
            txtGia.Text = "";
            txtSL.Text = "";
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        private void dgvTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTT_CellClick(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "UPDATE Products SET Description=@description, UnitPrice=@unitprice, OnHandQuantity=@onhandquantity, CategoryID=@categoryid WHERE ProductCode=@productcode";

            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@description", txtTieuDe.Text);
            cmd.Parameters.AddWithValue("@unitprice", txtGia.Text);
            cmd.Parameters.AddWithValue("@onhandquantity", txtSL.Text);
            cmd.Parameters.AddWithValue("@categoryid", cboLoaiSach.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@productcode", txtMaSach.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn muốn xóa không?", "Tiêu đề", MessageBoxButtons.YesNo);
            if (kq == System.Windows.Forms.DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = new SqlCommand("DELETE FROM Products WHERE ProductCode = @ProductCode", con);
                cmd.Parameters.AddWithValue("@ProductCode", txtMaSach.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                LoadData();
            }
        }

        private void cboLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSach.SelectedValue != null)
            {
                int categoryId;
                if (int.TryParse(cboLoaiSach.SelectedValue.ToString(), out categoryId))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Products WHERE CategoryID=@categoryid", con);
                    da.SelectCommand.Parameters.AddWithValue("@categoryid", categoryId);

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    con.Close();
                    dgvTT.DataSource = ds.Tables[0];
                }
            }
        } 
    }
}
