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
        private int realNum = 0;
        private string mode = "";
        Random rand = new Random();
        private void UIR()
        {
            if (mode == "Easy")
            {
                int num = rand.Next(0, 2);
                if (num == 0) { btnI1.Image = imageList1.Images[0]; realNum = 1; }
                else if (num == 1) { btnI1.Image = imageList1.Images[1]; realNum = 2; }
            }
            else if (mode == "Hard")
            {
                int num = rand.Next(0, 4);
                if (num == 0) { btnI1.Image = imageList1.Images[0]; realNum = 1; }
                else if (num == 1) { btnI1.Image = imageList1.Images[1]; realNum = 2; }
                else if (num == 2) { btnI1.Image = imageList1.Images[2]; realNum = 3; }
                else if (num == 3) { btnI1.Image = imageList1.Images[3]; realNum = 4; }
            }
        }
        private void Clear()
        {
            mode = "";
            score = 0; lbScore.Text = score.ToString();
            labelProgressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbScore.Text = score.ToString();
            labelProgressBar1.Value++;
            if (labelProgressBar1.Value == 20)
            {
                timer1.Stop(); 
                MessageBox.Show(($"{mode}모드 게임이 끝났습니다.\n당신의 점수는 {score}점 입니다.")," 알림"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (rbEasy.Checked == true) { rbEasy.Checked = false; }
                else if (rbHard.Checked == true) { rbHard.Checked = false; }
                Clear();
            }
            else { UIR(); }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Clear();
            if (rbEasy.Checked == true)
            {
                btnUL.Enabled = false; btnUL.Visible = false;
                btnUR.Enabled = false; btnUR.Visible = false;
                mode = "Easy";
                MessageBox.Show("이지모드 시작합니다.");
                UIR();
                btnI1.Image = null;
                timer1.Start();
            }
            else if (rbHard.Checked == true)
            {
                btnUL.Enabled = true; btnUL.Visible = true;
                btnUR.Enabled = true; btnUR.Visible = true;
                mode = "Hard";
                MessageBox.Show("하드모드 시작합니다.");
                UIR();
                btnI1.Image = null;
                timer1.Start();
            }
            else MessageBox.Show("모드를 선택해주세요.");
        }
        private void btnL_Click(object sender, EventArgs e)
        {
            int L = 1;
            if (L == realNum) { score += 10; btnI1.Image = null; }
            else { score -= 5; MessageBox.Show("틀렸습니다.", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int R = 2;
            if (R == realNum) { score += 10; btnI1.Image = null; }
            else { score -= 5; MessageBox.Show("틀렸습니다.", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUL_Click(object sender, EventArgs e)
        {
            if (mode == "Easy") { }
            else if (mode == "Hard")
            {
                int R = 3;
                if (R == realNum) { score += 10; btnI1.Image = null; }
                else { score -= 5; MessageBox.Show("틀렸습니다.", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnUR_Click(object sender, EventArgs e)
        {
            if (mode == "Easy") { }
            else if (mode == "Hard")
            {
                int R = 4;
                if (R == realNum) { score += 10; btnI1.Image = null; }
                else { score -= 5; MessageBox.Show("틀렸습니다.", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
