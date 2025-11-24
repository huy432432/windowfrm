namespace bai3
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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtso = new System.Windows.Forms.TextBox();
            this.btncapnhap = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntongcacuocso = new System.Windows.Forms.Button();
            this.btnslchan = new System.Windows.Forms.Button();
            this.btnbutton4 = new System.Windows.Forms.Button();
            this.dssouoc = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btncapnhap);
            this.groupBox1.Controls.Add(this.txtso);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(6, 52);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(187, 35);
            this.txtso.TabIndex = 0;
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(199, 42);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(117, 53);
            this.btncapnhap.TabIndex = 1;
            this.btncapnhap.Text = "cập nhập";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 35);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dssouoc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(411, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 183);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "danh sách các ước số";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(244, 356);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(117, 60);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btntongcacuocso
            // 
            this.btntongcacuocso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntongcacuocso.Location = new System.Drawing.Point(462, 230);
            this.btntongcacuocso.Name = "btntongcacuocso";
            this.btntongcacuocso.Size = new System.Drawing.Size(238, 51);
            this.btntongcacuocso.TabIndex = 3;
            this.btntongcacuocso.Text = "Tổng các ước số";
            this.btntongcacuocso.UseVisualStyleBackColor = true;
            this.btntongcacuocso.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnslchan
            // 
            this.btnslchan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnslchan.Location = new System.Drawing.Point(462, 314);
            this.btnslchan.Name = "btnslchan";
            this.btnslchan.Size = new System.Drawing.Size(266, 51);
            this.btnslchan.TabIndex = 4;
            this.btnslchan.Text = "số lượng các số chẵn";
            this.btnslchan.UseVisualStyleBackColor = true;
            this.btnslchan.Click += new System.EventHandler(this.btnslchan_Click);
            // 
            // btnbutton4
            // 
            this.btnbutton4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbutton4.Location = new System.Drawing.Point(417, 383);
            this.btnbutton4.Name = "btnbutton4";
            this.btnbutton4.Size = new System.Drawing.Size(355, 51);
            this.btnbutton4.TabIndex = 5;
            this.btnbutton4.Text = "Số lượng các ước số nguyên tố";
            this.btnbutton4.UseVisualStyleBackColor = true;
            this.btnbutton4.Click += new System.EventHandler(this.btnbutton4_Click);
            // 
            // dssouoc
            // 
            this.dssouoc.FormattingEnabled = true;
            this.dssouoc.ItemHeight = 27;
            this.dssouoc.Location = new System.Drawing.Point(6, 30);
            this.dssouoc.Name = "dssouoc";
            this.dssouoc.Size = new System.Drawing.Size(343, 139);
            this.dssouoc.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 478);
            this.Controls.Add(this.btnbutton4);
            this.Controls.Add(this.btnslchan);
            this.Controls.Add(this.btntongcacuocso);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Combobox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncapnhap;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntongcacuocso;
        private System.Windows.Forms.Button btnslchan;
        private System.Windows.Forms.Button btnbutton4;
        private System.Windows.Forms.ListBox dssouoc;
    }
}

