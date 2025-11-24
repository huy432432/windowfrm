using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_th1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            btn_Giai.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void Gi(object sender, EventArgs e)
        {

        }

        private void btn_Giai_Click(object sender, EventArgs e)
        {
            float a, b, x;
            a = float.Parse(txt_nhapA.Text);
            b = float.Parse(txt_NhapB.Text);
            x = -b / a;

            txt_nghiem.Text = ($"Nghiệm của pt là x = {x}");
            btn_xoa.Enabled = true;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_nhapA.Text = "";
            txt_NhapB.Text = "";
            txt_nghiem.Text = "";
            btn_Giai.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void txt_nhapA_TextChanged(object sender, EventArgs e)
        {
            
            float a;
            bool ok = float.TryParse(txt_nhapA.Text, out a);
            if (!ok)
                errorProvider1.SetError(txt_nhapA, "A phải là số!");
            btn_Giai.Enabled = ok;
        }

        private void txt_nhapB_TextChanged(object sender, EventArgs e)
        {

            float b;
            bool okB = float.TryParse(txt_NhapB.Text, out b);
            if (!okB)
                errorProvider2.SetError(txt_NhapB, "B phải là số!");
           
        }

        
    }
}
