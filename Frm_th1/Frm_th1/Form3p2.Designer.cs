namespace bai10_b3
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.btnSangPhai = new System.Windows.Forms.Button();
            this.btnSangPhaiHet = new System.Windows.Forms.Button();
            this.btnSangTrai = new System.Windows.Forms.Button();
            this.btnSangTraiHet = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(180, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(113, 67);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(300, 20);
            this.txtHoTen.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(520, 65);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 23);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLopA);
            this.groupBox1.Location = new System.Drawing.Point(40, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 250);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.Location = new System.Drawing.Point(6, 19);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.Size = new System.Drawing.Size(228, 225);
            this.lstLopA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLopB);
            this.groupBox2.Location = new System.Drawing.Point(410, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 250);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.Location = new System.Drawing.Point(6, 19);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.Size = new System.Drawing.Size(228, 225);
            this.lstLopB.TabIndex = 0;
            // 
            // btnSangPhai
            // 
            this.btnSangPhai.Location = new System.Drawing.Point(305, 160);
            this.btnSangPhai.Name = "btnSangPhai";
            this.btnSangPhai.Size = new System.Drawing.Size(75, 23);
            this.btnSangPhai.TabIndex = 3;
            this.btnSangPhai.Text = ">";
            this.btnSangPhai.UseVisualStyleBackColor = true;
            this.btnSangPhai.Click += new System.EventHandler(this.btnSangPhai_Click);
            // 
            // btnSangPhaiHet
            // 
            this.btnSangPhaiHet.Location = new System.Drawing.Point(305, 190);
            this.btnSangPhaiHet.Name = "btnSangPhaiHet";
            this.btnSangPhaiHet.Size = new System.Drawing.Size(75, 23);
            this.btnSangPhaiHet.TabIndex = 4;
            this.btnSangPhaiHet.Text = ">>";
            this.btnSangPhaiHet.UseVisualStyleBackColor = true;
            this.btnSangPhaiHet.Click += new System.EventHandler(this.btnSangPhaiHet_Click);
            // 
            // btnSangTrai
            // 
            this.btnSangTrai.Location = new System.Drawing.Point(305, 220);
            this.btnSangTrai.Name = "btnSangTrai";
            this.btnSangTrai.Size = new System.Drawing.Size(75, 23);
            this.btnSangTrai.TabIndex = 5;
            this.btnSangTrai.Text = "<";
            this.btnSangTrai.UseVisualStyleBackColor = true;
            this.btnSangTrai.Click += new System.EventHandler(this.btnSangTrai_Click);
            // 
            // btnSangTraiHet
            // 
            this.btnSangTraiHet.Location = new System.Drawing.Point(305, 250);
            this.btnSangTraiHet.Name = "btnSangTraiHet";
            this.btnSangTraiHet.Size = new System.Drawing.Size(75, 23);
            this.btnSangTraiHet.TabIndex = 6;
            this.btnSangTraiHet.Text = "<<";
            this.btnSangTraiHet.UseVisualStyleBackColor = true;
            this.btnSangTraiHet.Click += new System.EventHandler(this.btnSangTraiHet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(100, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(480, 380);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(100, 30);
            this.btnKetThuc.TabIndex = 8;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(450, 66);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(64, 21);
            this.cboLop.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSangTraiHet);
            this.Controls.Add(this.btnSangTrai);
            this.Controls.Add(this.btnSangPhaiHet);
            this.Controls.Add(this.btnSangPhai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "frmListSV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstLopB;
        private System.Windows.Forms.Button btnSangPhai;
        private System.Windows.Forms.Button btnSangPhaiHet;
        private System.Windows.Forms.Button btnSangTrai;
        private System.Windows.Forms.Button btnSangTraiHet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLop;
    }
}