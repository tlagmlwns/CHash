using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            label1.Text = " 새 파일을 만듭니다.";
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            label1.Text = " 파일을 열기.";
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            label1.Text = " 파일을 저장.";
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            label1.Text = "종료";
            
            Application.Exit();
        }
    }
}
