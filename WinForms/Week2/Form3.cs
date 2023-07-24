using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    MessageBox.Show("알파벳 A");
                    break;
                case Keys.D0:
                    MessageBox.Show("숫자 0");//알파벳 D 와 숫자 0 입력
                    break;
                case Keys.F1:
                    MessageBox.Show("function 키"); //F1 누름
                    break;
                case Keys.Enter:
                    MessageBox.Show("Enter 키");
                    break;
               
            }
        }
    }
}
