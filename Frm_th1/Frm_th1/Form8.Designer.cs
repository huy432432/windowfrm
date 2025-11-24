namespace Frm_th1
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nhapA = new System.Windows.Forms.TextBox();
            this.txt_NhapB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nghiem = new System.Windows.Forms.TextBox();
            this.btn_Giai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(78, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT Ax + B = 0";
            this.label1.Click += new System.EventHandler(this.Gi);
            // 
            // txt_nhapA
            // 
            this.txt_nhapA.Location = new System.Drawing.Point(273, 131);
            this.txt_nhapA.Name = "txt_nhapA";
            this.txt_nhapA.Size = new System.Drawing.Size(301, 22);
            this.txt_nhapA.TabIndex = 1;
            this.txt_nhapA.TextChanged += new System.EventHandler(this.txt_nhapA_TextChanged);
            // 
            // txt_NhapB
            // 
            this.txt_NhapB.Location = new System.Drawing.Point(273, 176);
            this.txt_NhapB.Name = "txt_NhapB";
            this.txt_NhapB.Size = new System.Drawing.Size(301, 22);
            this.txt_NhapB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhap A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhap B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nghiem cua phuong trinh";
            // 
            // txt_nghiem
            // 
            this.txt_nghiem.Location = new System.Drawing.Point(273, 220);
            this.txt_nghiem.Name = "txt_nghiem";
            this.txt_nghiem.Size = new System.Drawing.Size(301, 22);
            this.txt_nghiem.TabIndex = 6;
            // 
            // btn_Giai
            // 
            this.btn_Giai.Enabled = false;
            this.btn_Giai.Location = new System.Drawing.Point(171, 294);
            this.btn_Giai.Name = "btn_Giai";
            this.btn_Giai.Size = new System.Drawing.Size(75, 23);
            this.btn_Giai.TabIndex = 7;
            this.btn_Giai.Text = "Giai";
            this.btn_Giai.UseVisualStyleBackColor = true;
            this.btn_Giai.Click += new System.EventHandler(this.btn_Giai_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Location = new System.Drawing.Point(319, 293);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(486, 293);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "thoat";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_Giai);
            this.Controls.Add(this.txt_nghiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NhapB);
            this.Controls.Add(this.txt_nhapA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giải pt bậc 1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nhapA;
        private System.Windows.Forms.TextBox txt_NhapB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nghiem;
        private System.Windows.Forms.Button btn_Giai;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

