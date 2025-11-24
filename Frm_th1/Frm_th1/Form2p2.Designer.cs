namespace Bai9
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_odd = new System.Windows.Forms.Button();
            this.btn_even = new System.Windows.Forms.Button();
            this.btn_sqr = new System.Windows.Forms.Button();
            this.btn_plus2 = new System.Windows.Forms.Button();
            this.btn_rmv_start_end = new System.Windows.Forms.Button();
            this.btn_tong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhsach = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.inNhap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_stop);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(559, 509);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(188, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTBOX";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(31, 372);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(470, 32);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Kết thúc";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_odd);
            this.groupBox2.Controls.Add(this.btn_even);
            this.groupBox2.Controls.Add(this.btn_sqr);
            this.groupBox2.Controls.Add(this.btn_plus2);
            this.groupBox2.Controls.Add(this.btn_rmv_start_end);
            this.groupBox2.Controls.Add(this.btn_tong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(278, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 319);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lý ListBox";
            // 
            // btn_odd
            // 
            this.btn_odd.Location = new System.Drawing.Point(0, 220);
            this.btn_odd.Name = "btn_odd";
            this.btn_odd.Size = new System.Drawing.Size(217, 32);
            this.btn_odd.TabIndex = 7;
            this.btn_odd.Text = "chọn số lẻ";
            this.btn_odd.UseVisualStyleBackColor = true;
            this.btn_odd.Click += new System.EventHandler(this.btn_odd_Click);
            // 
            // btn_even
            // 
            this.btn_even.Location = new System.Drawing.Point(0, 182);
            this.btn_even.Name = "btn_even";
            this.btn_even.Size = new System.Drawing.Size(217, 32);
            this.btn_even.TabIndex = 6;
            this.btn_even.Text = "chọn số chẵn";
            this.btn_even.UseVisualStyleBackColor = true;
            this.btn_even.Click += new System.EventHandler(this.btn_even_Click);
            // 
            // btn_sqr
            // 
            this.btn_sqr.Location = new System.Drawing.Point(6, 144);
            this.btn_sqr.Name = "btn_sqr";
            this.btn_sqr.Size = new System.Drawing.Size(217, 32);
            this.btn_sqr.TabIndex = 5;
            this.btn_sqr.Text = "thay bằng bình phương";
            this.btn_sqr.UseVisualStyleBackColor = true;
            this.btn_sqr.Click += new System.EventHandler(this.btn_sqr_Click);
            // 
            // btn_plus2
            // 
            this.btn_plus2.Location = new System.Drawing.Point(6, 106);
            this.btn_plus2.Name = "btn_plus2";
            this.btn_plus2.Size = new System.Drawing.Size(217, 32);
            this.btn_plus2.TabIndex = 4;
            this.btn_plus2.Text = "Tăng mỗi phần tử lên 2";
            this.btn_plus2.UseVisualStyleBackColor = true;
            this.btn_plus2.Click += new System.EventHandler(this.btn_plus2_Click);
            // 
            // btn_rmv_start_end
            // 
            this.btn_rmv_start_end.Location = new System.Drawing.Point(6, 68);
            this.btn_rmv_start_end.Name = "btn_rmv_start_end";
            this.btn_rmv_start_end.Size = new System.Drawing.Size(217, 32);
            this.btn_rmv_start_end.TabIndex = 3;
            this.btn_rmv_start_end.Text = "Xóa phần tử đầu và cuối";
            this.btn_rmv_start_end.UseVisualStyleBackColor = true;
            this.btn_rmv_start_end.Click += new System.EventHandler(this.btn_rmv_start_end_Click);
            // 
            // btn_tong
            // 
            this.btn_tong.Location = new System.Drawing.Point(6, 30);
            this.btn_tong.Name = "btn_tong";
            this.btn_tong.Size = new System.Drawing.Size(217, 32);
            this.btn_tong.TabIndex = 2;
            this.btn_tong.Text = "Tổng các phần tử trong List";
            this.btn_tong.UseVisualStyleBackColor = true;
            this.btn_tong.Click += new System.EventHandler(this.btn_tong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.danhsach);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.inNhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(35, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 319);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ListBox";
            // 
            // danhsach
            // 
            this.danhsach.FormattingEnabled = true;
            this.danhsach.ItemHeight = 20;
            this.danhsach.Location = new System.Drawing.Point(7, 117);
            this.danhsach.Name = "danhsach";
            this.danhsach.Size = new System.Drawing.Size(175, 184);
            this.danhsach.TabIndex = 2;
            this.danhsach.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(7, 78);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(186, 32);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "&Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // inNhap
            // 
            this.inNhap.Location = new System.Drawing.Point(7, 36);
            this.inNhap.Name = "inNhap";
            this.inNhap.Size = new System.Drawing.Size(186, 26);
            this.inNhap.TabIndex = 0;
            this.inNhap.TextChanged += new System.EventHandler(this.inNhap_TextChanged);
            this.inNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inNhap_KeyPress);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 509);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "frmListBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_odd;
        private System.Windows.Forms.Button btn_even;
        private System.Windows.Forms.Button btn_sqr;
        private System.Windows.Forms.Button btn_plus2;
        private System.Windows.Forms.Button btn_rmv_start_end;
        private System.Windows.Forms.Button btn_tong;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox inNhap;
        private System.Windows.Forms.ListBox danhsach;
    }
}

