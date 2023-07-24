using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sm
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("KeyDown 모든키");
        }

        private void Form8_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("KeyPress 문자키");
        }
    }
}
