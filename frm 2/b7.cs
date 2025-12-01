using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT7
{
    public partial class b7 : Form
    {
        public b7()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();

            if (e.Node.Level == 0) //Khoa
            {
                foreach (TreeNode classNode in e.Node.Nodes)
                {
                    foreach (TreeNode studentNode in classNode.Nodes)
                    {
                        ListViewItem item = new ListViewItem(studentNode.Text); 
                        item.SubItems.Add(classNode.Text); 
                        item.SubItems.Add(e.Node.Text); 
                        listView1.Items.Add(item);
                    }
                }
            }
            else if (e.Node.Level == 1) //Lớp
            {
                foreach (TreeNode studentNode in e.Node.Nodes)
                {
                    ListViewItem item = new ListViewItem(studentNode.Text); 
                    item.SubItems.Add(e.Node.Text); 
                    item.SubItems.Add(e.Node.Parent.Text);
                    listView1.Items.Add(item);
                }
            }
            else if (e.Node.Level == 2) //Sinh viên
            {
                ListViewItem item = new ListViewItem(e.Node.Text); 
                item.SubItems.Add(e.Node.Parent.Text); 
                item.SubItems.Add(e.Node.Parent.Parent.Text); 
                listView1.Items.Add(item);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tim = txtHoTen.Text.ToLower();

            listView1.Items.Clear();

            if (treeView1.SelectedNode != null)
            {
                TreeNode selectedNode = treeView1.SelectedNode;

                if (selectedNode.Level == 0) 
                {
                    foreach (TreeNode classNode in selectedNode.Nodes)
                    {
                        foreach (TreeNode studentNode in classNode.Nodes)
                        {
                            if (studentNode.Text.ToLower().Contains(tim))
                            {
                                ListViewItem item = new ListViewItem(studentNode.Text); 
                                item.SubItems.Add(classNode.Text); 
                                item.SubItems.Add(selectedNode.Text); 
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
                else if (selectedNode.Level == 1) 
                {
                    foreach (TreeNode studentNode in selectedNode.Nodes)
                    {
                        if (studentNode.Text.ToLower().Contains(tim))
                        {
                            ListViewItem item = new ListViewItem(studentNode.Text); 
                            item.SubItems.Add(selectedNode.Text);
                            item.SubItems.Add(selectedNode.Parent.Text); 
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
