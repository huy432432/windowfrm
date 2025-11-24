// MainForm.cs
using System;
using System.Windows.Forms;

namespace MyNameProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Clear previous errors
            errorProvider1.Clear();

            bool hasError = false;

            // Validate YourName
            if (string.IsNullOrWhiteSpace(txtYourName.Text))
            {
                errorProvider1.SetError(txtYourName, "Vui lòng nhập tên của bạn!");
                hasError = true;
            }

            // Validate Year of birth
            if (string.IsNullOrWhiteSpace(txtYear.Text))
            {
                errorProvider1.SetError(txtYear, "Vui lòng nhập năm sinh!");
                hasError = true;
            }
            else if (!int.TryParse(txtYear.Text, out int year))
            {
                errorProvider1.SetError(txtYear, "Năm sinh phải là số!");
                hasError = true;
            }

            if (!hasError)
            {
                int birthYear = int.Parse(txtYear.Text);
                int currentAge = DateTime.Now.Year - birthYear;

                MessageBox.Show(
                    $"Tên: {txtYourName.Text}\nTuổi (năm hiện tại - năm sinh): {currentAge}",
                    "Thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();

            errorProvider1.Clear();

            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có thực sự muốn thoát khỏi chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}