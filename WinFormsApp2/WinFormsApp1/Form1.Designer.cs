namespace WinFormsApp1
{
    partial class frm_QuanLiSanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            txt_ID = new TextBox();
            btn_loc = new Button();
            txt_loc = new TextBox();
            KieuSapXep = new GroupBox();
            rad_GiamDan = new RadioButton();
            rad_TangDan = new RadioButton();
            cbo_LoaiSp = new ComboBox();
            txt_SoLuong = new TextBox();
            txt_GiaSp = new TextBox();
            txt_TenSp = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_Them = new Button();
            btn_Moi = new Button();
            label1 = new Label();
            dg_SanPham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            KieuSapXep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_SanPham).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txt_ID);
            splitContainer1.Panel1.Controls.Add(btn_loc);
            splitContainer1.Panel1.Controls.Add(txt_loc);
            splitContainer1.Panel1.Controls.Add(KieuSapXep);
            splitContainer1.Panel1.Controls.Add(cbo_LoaiSp);
            splitContainer1.Panel1.Controls.Add(txt_SoLuong);
            splitContainer1.Panel1.Controls.Add(txt_GiaSp);
            splitContainer1.Panel1.Controls.Add(txt_TenSp);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(btn_Xoa);
            splitContainer1.Panel1.Controls.Add(btn_Sua);
            splitContainer1.Panel1.Controls.Add(btn_Them);
            splitContainer1.Panel1.Controls.Add(btn_Moi);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dg_SanPham);
            splitContainer1.Size = new Size(1029, 531);
            splitContainer1.SplitterDistance = 335;
            splitContainer1.TabIndex = 0;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(186, 216);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(228, 27);
            txt_ID.TabIndex = 39;
            // 
            // btn_loc
            // 
            btn_loc.Location = new Point(811, 170);
            btn_loc.Name = "btn_loc";
            btn_loc.Size = new Size(106, 41);
            btn_loc.TabIndex = 38;
            btn_loc.Text = "Loc";
            btn_loc.UseVisualStyleBackColor = true;
            btn_loc.Click += btn_loc_Click;
            // 
            // txt_loc
            // 
            txt_loc.Location = new Point(811, 127);
            txt_loc.Name = "txt_loc";
            txt_loc.Size = new Size(125, 27);
            txt_loc.TabIndex = 37;
            // 
            // KieuSapXep
            // 
            KieuSapXep.Controls.Add(rad_GiamDan);
            KieuSapXep.Controls.Add(rad_TangDan);
            KieuSapXep.Location = new Point(525, 127);
            KieuSapXep.Name = "KieuSapXep";
            KieuSapXep.Size = new Size(154, 105);
            KieuSapXep.TabIndex = 36;
            KieuSapXep.TabStop = false;
            KieuSapXep.Text = "Kiểu Sắp Xếp";
            // 
            // rad_GiamDan
            // 
            rad_GiamDan.AutoSize = true;
            rad_GiamDan.Location = new Point(6, 60);
            rad_GiamDan.Name = "rad_GiamDan";
            rad_GiamDan.Size = new Size(96, 24);
            rad_GiamDan.TabIndex = 34;
            rad_GiamDan.TabStop = true;
            rad_GiamDan.Text = "Giảm Dần";
            rad_GiamDan.UseVisualStyleBackColor = true;
            rad_GiamDan.CheckedChanged += rad_GiamDan_CheckedChanged;
            // 
            // rad_TangDan
            // 
            rad_TangDan.AutoSize = true;
            rad_TangDan.Location = new Point(6, 26);
            rad_TangDan.Name = "rad_TangDan";
            rad_TangDan.Size = new Size(93, 24);
            rad_TangDan.TabIndex = 34;
            rad_TangDan.TabStop = true;
            rad_TangDan.Text = "Tăng Dần";
            rad_TangDan.UseVisualStyleBackColor = true;
            rad_TangDan.CheckedChanged += rad_TangDan_CheckedChanged;
            // 
            // cbo_LoaiSp
            // 
            cbo_LoaiSp.FormattingEnabled = true;
            cbo_LoaiSp.Location = new Point(644, 73);
            cbo_LoaiSp.Name = "cbo_LoaiSp";
            cbo_LoaiSp.Size = new Size(220, 28);
            cbo_LoaiSp.TabIndex = 33;
            cbo_LoaiSp.SelectedIndexChanged += cbo_LoaiSp_SelectedIndexChanged;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(173, 180);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(229, 27);
            txt_SoLuong.TabIndex = 32;
            // 
            // txt_GiaSp
            // 
            txt_GiaSp.Location = new Point(174, 127);
            txt_GiaSp.Name = "txt_GiaSp";
            txt_GiaSp.Size = new Size(229, 27);
            txt_GiaSp.TabIndex = 32;
            // 
            // txt_TenSp
            // 
            txt_TenSp.Location = new Point(174, 78);
            txt_TenSp.Name = "txt_TenSp";
            txt_TenSp.Size = new Size(229, 27);
            txt_TenSp.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(703, 130);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 31;
            label6.Text = "Lọc Theo Giá: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 187);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 31;
            label4.Text = "Số Lượng: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 134);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 31;
            label3.Text = "Giá Sản Phẩm: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(126, 223);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 31;
            label7.Text = "ID";
            label7.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 76);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 31;
            label5.Text = "Loại Sản Phẩm: ";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 81);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 31;
            label2.Text = "Tên Sản Phẩm: ";
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(754, 249);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(110, 37);
            btn_Xoa.TabIndex = 30;
            btn_Xoa.Text = "Xoa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(569, 249);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(110, 37);
            btn_Sua.TabIndex = 29;
            btn_Sua.Text = "Sua";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(380, 249);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(110, 37);
            btn_Them.TabIndex = 28;
            btn_Them.Text = "Them";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Moi
            // 
            btn_Moi.Location = new Point(197, 249);
            btn_Moi.Name = "btn_Moi";
            btn_Moi.Size = new Size(110, 37);
            btn_Moi.TabIndex = 27;
            btn_Moi.Text = "Moi";
            btn_Moi.UseVisualStyleBackColor = true;
            btn_Moi.Click += btn_Moi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 21);
            label1.Name = "label1";
            label1.Size = new Size(351, 38);
            label1.TabIndex = 22;
            label1.Text = "QUAN LI SAN PHAM";
            // 
            // dg_SanPham
            // 
            dg_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_SanPham.Dock = DockStyle.Fill;
            dg_SanPham.Location = new Point(0, 0);
            dg_SanPham.Name = "dg_SanPham";
            dg_SanPham.RowHeadersWidth = 51;
            dg_SanPham.Size = new Size(1029, 192);
            dg_SanPham.TabIndex = 0;
            dg_SanPham.CellClick += dg_SanPham_CellClick;
            // 
            // frm_QuanLiSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 531);
            Controls.Add(splitContainer1);
            Name = "frm_QuanLiSanPham";
            Text = "Quản Lí Sản Phẩm";
            Load += frm_QuanLiSanPham_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            KieuSapXep.ResumeLayout(false);
            KieuSapXep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_SanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txt_TenSp;
        private Label label2;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private Button btn_Moi;
        private Label label1;
        private TextBox txt_SoLuong;
        private TextBox txt_GiaSp;
        private Label label4;
        private Label label3;
        private Label label5;
        private ComboBox cbo_LoaiSp;
        private GroupBox KieuSapXep;
        private RadioButton rad_GiamDan;
        private RadioButton rad_TangDan;
        private DataGridView dg_SanPham;
        private TextBox txt_loc;
        private Label label6;
        private Button btn_loc;
        private TextBox txt_ID;
        private Label label7;
    }
}
