namespace p2_b4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNienKhoa = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cboNienKhoa = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.radHK1 = new System.Windows.Forms.RadioButton();
            this.radHK2 = new System.Windows.Forms.RadioButton();
            this.radHK3 = new System.Windows.Forms.RadioButton();
            this.radHK4 = new System.Windows.Forms.RadioButton();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ MÔN HỌC";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(50, 70);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(40, 13);
            this.lblMSSV.TabIndex = 17;
            this.lblMSSV.Text = "MSSV:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(50, 100);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 13);
            this.lblHoTen.TabIndex = 16;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // lblNienKhoa
            // 
            this.lblNienKhoa.AutoSize = true;
            this.lblNienKhoa.Location = new System.Drawing.Point(50, 130);
            this.lblNienKhoa.Name = "lblNienKhoa";
            this.lblNienKhoa.Size = new System.Drawing.Size(59, 13);
            this.lblNienKhoa.TabIndex = 15;
            this.lblNienKhoa.Text = "Niên khóa:";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(50, 160);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(28, 13);
            this.lblLop.TabIndex = 14;
            this.lblLop.Text = "Lớp:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(50, 190);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(44, 13);
            this.lblHocKy.TabIndex = 13;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(50, 220);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(52, 13);
            this.lblMonHoc.TabIndex = 0;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(120, 67);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(150, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 97);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(300, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // cboNienKhoa
            // 
            this.cboNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNienKhoa.FormattingEnabled = true;
            this.cboNienKhoa.Items.AddRange(new object[] {
            "2007",
            "2008",
            "2005"});
            this.cboNienKhoa.Location = new System.Drawing.Point(120, 127);
            this.cboNienKhoa.Name = "cboNienKhoa";
            this.cboNienKhoa.Size = new System.Drawing.Size(150, 21);
            this.cboNienKhoa.TabIndex = 3;
            this.cboNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cboNienKhoa_SelectedIndexChanged);
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(120, 157);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(150, 21);
            this.cboLop.TabIndex = 4;
            // 
            // radHK1
            // 
            this.radHK1.AutoSize = true;
            this.radHK1.Checked = true;
            this.radHK1.Location = new System.Drawing.Point(120, 188);
            this.radHK1.Name = "radHK1";
            this.radHK1.Size = new System.Drawing.Size(28, 17);
            this.radHK1.TabIndex = 5;
            this.radHK1.TabStop = true;
            this.radHK1.Text = "I";
            this.radHK1.UseVisualStyleBackColor = true;
            // 
            // radHK2
            // 
            this.radHK2.AutoSize = true;
            this.radHK2.Location = new System.Drawing.Point(170, 188);
            this.radHK2.Name = "radHK2";
            this.radHK2.Size = new System.Drawing.Size(31, 17);
            this.radHK2.TabIndex = 6;
            this.radHK2.Text = "II";
            this.radHK2.UseVisualStyleBackColor = true;
            // 
            // radHK3
            // 
            this.radHK3.AutoSize = true;
            this.radHK3.Location = new System.Drawing.Point(220, 188);
            this.radHK3.Name = "radHK3";
            this.radHK3.Size = new System.Drawing.Size(34, 17);
            this.radHK3.TabIndex = 7;
            this.radHK3.Text = "III";
            this.radHK3.UseVisualStyleBackColor = true;
            // 
            // radHK4
            // 
            this.radHK4.AutoSize = true;
            this.radHK4.Location = new System.Drawing.Point(270, 188);
            this.radHK4.Name = "radHK4";
            this.radHK4.Size = new System.Drawing.Size(35, 17);
            this.radHK4.TabIndex = 8;
            this.radHK4.Text = "IV";
            this.radHK4.UseVisualStyleBackColor = true;
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Location = new System.Drawing.Point(120, 221);
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(300, 94);
            this.clbMonHoc.TabIndex = 9;
            this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.clbMonHoc_SelectedIndexChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(120, 340);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(80, 30);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(220, 340);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 30);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(320, 340);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.radHK4);
            this.Controls.Add(this.radHK3);
            this.Controls.Add(this.radHK2);
            this.Controls.Add(this.radHK1);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.cboNienKhoa);
            this.Controls.Add(this.lblNienKhoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "frmDangkyMonhoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNienKhoa;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboNienKhoa;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.RadioButton radHK1;
        private System.Windows.Forms.RadioButton radHK2;
        private System.Windows.Forms.RadioButton radHK3;
        private System.Windows.Forms.RadioButton radHK4;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
    }
}