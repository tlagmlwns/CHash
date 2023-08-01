using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moble
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int score = 0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (ScrollBar.MouseButtons == MouseButtons.Left) { score++; }
            else { score++; }
        }
        private void Clear()
        {
            score = 0;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Clear();
            timer1.Start();
            labelProgressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbScore.Text = score.ToString();
            labelProgressBar1.Value++;
            if (labelProgressBar1.Value == 20)
            {
                timer1.Stop();
                MessageBox.Show(($"게임이 끝났습니다.\n당신의 점수는 {score}점 입니다."), " 알림"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }
    }
}
