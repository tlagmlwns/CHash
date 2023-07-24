using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string str = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = str;
            if (textBox1.Text == "")
                label1.Text = null;

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            str += e.KeyChar;
            if (label1.Text == "")
                textBox1.Text = null;
            
        }


    }
}
