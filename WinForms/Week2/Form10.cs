using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public string pw = "qwer1234";
        public int count = 0;
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            string pwProblem = textBox1.Text;
            if (pw == pwProblem) { MessageBox.Show("ㅊㅊ"); Close(); }
            else if (pw != pwProblem)
            {
                MessageBox.Show("다시입력 ㄱㄱ");
                count++;
                if (count == 5)
                {
                    MessageBox.Show("입력을 초과 이제 계정 락임 ㅅ ㄱ");
                    Close();
                }
            }
        }
    }
}
