namespace BT4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalStudents = new System.Windows.Forms.TextBox();
            this.txtHomeroomTeacher = new System.Windows.Forms.TextBox();
            this.cboClassNo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Homeroom Teacher";
            // 
            // txtTotalStudents
            // 
            this.txtTotalStudents.Location = new System.Drawing.Point(144, 84);
            this.txtTotalStudents.Name = "txtTotalStudents";
            this.txtTotalStudents.Size = new System.Drawing.Size(180, 22);
            this.txtTotalStudents.TabIndex = 1;
            // 
            // txtHomeroomTeacher
            // 
            this.txtHomeroomTeacher.Location = new System.Drawing.Point(536, 29);
            this.txtHomeroomTeacher.Name = "txtHomeroomTeacher";
            this.txtHomeroomTeacher.Size = new System.Drawing.Size(180, 22);
            this.txtHomeroomTeacher.TabIndex = 1;
            // 
            // cboClassNo
            // 
            this.cboClassNo.FormattingEnabled = true;
            this.cboClassNo.Location = new System.Drawing.Point(144, 29);
            this.cboClassNo.Name = "cboClassNo";
            this.cboClassNo.Size = new System.Drawing.Size(180, 24);
            this.cboClassNo.TabIndex = 2;
            this.cboClassNo.SelectedIndexChanged += new System.EventHandler(this.cboClassNo_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(48, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StudentDetails";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(24, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(668, 228);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboClassNo);
            this.Controls.Add(this.txtHomeroomTeacher);
            this.Controls.Add(this.txtTotalStudents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalStudents;
        private System.Windows.Forms.TextBox txtHomeroomTeacher;
        private System.Windows.Forms.ComboBox cboClassNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

