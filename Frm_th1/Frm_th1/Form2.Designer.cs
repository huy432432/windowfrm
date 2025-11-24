namespace Frm_th1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grp_chonkieuchu = new System.Windows.Forms.GroupBox();
            this.rad_chuthuong = new System.Windows.Forms.RadioButton();
            this.rad_chuhoa = new System.Windows.Forms.RadioButton();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ketqua = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grp_chonkieuchu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Họ và Tên:  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 22);
            this.textBox1.TabIndex = 1;
            // 
            // grp_chonkieuchu
            // 
            this.grp_chonkieuchu.Controls.Add(this.rad_chuhoa);
            this.grp_chonkieuchu.Controls.Add(this.rad_chuthuong);
            this.grp_chonkieuchu.Location = new System.Drawing.Point(27, 91);
            this.grp_chonkieuchu.Name = "grp_chonkieuchu";
            this.grp_chonkieuchu.Size = new System.Drawing.Size(338, 100);
            this.grp_chonkieuchu.TabIndex = 2;
            this.grp_chonkieuchu.TabStop = false;
            this.grp_chonkieuchu.Text = "Chon kieu chu";
            // 
            // rad_chuthuong
            // 
            this.rad_chuthuong.AutoSize = true;
            this.rad_chuthuong.Location = new System.Drawing.Point(27, 33);
            this.rad_chuthuong.Name = "rad_chuthuong";
            this.rad_chuthuong.Size = new System.Drawing.Size(94, 20);
            this.rad_chuthuong.TabIndex = 0;
            this.rad_chuthuong.TabStop = true;
            this.rad_chuthuong.Text = "Chu thuong";
            this.rad_chuthuong.UseVisualStyleBackColor = true;
            // 
            // rad_chuhoa
            // 
            this.rad_chuhoa.AutoSize = true;
            this.rad_chuhoa.Location = new System.Drawing.Point(27, 74);
            this.rad_chuhoa.Name = "rad_chuhoa";
            this.rad_chuhoa.Size = new System.Drawing.Size(77, 20);
            this.rad_chuhoa.TabIndex = 1;
            this.rad_chuhoa.TabStop = true;
            this.rad_chuhoa.Text = "Chu hoa";
            this.rad_chuhoa.UseVisualStyleBackColor = true;
            this.rad_chuhoa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(372, 106);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 85);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xoa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_ketqua
            // 
            this.btn_ketqua.Location = new System.Drawing.Point(36, 218);
            this.btn_ketqua.Name = "btn_ketqua";
            this.btn_ketqua.Size = new System.Drawing.Size(112, 39);
            this.btn_ketqua.TabIndex = 4;
            this.btn_ketqua.Text = "Ket Qua";
            this.btn_ketqua.UseVisualStyleBackColor = true;
            this.btn_ketqua.Click += new System.EventHandler(this.btn_ketqua_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 22);
            this.textBox2.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 291);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_ketqua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grp_chonkieuchu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Đổi kiểu chữ";
            this.grp_chonkieuchu.ResumeLayout(false);
            this.grp_chonkieuchu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grp_chonkieuchu;
        private System.Windows.Forms.RadioButton rad_chuthuong;
        private System.Windows.Forms.RadioButton rad_chuhoa;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_ketqua;
        private System.Windows.Forms.TextBox textBox2;
    }
}