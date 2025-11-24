using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void UpdateFontStyle()
        {
            FontStyle style = FontStyle.Regular;
            if (Dambold.Checked) style |= FontStyle.Bold;
            if (Nghiengitalic.Checked) style |= FontStyle.Italic;
            if (gachchan.Checked) style |= FontStyle.Underline;
            outtext.Font = new Font(outtext.Font.FontFamily, outtext.Font.Size,style);
        }

       

        private void inText_TextChanged(object sender, EventArgs e)
        {
            outtext.Text = inText.Text;
        }

        private void btnred_CheckedChanged(object sender, EventArgs e)
        {
            outtext.ForeColor = Color.Red; 
        }

        private void btnGreen_CheckedChanged(object sender, EventArgs e)
        {
            outtext.ForeColor = Color.Green;
        }

        private void btnblue_CheckedChanged(object sender, EventArgs e)
        {
            outtext.ForeColor = Color.Blue;
        }

        private void btnblack_CheckedChanged(object sender, EventArgs e)
        {
            outtext.ForeColor = Color.Black;
        }
        private void Dambold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void Nghiengitalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();

        }

        private void gachchan_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
