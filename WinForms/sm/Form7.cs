using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sm
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void bt_For_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string str = "";

            for (int i = 2; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    str += string.Format($"\t{i} x {j} = {i * j}\n");

            richTextBox1.Text = str;
        }

        private void bt_Foreach_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            string[] strArr = { "ㅂ", "ㅈ", "ㄷ", "ㄱ", "ㅅ", "ㅛ", "ㅕ" };
            int i = 0;
            foreach (var value in strArr)
            {
                i++;
                sb.AppendLine(string.Format($"\t{value} 학생은 {i}반 입니다."));
            }
            richTextBox1.Text = sb.ToString();
        }

        private void bt_While_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            int i = 10;
            while (i > 0) { sb.Append(string.Format("\ti : {0} \n", i--)); }
            richTextBox1.Text = sb.ToString();
        }

        private void bt_doWhile_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            int i = 20;
            do { sb.Append(string.Format($"\ti : {i--}\n")); } while (i > 0);
            richTextBox1.Text = sb.ToString();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }
    }
}
