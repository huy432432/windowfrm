using System;
using System.Windows.Forms;

namespace p2_b5
{
    public partial class Form1 : Form
    {
        string chuoitam = "";       
        char toantu;                
        double[] toanhang = new double[2];
        double ketqua;             
        int buoc = 1;               
        public Form1()
        {
            InitializeComponent();
            GanSuKienChoCacNut();
        }

        private void GanSuKienChoCacNut()
        {
            btn0.Click += NumberButtons;
            btn1.Click += NumberButtons;
            btn2.Click += NumberButtons;
            btn3.Click += NumberButtons;
            btn4.Click += NumberButtons;
            btn5.Click += NumberButtons;
            btn6.Click += NumberButtons;
            btn7.Click += NumberButtons;
            btn8.Click += NumberButtons;
            btn9.Click += NumberButtons;

            btnCong.Click += Operations;
            btnTru.Click += Operations;
            btnNhan.Click += Operations;
            btnChia.Click += Operations;
        }

        private void NumberButtons(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if ((b == null) || (b.Text == "0" && chuoitam.Length == 0))
                return;

            chuoitam += b.Text;
            txtManHinh.Text = chuoitam;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (chuoitam.Length == 0)
            {
                buoc = 1;
                toanhang[0] = toanhang[1] = 0.0;
                toantu = ' ';
                ketqua = 0.0;
                txtManHinh.Text = "0";
            }
            else
            {
                chuoitam = "";
                txtManHinh.Text = "0";
            }
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!chuoitam.Contains("."))
            {
                if (chuoitam.Length == 0) chuoitam = "0"; 
                chuoitam = chuoitam + ".";
                txtManHinh.Text = chuoitam;
            }
        }

        private void btnCongTru_Click(object sender, EventArgs e)
        {
            if (chuoitam.Length == 0) return;

            if (chuoitam.Contains("-"))
                chuoitam = chuoitam.Replace("-", ""); 
            else
                chuoitam = "-" + chuoitam; 

            txtManHinh.Text = chuoitam;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (chuoitam.Length != 0)
                toanhang[1] = Double.Parse(chuoitam);

            switch (toantu)
            {
                case '+':
                    ketqua = toanhang[0] + toanhang[1];
                    break;
                case '-':
                    ketqua = toanhang[0] - toanhang[1];
                    break;
                case '*':
                    ketqua = toanhang[0] * toanhang[1];
                    break;
                case '/':
                    if (toanhang[1] == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0");
                        return;
                    }
                    ketqua = toanhang[0] / toanhang[1];
                    break;
            }

            txtManHinh.Text = ketqua.ToString();

            buoc = 1;
            chuoitam = "";
            toanhang[0] = ketqua;
        }

        private void Operations(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (buoc == 1)
            {
                toantu = b.Text[0]; 
                if (chuoitam.Length == 0)
                    toanhang[buoc - 1] = ketqua; 
                else
                    toanhang[buoc - 1] = Double.Parse(chuoitam);

                txtManHinh.Text = toanhang[0].ToString();
                buoc++;
            }
            else if (buoc == 2)
            {
                btnBang_Click(null, null);

                toantu = b.Text[0];
                toanhang[0] = ketqua;
                buoc = 2; 
            }

            chuoitam = "";
        }
    }
}