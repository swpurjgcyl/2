using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 电子族谱树状图
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TreeNode a = new TreeNode("新成员");
            a.ImageIndex = 3;
            a.SelectedImageIndex = 3;
            treeView1.SelectedNode.Nodes.Add(a);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TreeNode a = new TreeNode("不知道添加了谁");
            a.ImageIndex = 0;
            a.SelectedImageIndex = 0;
            treeView1.Nodes.Add(a);
        }
    }
}
