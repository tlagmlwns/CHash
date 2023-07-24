using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.A) && (e.Modifiers == (Keys.Shift | Keys.Control)))
                MessageBox.Show("A + Shift + Crtl");
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
