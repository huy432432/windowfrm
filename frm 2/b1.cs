namespace day2
{
    public partial class b1 : Form
    {
        public b1()
        {
            InitializeComponent();
        }
        int i = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_DongHo.Text = i.ToString(); i--;
            if (i < 0)
            {
                this.timer1.Enabled = false;
                this.lbl_DongHo.Text = "Ket Thuc";
            }
        }

        private void btn_Dung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
