using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            myButton.Text = "코드에서 변경";
            myButton.Width = 150;
            myButton.Height = 50;

            Button button = new Button();//코드를 통해 새로 만들기
            Controls.Add(button);
            button.Location = new Point(50, 50);
            button.Text = "코드로 새로 만든 버튼";
            button.Width = 150;
            button.Height = 50;

        }

        private void myButton_Click(object sender, EventArgs e)
        {

        }
    }
}
