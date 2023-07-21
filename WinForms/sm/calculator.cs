using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace sm
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void bt_BackSpace_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_Plus_Click(object sender, EventArgs e) {
            Button btn = (Button)sender; textBox1.Text += btn.Text;
             }

        private void bt_Minus_Click(object sender, EventArgs e) {
            Button btn = (Button)sender; textBox1.Text += btn.Text;
            }

        private void bt_Multi_Click(object sender, EventArgs e) {
            Button btn = (Button)sender; textBox1.Text += btn.Text;
           }

        private void bt_Divide_Click(object sender, EventArgs e) {
            Button btn = (Button)sender; textBox1.Text += btn.Text;
            }

        private void bt_Result_Click(object sender, EventArgs e) {
            
            //string[] typeSplit = textBox1.Text.Split('+','-','*','/');
            /*
            for (int s = 0; s<typeSplit.Length; s++)
            {
                if (typeSplit[s] == "+")
                {
                    double result = 0;
                    string[] plusSplit = textBox1.Text.Split('+');
                    for (int i = 0; i < plusSplit.Length; i++)
                    {
                        Console.WriteLine(plusSplit[i]);
                        result += Convert.ToDouble(plusSplit[i]);
                    }
                    textBox1.Text = Convert.ToString(result);
                }
                else if (typeSplit[s] == "-")
                {
                    double result = 0;
                    string[] minusSplit = textBox1.Text.Split('-');

                    for (int i = 0; i < minusSplit.Length; i++)
                    {
                        Console.WriteLine(minusSplit[i]);
                        result -= Convert.ToDouble(minusSplit[i]);
                    }
                    textBox1.Text = Convert.ToString(result);
                }
                else if (typeSplit[s] == "*")
                {
                    double result = 0;
                    string[] multiSplit = textBox1.Text.Split('*');
                    result = 0;
                    for (int i = 0; i < multiSplit.Length; i++)
                    {
                        Console.WriteLine(multiSplit[i]);
                        result *= Convert.ToDouble(multiSplit[i]);
                    }
                    textBox1.Text = Convert.ToString(result);
                }
                else
                {
                    double result = 0;
                    string[] divideSplit = textBox1.Text.Split('/');
                    result = 0;
                    for (int i = 0; i < divideSplit.Length; i++)
                    {
                        Console.WriteLine(divideSplit[i]);
                        result /= Convert.ToDouble(divideSplit[i]);
                    }
                    textBox1.Text = Convert.ToString(result);
                }
            }*/
            string expression = textBox1.Text;
            DataTable dt = new DataTable();
            try
            {
                object result = dt.Compute(expression, "");
                textBox1.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                // 예외 처리: 부적절한 수식 또는 계산 오류
                Console.WriteLine("Error: " + ex.Message);
                textBox1.Text = "Error";
            }
        }

        private void bt_0_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
        private void bt_1_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
        private void bt_2_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
        private void bt_3_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
        private void bt_4_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
        private void bt_5_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
        private void bt_6_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
        private void bt_7_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
        private void bt_8_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
        private void bt_9_Click(object sender, EventArgs e) { Button btn = (Button)sender; textBox1.Text += btn.Text; }
    }
}
// 다음주 시험 12장 델리게이트 코드 짜기 1개 나머지 2345 단답식 