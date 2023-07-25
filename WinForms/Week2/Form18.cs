using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void radioC_CheckedChanged(object sender, EventArgs e)
        {
            if(radioC.Checked = true) { radioD.Checked = false; pictureBox2.Image = pictureBox1.Image; }
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioD.Checked = true) { radioC.Checked = false; pictureBox2.Image =null; }
        }
    }
}
