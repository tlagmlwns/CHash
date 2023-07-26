using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class ModalForm : Form
    {
        public ModalForm()
        {
            InitializeComponent();
        }

        private void 모달열기ToolStripMenu_Click(object sender, EventArgs e)
        {
            ModalForm m1 = new ModalForm();
            //m1.ShowDialog();
            //m1.Dispose();
            DialogResult result = m1.ShowDialog();
            if (result == DialogResult.OK) MessageBox.Show("OK버튼");
            else if (result == DialogResult.Yes) MessageBox.Show("Yes버튼");
            else if (result == DialogResult.No) MessageBox.Show("No버튼");
            m1.Dispose();
        }

        private void 닫기ToolStripMenu_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btn5k_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
