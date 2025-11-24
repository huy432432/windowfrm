namespace bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inA = new System.Windows.Forms.TextBox();
            this.inB = new System.Windows.Forms.TextBox();
            this.OUTAB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nhan = new System.Windows.Forms.CheckBox();
            this.chia = new System.Windows.Forms.CheckBox();
            this.tru = new System.Windows.Forms.CheckBox();
            this.cong = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kết quả:";
            // 
            // inA
            // 
            this.inA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inA.Location = new System.Drawing.Point(141, 44);
            this.inA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inA.Name = "inA";
            this.inA.Size = new System.Drawing.Size(341, 26);
            this.inA.TabIndex = 6;
            // 
            // inB
            // 
            this.inB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inB.Location = new System.Drawing.Point(141, 93);
            this.inB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inB.Name = "inB";
            this.inB.Size = new System.Drawing.Size(341, 26);
            this.inB.TabIndex = 7;
            // 
            // OUTAB
            // 
            this.OUTAB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUTAB.Location = new System.Drawing.Point(141, 247);
            this.OUTAB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OUTAB.Name = "OUTAB";
            this.OUTAB.Size = new System.Drawing.Size(341, 26);
            this.OUTAB.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nhan);
            this.groupBox1.Controls.Add(this.chia);
            this.groupBox1.Controls.Add(this.tru);
            this.groupBox1.Controls.Add(this.cong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(404, 102);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép Tính";
            // 
            // nhan
            // 
            this.nhan.AutoSize = true;
            this.nhan.Location = new System.Drawing.Point(198, 41);
            this.nhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(64, 23);
            this.nhan.TabIndex = 3;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.CheckedChanged += new System.EventHandler(this.nhan_CheckedChanged);
            // 
            // chia
            // 
            this.chia.AutoSize = true;
            this.chia.Location = new System.Drawing.Point(317, 41);
            this.chia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(59, 23);
            this.chia.TabIndex = 2;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            this.chia.CheckedChanged += new System.EventHandler(this.chia_CheckedChanged);
            // 
            // tru
            // 
            this.tru.AutoSize = true;
            this.tru.Location = new System.Drawing.Point(101, 41);
            this.tru.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(53, 23);
            this.tru.TabIndex = 1;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            this.tru.CheckedChanged += new System.EventHandler(this.tru_CheckedChanged);
            // 
            // cong
            // 
            this.cong.AutoSize = true;
            this.cong.Location = new System.Drawing.Point(4, 41);
            this.cong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(63, 23);
            this.cong.TabIndex = 0;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.CheckedChanged += new System.EventHandler(this.cong_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OUTAB);
            this.Controls.Add(this.inB);
            this.Controls.Add(this.inA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inA;
        private System.Windows.Forms.TextBox inB;
        private System.Windows.Forms.TextBox OUTAB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox nhan;
        private System.Windows.Forms.CheckBox chia;
        private System.Windows.Forms.CheckBox tru;
        private System.Windows.Forms.CheckBox cong;
    }
}

