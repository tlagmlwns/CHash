using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void toolStripMenuCa_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void ToolStripMenuPi_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }

  

        private void toolStripMenuCo_Click(object sender, EventArgs e)
        {
            label1.Text = "복사 되었습니다.";
        }

        private void toolStripMenuPa_Click(object sender, EventArgs e)
        {
            label1.Text = "붙여놓기 되었습니다.";
        }

        private void toolStripMenuCu_Click(object sender, EventArgs e)
        {
            label1.Text = "잘라내기 되었습니다.";
        }

        private void frontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) { button1.ForeColor = dlg.Color; }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) { button1.BackColor = dlg.Color; }
        }

        private void toolStripMenuFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK) { button1.Font = dlg.Font; }
        }
    }
}
