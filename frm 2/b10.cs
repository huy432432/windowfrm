using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT10
{
    public partial class b10 : Form
    {
        public b10()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string str = $"Employee Name: {txtEN.Text}\n" +
                                  $"Date of Birth: {mtxtbDoB.Text}\n" +
                                  $"Address: {txtAddress.Text}\n" +
                                  $"City: {txtCity.Text}\n" +
                                  $"Country: {cboCountry.Text}\n" +
                                  $"Qualification: {txtQualification.Text}\n" +
                                  $"Phone: {mtxtbPhone.Text}\n" +
                                  $"Email: {txtEMail.Text}\n" +
                                  $"Date of Joining: {dateTimePicker1.Value.ToShortDateString()}";
            MessageBox.Show(str, "Employee Information");

        }
    }
}
