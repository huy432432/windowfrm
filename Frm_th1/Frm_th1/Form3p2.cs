using System;
using System.Drawing;
using System.Windows.Forms;

namespace bai10_b3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.SelectionMode = SelectionMode.MultiExtended;

            cboLop.Items.Add("Lớp A");
            cboLop.Items.Add("Lớp B");
            cboLop.SelectedIndex = 0;

            this.AcceptButton = btnCapNhat;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên!");
                txtHoTen.Focus();
                return;
            }

            if (cboLop.SelectedItem.ToString() == "Lớp A")
            {
                lstLopA.Items.Add(txtHoTen.Text.Trim());
            }
            else
            {
                lstLopB.Items.Add(txtHoTen.Text.Trim());
            }

            txtHoTen.Clear();
            txtHoTen.Focus();
        }

        private void MoveSelectedItems(ListBox source, ListBox destination)
        {
            foreach (var item in source.SelectedItems)
            {
                destination.Items.Add(item);
            }

            for (int i = source.SelectedItems.Count - 1; i >= 0; i--)
            {
                source.Items.Remove(source.SelectedItems[i]);
            }
        }

        private void MoveAllItems(ListBox source, ListBox destination)
        {
            destination.Items.AddRange(source.Items);
            source.Items.Clear();
        }

        private void btnSangPhai_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstLopA, lstLopB);
        }

        private void btnSangPhaiHet_Click(object sender, EventArgs e)
        {
            MoveAllItems(lstLopA, lstLopB);
        }

        private void btnSangTrai_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lstLopB, lstLopA);
        }

        private void btnSangTraiHet_Click(object sender, EventArgs e)
        {
            MoveAllItems(lstLopB, lstLopA);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}