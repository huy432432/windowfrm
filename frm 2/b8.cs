using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT8
{
    public partial class b8 : Form
    {
        public b8()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Thông tin sinh viên không được để trống.", "Lỗi");
                return;
            }

            TreeNode selectedNode = tvDSL.SelectedNode;

            if (selectedNode != null && selectedNode.Parent != null)
            {
                if (selectedNode.Parent.Text == "Danh sách lớp")
                {
                    bool isStudentExist = false;
                    foreach (TreeNode child in selectedNode.Nodes)
                    {
                        if (child.Text.Contains(txtMaSV.Text)) 
                        {
                            isStudentExist = true;
                            break;
                        }
                    }

                    if (isStudentExist)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại trong lớp.", "Lỗi");
                        return;
                    }

                    // Thêm sinh viên mới vào lớp
                    TreeNode newStudentNode = new TreeNode(txtMaSV.Text + " - " + txtHoTen.Text);
                    selectedNode.Nodes.Add(newStudentNode);
                    MessageBox.Show("Sinh viên đã được thêm vào lớp.", "Thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn lớp để thêm sinh viên.", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp để thêm sinh viên.", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tvDSL.SelectedNode;

            if (selectedNode != null && selectedNode.Parent != null && selectedNode.Parent.Text != "Danh sách lớp")
            {
                var XacNhanXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XacNhanXoa == DialogResult.Yes)
                {
                    selectedNode.Remove();
                    MessageBox.Show("Sinh viên đã bị xóa.", "Thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Lỗi");
            }
        }

        private void tvDSL_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode.Parent != null && selectedNode.Parent.Text != "Danh sách lớp")
            {
                string[] studentInfo = selectedNode.Text.Split('-');
                if (studentInfo.Length == 2)
                {
                    txtMaSV.Text = studentInfo[0].Trim();
                    txtHoTen.Text = studentInfo[1].Trim();
                    txtDiaChi.Text = ""; 
                }
            }
        }
    }
}
