namespace _10123308_NguyenDuyThuan_KTTH_WF
{
    partial class frmCongNgheNET
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblQLS = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblNXB = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.btMoi = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.dgSach = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLS
            // 
            this.lblQLS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblQLS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQLS.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQLS.Location = new System.Drawing.Point(0, 0);
            this.lblQLS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQLS.Name = "lblQLS";
            this.lblQLS.Size = new System.Drawing.Size(1035, 76);
            this.lblQLS.TabIndex = 0;
            this.lblQLS.Text = "QUẢN LÝ SÁCH";
            this.lblQLS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSach.Location = new System.Drawing.Point(73, 119);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(86, 20);
            this.lblMaSach.TabIndex = 1;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTacGia.Location = new System.Drawing.Point(73, 177);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(77, 20);
            this.lblTacGia.TabIndex = 5;
            this.lblTacGia.Text = "Tác giả:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenSach.Location = new System.Drawing.Point(445, 122);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(92, 20);
            this.lblTenSach.TabIndex = 3;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNXB.Location = new System.Drawing.Point(449, 177);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(53, 20);
            this.lblNXB.TabIndex = 7;
            this.lblNXB.Text = "NXB:";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSL.Location = new System.Drawing.Point(721, 177);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(88, 20);
            this.lblSL.TabIndex = 9;
            this.lblSL.Text = "Số lượng:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(165, 116);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(182, 26);
            this.txtMaSach.TabIndex = 2;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(543, 119);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(377, 26);
            this.txtTenSach.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(815, 174);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(105, 26);
            this.txtSL.TabIndex = 10;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(165, 174);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(182, 26);
            this.txtTacGia.TabIndex = 6;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(523, 171);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(182, 26);
            this.txtNXB.TabIndex = 8;
            // 
            // btMoi
            // 
            this.btMoi.Location = new System.Drawing.Point(104, 251);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(128, 38);
            this.btMoi.TabIndex = 11;
            this.btMoi.Text = "Mới";
            this.btMoi.UseVisualStyleBackColor = true;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(303, 251);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(128, 38);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(523, 251);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(128, 38);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(743, 251);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(128, 38);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // dgSach
            // 
            this.dgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSach.Location = new System.Drawing.Point(0, 325);
            this.dgSach.Name = "dgSach";
            this.dgSach.RowHeadersWidth = 51;
            this.dgSach.RowTemplate.Height = 24;
            this.dgSach.Size = new System.Drawing.Size(1035, 183);
            this.dgSach.TabIndex = 15;
            this.dgSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSach_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCongNgheNET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 508);
            this.Controls.Add(this.dgSach);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btMoi);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.lblNXB);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.lblQLS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCongNgheNET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công Nghệ .NET";
            this.Load += new System.EventHandler(this.frmCongNgheNET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQLS;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView dgSach;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

