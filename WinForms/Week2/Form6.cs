using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "(버튼 누름) 좌표 : "+e.Location;
        }

        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "(버튼 놓음) 좌표 : " + e.Location;
        }

        private void Form6_MouseUp(object sender, MouseEventArgs e)
        {
            label2.Text = "(버튼 클릭) 좌표 : " + e.Location;
        }

        private void Form6_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "(버튼 더블 클릭) 좌표 : " + e.Location;
        }

        private void Form6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label3.Text =  e.Location.ToString();
        }
    }
}
