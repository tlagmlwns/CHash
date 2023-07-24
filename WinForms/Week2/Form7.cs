using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class btn_Test : Form
    {
        public btn_Test()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MessageBox.Show("왼쪽 클릭");
            if (e.Button == MouseButtons.Right)
                MessageBox.Show("오른쪽 클릭");
        }
    }
}
