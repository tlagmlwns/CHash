using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if(progressBar1.Value == 100) { timer1.Stop(); MessageBox.Show("다운로드 완료!!"); }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnClaer_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            textBox1.Text = "";
        }
    }
}
