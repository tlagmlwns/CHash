using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double scoreC = double.Parse(tbC.Text);
            double scoreCpp = double.Parse(tbCpp.Text);
            double scoreChash = double.Parse(tbChash.Text);
            double average = (scoreC + scoreCpp + scoreChash) / 3;
            //tbaverage.Text = average.ToString();
            tbaverage.Text = string.Format("{0:0.0}", average);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbC.Text = null;
            tbCpp.Text = null;
            tbChash.Text = null;
            tbaverage.Text = null;
        }
    }
}
