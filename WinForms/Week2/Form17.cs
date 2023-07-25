using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week2
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode("SLT");
            TreeNode treeNode1 = new TreeNode("관리본부");
            treeNode1.Nodes.Add("인사팀");
            treeNode1.Nodes.Add("총무팀");
            treeNode1.Nodes.Add("회계팀");
            TreeNode treeLeaf = new TreeNode("관리본부");
            treeLeaf.Nodes.Add("인사팀");
            treeLeaf.Nodes.Add("총무팀");
            treeNode1.Nodes.Add(treeLeaf);

            TreeNode treeNode2 = new TreeNode("IT사업부");
            treeNode2.Nodes.Add("AI팀");
            treeNode2.Nodes.Add("IoT팀");

            TreeNode treeNode3 = new TreeNode("연구소");
            treeNode3.Nodes.Add("소프트웨어팀");
            treeNode3.Nodes.Add("하드웨어팀");
            tn.Nodes.Add(treeNode1);
            tn.Nodes.Add(treeNode2);
            tn.Nodes.Add(treeNode3);
            treeView1.Nodes.Add(tn);


            //if (treeView1.SelectedNode != null) treeView1.();
            //else treeView1.Nodes.Add(tn);

        }

        private void bthExpandAll_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null) { treeView1.SelectedNode.Remove(); }
        }
    }
}
