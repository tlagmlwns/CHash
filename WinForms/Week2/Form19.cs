using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Paint(object sender, PaintEventArgs e)
        {
            imageList1.Draw(e.Graphics, 20, 0, 0);
            imageList1.Draw(e.Graphics, 220, 0, 1);
            imageList1.Draw(e.Graphics, 420, 0, 2);
            imageList1.Draw(e.Graphics, 220, 200, 3);
            imageList1.Draw(e.Graphics, 420, 200, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "피곤해요";
            label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "심심해요";
            label1.Text = "";
        }
    }
}
