using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week2
{
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "C++ 열심히";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }



        private void bthAddC_Click(object sender, EventArgs e)
        {
            
            TreeNode tnc = new TreeNode("C언어");
            TreeNode treeNodeC1 = new TreeNode("조건문");
            treeNodeC1.Nodes.Add("if");
            treeNodeC1.Nodes.Add("if else");
            treeNodeC1.Nodes.Add("if elseif else");


            TreeNode treeNodeC2 = new TreeNode("반복문");
            treeNodeC2.Nodes.Add("for");
            treeNodeC2.Nodes.Add("foreach");
            TreeNode treeLeafC = new TreeNode("while");
            treeLeafC.Nodes.Add("while");
            treeLeafC.Nodes.Add("do while");
            treeNodeC2.Nodes.Add(treeLeafC);

            tnc.Nodes.Add(treeNodeC1);
            tnc.Nodes.Add(treeNodeC2);
            if (treeViewC.Nodes.Count == 0)
            {
                if ((tbNodeC.Text == "") && (treeViewC.SelectedNode == null)) { treeViewC.Nodes.Add(tnc); return; }
                else if ((tbNodeC.Text == "") && (treeViewC.SelectedNode != null)) { MessageBox.Show("텍스트 박스 입력"); return; }
            }
            if (treeViewC.SelectedNode != null) { treeViewC.SelectedNode.Nodes.Add(tbNodeC.Text); tbNodeC.Text = ""; }
            else { treeViewC.Nodes.Add(tbNodeC.Text); tbNodeC.Text = ""; }
        }

        private void bthDeleteC_Click(object sender, EventArgs e)
        {
            if (treeViewC.SelectedNode != null) { treeViewC.SelectedNode.Remove(); }
        }

        private void btnExC_Click(object sender, EventArgs e)
        {
            treeViewC.ExpandAll();
        }

        private void btnCoC_Click(object sender, EventArgs e)
        {
            treeViewC.CollapseAll();
        }


        private void btnAddCh_Click_1(object sender, EventArgs e)
        {
            TreeNode tnch = new TreeNode("C++");
            TreeNode treeNodeCh1 = new TreeNode("조건문");
            treeNodeCh1.Nodes.Add("if");
            treeNodeCh1.Nodes.Add("if else");
            treeNodeCh1.Nodes.Add("if elseif else");


            TreeNode treeNodeCh2 = new TreeNode("반복문");
            treeNodeCh2.Nodes.Add("for");
            treeNodeCh2.Nodes.Add("foreach");
            TreeNode treeLeafCh = new TreeNode("while");
            treeLeafCh.Nodes.Add("while");
            treeLeafCh.Nodes.Add("do while");
            treeNodeCh2.Nodes.Add(treeLeafCh);

            tnch.Nodes.Add(treeNodeCh1);
            tnch.Nodes.Add(treeNodeCh2);
            if (treeViewCh.Nodes.Count == 0)
            {
                if ((tbNodeCh.Text == "") && (treeViewCh.SelectedNode == null)) { treeViewCh.Nodes.Add(tnch); return; }
                else if ((tbNodeCh.Text == "") && (treeViewCh.SelectedNode != null)) { MessageBox.Show("텍스트 박스 입력"); return; }
            }
            if (treeViewCh.SelectedNode != null) { treeViewCh.SelectedNode.Nodes.Add(tbNodeCh.Text); tbNodeCh.Text = ""; }
            else { treeViewCh.Nodes.Add(tbNodeCh.Text); tbNodeCh.Text = ""; }
        }

        private void btnDeleteCh_Click_1(object sender, EventArgs e)
        {
            if (treeViewCh.SelectedNode != null) { treeViewCh.SelectedNode.Remove(); }
        }

        private void btnExCh_Click_1(object sender, EventArgs e)
        {
            treeViewCh.ExpandAll();
        }

        private void btnCaCh_Click(object sender, EventArgs e)
        {
            treeViewCh.CollapseAll();
        }
    }
}
