namespace Bai5
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
            this.inText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnblack = new System.Windows.Forms.RadioButton();
            this.btnblue = new System.Windows.Forms.RadioButton();
            this.btnGreen = new System.Windows.Forms.RadioButton();
            this.btnred = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gachchan = new System.Windows.Forms.CheckBox();
            this.Nghiengitalic = new System.Windows.Forms.CheckBox();
            this.Dambold = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outtext = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên :";
            // 
            // inText
            // 
            this.inText.Location = new System.Drawing.Point(150, 30);
            this.inText.Margin = new System.Windows.Forms.Padding(2);
            this.inText.Name = "inText";
            this.inText.Size = new System.Drawing.Size(68, 20);
            this.inText.TabIndex = 1;
            this.inText.TextChanged += new System.EventHandler(this.inText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnblack);
            this.groupBox1.Controls.Add(this.btnblue);
            this.groupBox1.Controls.Add(this.btnGreen);
            this.groupBox1.Controls.Add(this.btnred);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "color";
            // 
            // btnblack
            // 
            this.btnblack.AutoSize = true;
            this.btnblack.Location = new System.Drawing.Point(16, 118);
            this.btnblack.Name = "btnblack";
            this.btnblack.Size = new System.Drawing.Size(66, 24);
            this.btnblack.TabIndex = 5;
            this.btnblack.TabStop = true;
            this.btnblack.Text = "Black";
            this.btnblack.UseVisualStyleBackColor = true;
            this.btnblack.CheckedChanged += new System.EventHandler(this.btnblack_CheckedChanged);
            // 
            // btnblue
            // 
            this.btnblue.AutoSize = true;
            this.btnblue.ForeColor = System.Drawing.Color.Blue;
            this.btnblue.Location = new System.Drawing.Point(16, 87);
            this.btnblue.Name = "btnblue";
            this.btnblue.Size = new System.Drawing.Size(59, 24);
            this.btnblue.TabIndex = 4;
            this.btnblue.TabStop = true;
            this.btnblue.Text = "Blue";
            this.btnblue.UseVisualStyleBackColor = true;
            this.btnblue.CheckedChanged += new System.EventHandler(this.btnblue_CheckedChanged);
            // 
            // btnGreen
            // 
            this.btnGreen.AutoSize = true;
            this.btnGreen.ForeColor = System.Drawing.Color.Lime;
            this.btnGreen.Location = new System.Drawing.Point(16, 57);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(72, 24);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.TabStop = true;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.CheckedChanged += new System.EventHandler(this.btnGreen_CheckedChanged);
            // 
            // btnred
            // 
            this.btnred.AutoSize = true;
            this.btnred.ForeColor = System.Drawing.Color.Red;
            this.btnred.Location = new System.Drawing.Point(16, 26);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(57, 24);
            this.btnred.TabIndex = 0;
            this.btnred.TabStop = true;
            this.btnred.Text = "Red";
            this.btnred.UseVisualStyleBackColor = true;
            this.btnred.CheckedChanged += new System.EventHandler(this.btnred_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gachchan);
            this.groupBox2.Controls.Add(this.Nghiengitalic);
            this.groupBox2.Controls.Add(this.Dambold);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(237, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 173);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "font";
            // 
            // gachchan
            // 
            this.gachchan.AutoSize = true;
            this.gachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gachchan.ForeColor = System.Drawing.Color.Navy;
            this.gachchan.Location = new System.Drawing.Point(20, 102);
            this.gachchan.Name = "gachchan";
            this.gachchan.Size = new System.Drawing.Size(106, 24);
            this.gachchan.TabIndex = 2;
            this.gachchan.Text = "Gạch chân";
            this.gachchan.UseVisualStyleBackColor = true;
            this.gachchan.CheckedChanged += new System.EventHandler(this.gachchan_CheckedChanged);
            // 
            // Nghiengitalic
            // 
            this.Nghiengitalic.AutoSize = true;
            this.Nghiengitalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nghiengitalic.ForeColor = System.Drawing.Color.Navy;
            this.Nghiengitalic.Location = new System.Drawing.Point(20, 62);
            this.Nghiengitalic.Name = "Nghiengitalic";
            this.Nghiengitalic.Size = new System.Drawing.Size(122, 24);
            this.Nghiengitalic.TabIndex = 1;
            this.Nghiengitalic.Text = "Nghiêng italic";
            this.Nghiengitalic.UseVisualStyleBackColor = true;
            this.Nghiengitalic.CheckedChanged += new System.EventHandler(this.Nghiengitalic_CheckedChanged);
            // 
            // Dambold
            // 
            this.Dambold.AutoSize = true;
            this.Dambold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dambold.ForeColor = System.Drawing.Color.Navy;
            this.Dambold.Location = new System.Drawing.Point(20, 32);
            this.Dambold.Name = "Dambold";
            this.Dambold.Size = new System.Drawing.Size(104, 24);
            this.Dambold.TabIndex = 0;
            this.Dambold.Text = "Đậm bold";
            this.Dambold.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lập trình bởi:";
            // 
            // outtext
            // 
            this.outtext.Location = new System.Drawing.Point(161, 338);
            this.outtext.Name = "outtext";
            this.outtext.Size = new System.Drawing.Size(166, 20);
            this.outtext.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 432);
            this.Controls.Add(this.outtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Định dạng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnGreen;
        private System.Windows.Forms.RadioButton btnred;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnblack;
        private System.Windows.Forms.RadioButton btnblue;
        private System.Windows.Forms.CheckBox gachchan;
        private System.Windows.Forms.CheckBox Nghiengitalic;
        private System.Windows.Forms.CheckBox Dambold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outtext;
    }
}

