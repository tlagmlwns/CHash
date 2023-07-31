using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int score = 0;
        private string str = "";
        private Random rand = new Random();
        LabelProgressBar progressBar = new LabelProgressBar();
        private void UIR()
        {
            int num = rand.Next(2);
            if (num == 0) { btnImage.Image = imageList1.Images[0]; str = "Left"; }
            else { btnImage.Image = imageList1.Images[1]; str = "Right"; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbScore.Text = score.ToString();
            
            progressBar1.Value++;
            if (progressBar1.Value == 20)
            {
                timer1.Stop();
                MessageBox.Show($"게임이 끝났습니다.\n당신의 점수는 {score}점 입니다.");
            }
            else
            {
                UIR();
                textBox1.Text = (20 - (progressBar1.Value)).ToString(); //프로그래스바 텍스트 추가
            }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            score = 0; lbScore.Text = score.ToString();
            textBox1.Text = "20";
            progressBar1.Value = 0;
            UIR();
            timer1.Start();
        }
        private void btnL_Click(object sender, EventArgs e)
        {
            if (btnL.Text == str) { score += 10; btnImage.Image = null; }
            else { score -= 5; MessageBox.Show("틀림 ㅋㅋ", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (btnR.Text == str) { score += 10; btnImage.Image = null; }
            else { score -= 5; MessageBox.Show("틀림 ㅋㅋ", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }

}
