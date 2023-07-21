using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private double All_0p(char op)
        {
            double num1 = double.Parse(text_Num1.Text);
            double num2 = double.Parse(text_Num2.Text);
            double result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    { if (num2 == 0.0) return 0; }
                    result = num1 / num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
            }return result;
        }

        private void bt_Plus_Click(object sender, EventArgs e)
        {text_Result.Text = Convert.ToString(All_0p('+'));}

        private void bt_Minus_Click(object sender, EventArgs e)
        { text_Result.Text = Convert.ToString(All_0p('-')); }

        private void bt_Multi_Click(object sender, EventArgs e)
        { text_Result.Text = Convert.ToString(All_0p('*')); }

        private void bt_Division_Click(object sender, EventArgs e)
        { text_Result.Text = Convert.ToString(All_0p('/')); }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_Sum_Click(object sender, EventArgs e)
        { text_Result.Text = Convert.ToString(All_0p('%')); }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            
            text_Num1.Text = " ";
            text_Num2.Text = " ";
            text_Result.Text = " ";
        }
    }
}
