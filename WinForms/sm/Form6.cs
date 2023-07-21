using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = (int)numericUpDown1.Value;
            int num2 = (int)numericUpDown2.Value;

            if (num1 > num2) { lb_Result1.Text = "첫 번째 숫자가 두 번째 숫자보다 큽니다."; }
            else if(num1 < num2) { lb_Result1.Text = "두 번째 숫자가 첫 번째 숫자보다 큽니다."; }
            else { lb_Result1.Text = "두 숫자가 서로 같습니다."; }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            lb_Result1.Text = null;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.Text;
            switch (str)
            {
                case "일요일":
                    lb_Result2.Text = "일요일 입니다.";
                    break;
                case "월요일":
                    lb_Result2.Text = "월요일 입니다.";
                    break;
                case "화요일":
                    lb_Result2.Text = "화요일 입니다.";
                    break;
                case "수요일":
                    lb_Result2.Text = "수요일 입니다.";
                    break;
                case "목요일":
                    lb_Result2.Text = "목요일 입니다.";
                    break;
                case "금요일":
                    lb_Result2.Text = "금요일 입니다.";
                    break;
                case "토요일":
                    lb_Result2.Text = "토요일 입니다.";
                    break;
                default:
                    lb_Result2.Text = "올바른 값을 선택하시오.";
                    break;
            }
        }
    }
}
