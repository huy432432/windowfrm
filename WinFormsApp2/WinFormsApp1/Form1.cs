using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class frm_QuanLiSanPham : Form
    {

        SqlConnection conn;
        SqlDataAdapter daProduct, daCategory;
        DataSet ds;
        SqlCommandBuilder cmdBuilder;

        public frm_QuanLiSanPham()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-BETZI\SQLEXPRESS;Initial Catalog=QLsanpham;Integrated Security=True");

        }

        public void frm_QuanLiSanPham_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            //Hien thi combobox
            daCategory = new SqlDataAdapter("SELECT * FROM tbCategory", conn);
            daCategory.Fill(ds, "tbCategory");
            cbo_LoaiSp.DataSource = ds.Tables["tbCategory"];
            cbo_LoaiSp.DisplayMember = "CategoryName";
            cbo_LoaiSp.ValueMember = "CategoryId";

            //Hien thi bang
            LoadProducts();
        }

        private void LoadProducts()
        {
            string sql = "SELECT * FROM tbProduct"; // Chỉ load tbProduct
            daProduct = new SqlDataAdapter(sql, conn);
            cmdBuilder = new SqlCommandBuilder(daProduct);

            if (ds.Tables["tbProduct"] != null)
                ds.Tables["tbProduct"].Clear();

            daProduct.Fill(ds, "tbProduct");

            // Hiển thị
            dg_SanPham.DataSource = ds.Tables["tbProduct"];

            // Thêm cột CategoryName để hiển thị trong DataGridView (không lưu vào DB)
            if (!dg_SanPham.Columns.Contains("CategoryName"))
            {
                DataGridViewComboBoxColumn cboCol = new DataGridViewComboBoxColumn();
                cboCol.HeaderText = "Loại SP";
                cboCol.DataPropertyName = "CategoryId"; // bind với CategoryId trong tbProduct
                cboCol.DataSource = ds.Tables["tbCategory"];
                cboCol.DisplayMember = "CategoryName";
                cboCol.ValueMember = "CategoryId";
                dg_SanPham.Columns.Add(cboCol);
            }

            dg_SanPham.Columns["CategoryId"].Visible = false; // ẩn cột ID
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["tbProduct"];
            DataRow row = dt.NewRow();

            row["ProductName"] = txt_TenSp.Text;
            row["Price"] = decimal.Parse(txt_GiaSp.Text);
            row["Quantity"] = int.Parse(txt_SoLuong.Text);
            row["CategoryId"] = cbo_LoaiSp.SelectedValue;
            row["ProductId"] = int.Parse(txt_ID.Text);

            dt.Rows.Add(row);
            daProduct.Update(dt);

            LoadProducts();
        }



        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dg_SanPham.CurrentRow != null)
            {
                int index = dg_SanPham.CurrentRow.Index;
                DataRow row = ds.Tables["tbProduct"].Rows[index];

                row["ProductName"] = txt_TenSp.Text;
                row["Price"] = decimal.Parse(txt_GiaSp.Text);
                row["Quantity"] = int.Parse(txt_SoLuong.Text);
                row["CategoryId"] = cbo_LoaiSp.SelectedValue;
                row["ProductId"] = int.Parse(txt_ID.Text);

                daProduct.Update(ds.Tables["tbProduct"]);
                LoadProducts();
            }
        }



        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dg_SanPham.CurrentRow != null)
            {
                int index = dg_SanPham.CurrentRow.Index;
                ds.Tables["tbProduct"].Rows[index].Delete();
                daProduct.Update(ds.Tables["tbProduct"]);
                LoadProducts();
            }
        }



        private void rad_TangDan_CheckedChanged(object sender, EventArgs e)
        {
            SortProducts();
        }

        private void rad_GiamDan_CheckedChanged(object sender, EventArgs e)
        {
            SortProducts();
        }

        private void SortProducts()
        {
            if (ds.Tables["tbProduct"] == null) return;

            DataView dv = ds.Tables["tbProduct"].DefaultView;
            if (rad_TangDan.Checked)
                dv.Sort = "Price ASC";
            else if (rad_GiamDan.Checked)
                dv.Sort = "Price DESC";

            dg_SanPham.DataSource = dv;
        }

        private void btn_Moi_Click(object sender, EventArgs e)
        {
            // Xóa TextBox nhập sản phẩm
            txt_TenSp.Clear();
            txt_GiaSp.Clear();
            txt_SoLuong.Clear();

            // Reset ComboBox loại sản phẩm về mặc định
            if (cbo_LoaiSp.Items.Count > 0)
                cbo_LoaiSp.SelectedIndex = 0;

            // Xóa TextBox lọc giá
            txt_loc.Clear();

            // Reset RadioButton sắp xếp
            rad_TangDan.Checked = true;   // mặc định tăng dần
            rad_GiamDan.Checked = false;

            // Hiển thị tất cả sản phẩm
            if (ds.Tables["tbProduct"] != null)
            {
                DataView dv = ds.Tables["tbProduct"].DefaultView;
                dv.RowFilter = "";    // bỏ lọc
                dv.Sort = "";         // bỏ sắp xếp
                dg_SanPham.DataSource = dv;
            }

            // Focus vào ô tên sản phẩm để nhập mới
            txt_TenSp.Focus();

            // Bỏ chọn dòng trong DataGridView
            dg_SanPham.ClearSelection();
        }

        private void cbo_LoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void FilterByCategory()
        {
            if (ds.Tables["tbProduct"] == null) return;

            int categoryId = Convert.ToInt32(cbo_LoaiSp.SelectedValue);

            // Lọc DataView dựa trên CategoryId
            DataView dv = ds.Tables["tbProduct"].DefaultView;
            dv.RowFilter = "CategoryId = " + categoryId;

            dg_SanPham.DataSource = dv;
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            FilterByPrice();

        }

        private void FilterByPrice()
        {
            if (ds.Tables["tbProduct"] == null) return;

            decimal priceFilter = 0;
            // Lấy giá nhập từ txt_loc
            if (!decimal.TryParse(txt_loc.Text, out priceFilter))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }

            DataView dv = ds.Tables["tbProduct"].DefaultView;
            dv.RowFilter = "Price > " + priceFilter;

            dg_SanPham.DataSource = dv;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dg_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dg_SanPham.Rows[e.RowIndex];

                txt_TenSp.Text = r.Cells["ProductName"].Value.ToString();
                txt_GiaSp.Text = r.Cells["Price"].Value.ToString();
                txt_SoLuong.Text = r.Cells["Quantity"].Value.ToString();
                txt_ID.Text = r.Cells["ProductID"].Value.ToString();

                // Lấy CategoryId, rồi set ComboBox
                cbo_LoaiSp.SelectedValue = r.Cells["CategoryId"].Value;
            }
        }

    }
}
