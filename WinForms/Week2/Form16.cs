using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbNode.Text == "") { MessageBox.Show("텍스트 박스 입력"); return; }
            if(treeView1.SelectedNode != null) { treeView1.SelectedNode.Nodes.Add(tbNode.Text); tbNode.Text = ""; }
            else { treeView1.Nodes.Add(tbNode.Text); tbNode.Text = ""; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null) { treeView1.SelectedNode.Remove(); }
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
