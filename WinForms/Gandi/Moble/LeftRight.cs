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
    public partial class LeftRight : Form
    {
        public LeftRight()
        {
            InitializeComponent();
            labelProgressBar1.CustomText = "20.0";
        }
        int count = 0;
        private int score = 0; // 점수
        private int realNum = 0; // 해당 숫자
        private string mode = ""; // 모드 문자
        Random rand = new Random(); // 랜덤

        private void UIR() // 모드 선택시 실행되는 랜덤사진 함수
        {
            if (mode == "Easy") // 이지 선택시 랜덤 이미지의 값은 0, 1
            {
                int num = rand.Next(0, 2);
                if (num == 0) { btnI1.Image = imageList2.Images[0]; realNum = 1; }
                else if (num == 1) { btnI1.Image = imageList2.Images[1]; realNum = 2; }
            }
            else if (mode == "Hard") // 하드 선택시 랜덤 이미지의 값은 0, 1, 2, 3, 4
            {
                int num = rand.Next(0, 4);
                if (num == 0) { btnI1.Image = imageList2.Images[0]; realNum = 1; }
                else if (num == 1) { btnI1.Image = imageList2.Images[1]; realNum = 2; }
                else if (num == 2) { btnI1.Image = imageList2.Images[2]; realNum = 3; }
                else if (num == 3) { btnI1.Image = imageList2.Images[3]; realNum = 4; }
            }
        }
        private void Clear() // 초기화
        {
            mode = "";
            score = 0; lbScore.Text = score.ToString();
            labelProgressBar1.Value = 200;
            labelProgressBar1.TextColor = Color.Black;
            labelProgressBar1.CustomText = "20.0";
        }

        private void timer1_Tick(object sender, EventArgs e) // 시작시 프로그래스바 타이머
        {
            lbScore.Text = score.ToString();

            labelProgressBar1.Value--;
            if (double.Parse(labelProgressBar1.CustomText) > 10.0)
            {
                labelProgressBar1.CustomText = string.Format("{0:f1}",
                double.Parse(labelProgressBar1.CustomText) - 0.1);
            }
            else
            {
                labelProgressBar1.TextColor = Color.White;
                labelProgressBar1.CustomText = string.Format("{0:f1}",
                double.Parse(labelProgressBar1.CustomText) - 0.1);
            }

            if (labelProgressBar1.Value == 0) // 20초 끝나면 
            {
                timer3.Stop();
                timer1.Stop();
                MessageBox.Show(($"{mode}모드 게임이 끝났습니다.\n당신의 점수는 {score}점 입니다."), " 알림"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (rbEasy.Checked == true) { rbEasy.Checked = false; } // 모드 라디오 버튼 초기화
                else if (rbHard.Checked == true) { rbHard.Checked = false; }
                Clear();
            }
            else { timer3.Start(); }
        }
        private void timer2_Tick(object sender, EventArgs e) // 타이머 시작전 카운트 시작
        {
            if (lb_Sec.Visible == false) { lb_Sec.Visible = true; lb_Sec.Location = new Point(195, 197); lb_Sec.Text = "4"; }
            if (lb_Sec.Text == "4") { lb_Sec.Text = "3"; }
            if (lb_Sec.Text == "3") { lb_Sec.Text = "2"; }
            else if (lb_Sec.Text == "2") { lb_Sec.Text = "1"; }
            else if (lb_Sec.Text == "1") { lb_Sec.Location = new Point(100, 200); lb_Sec.Text = "START"; }
            else
            {
                lb_Sec.Visible = false;
                timer2.Stop();
                timer1.Start();
            }
        }
        private void timer3_Tick(object sender, EventArgs e) { UIR(); } // 랜덤 사진 조정 타이머
        private void btnStart_Click(object sender, EventArgs e) // 시작버튼 클릭시
        {
            Clear();
            if (rbEasy.Checked == true) // 이지모드
            {
                btnUL.Enabled = false; btnUL.Visible = false;
                btnUR.Enabled = false; btnUR.Visible = false;
                mode = "Easy";
                MessageBox.Show("이지모드 시작합니다.");
                //UIR();
                btnI1.Image = imageList2.Images[4];
                timer2.Start();
            }
            else if (rbHard.Checked == true) // 하드모드
            {
                btnUL.Enabled = true; btnUL.Visible = true;
                btnUR.Enabled = true; btnUR.Visible = true;
                mode = "Hard";
                MessageBox.Show("하드모드 시작합니다.");
                //UIR();
                btnI1.Image = imageList2.Images[4];
                timer2.Start();
            }
            else MessageBox.Show("모드를 선택해주세요.");
        }
        private void btnL_Click(object sender, EventArgs e) // 왼쪽1 버튼
        {
            int L = 1;
            if (L == realNum) { score += 10; btnI1.Image = imageList2.Images[4]; }
            else { score -= 5; MessageBox.Show("틀렸습니다.", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnR_Click(object sender, EventArgs e) // 오른쪽1 버튼
        {
            int R = 2;
            if (R == realNum) { score += 10; btnI1.Image = imageList2.Images[4]; }
            else { score -= 5; MessageBox.Show("틀렸습니다.", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUL_Click(object sender, EventArgs e) // 하드 - 왼쪽2 버튼
        {
            if (mode == "Easy") { }
            else if (mode == "Hard")
            {
                int R = 3;
                if (R == realNum) { score += 10; btnI1.Image = imageList2.Images[4]; }
                else { score -= 5; MessageBox.Show("틀렸습니다.", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnUR_Click(object sender, EventArgs e) // 하드 - 오른쪽2 버튼
        {
            if (mode == "Easy") { }
            else if (mode == "Hard")
            {
                int R = 4;
                if (R == realNum) { score += 10; btnI1.Image = imageList2.Images[4]; }
                else { score -= 5; MessageBox.Show("틀렸습니다.", " 경고", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
    }
}
