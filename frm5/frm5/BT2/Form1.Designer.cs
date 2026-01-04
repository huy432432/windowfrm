namespace BT2
{
    partial class frmQuanLySanPham
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
            this.lblMaMH = new System.Windows.Forms.Label();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblSoTiet = new System.Windows.Forms.Label();
            this.dgvQLSP = new System.Windows.Forms.DataGridView();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(44, 40);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(80, 16);
            this.lblMaMH.TabIndex = 0;
            this.lblMaMH.Text = "Mã môn học";
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Location = new System.Drawing.Point(44, 87);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(85, 16);
            this.lblTenMH.TabIndex = 0;
            this.lblTenMH.Text = "Tên môn học";
            // 
            // lblSoTiet
            // 
            this.lblSoTiet.AutoSize = true;
            this.lblSoTiet.Location = new System.Drawing.Point(281, 40);
            this.lblSoTiet.Name = "lblSoTiet";
            this.lblSoTiet.Size = new System.Drawing.Size(44, 16);
            this.lblSoTiet.TabIndex = 0;
            this.lblSoTiet.Text = "Số tiết";
            // 
            // dgvQLSP
            // 
            this.dgvQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQLSP.Location = new System.Drawing.Point(0, 161);
            this.dgvQLSP.Name = "dgvQLSP";
            this.dgvQLSP.RowHeadersWidth = 51;
            this.dgvQLSP.RowTemplate.Height = 24;
            this.dgvQLSP.Size = new System.Drawing.Size(677, 289);
            this.dgvQLSP.TabIndex = 1;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(135, 84);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(292, 22);
            this.txtTenMH.TabIndex = 2;
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Location = new System.Drawing.Point(341, 37);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(86, 22);
            this.txtSoTiet.TabIndex = 3;
            // 
            // cboMaMH
            // 
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Location = new System.Drawing.Point(135, 37);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(121, 24);
            this.cboMaMH.TabIndex = 4;
            this.cboMaMH.SelectedIndexChanged += new System.EventHandler(this.cboMaMH_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(475, 40);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 66);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cboMaMH);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.dgvQLSP);
            this.Controls.Add(this.lblTenMH);
            this.Controls.Add(this.lblSoTiet);
            this.Controls.Add(this.lblMaMH);
            this.Name = "frmQuanLySanPham";
            this.Text = "QuanLySanPham";
            this.Load += new System.EventHandler(this.frmQuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblSoTiet;
        private System.Windows.Forms.DataGridView dgvQLSP;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.ComboBox cboMaMH;
        private System.Windows.Forms.Button btnThoat;
    }
}

