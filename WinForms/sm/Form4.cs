using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Bth_short_Click(object sender, EventArgs e)
        {
            try
            {
                short snum = short.Parse(txt_Number.Text);
                lb_short.Text = snum.ToString();
                lb_Exception.Text = "-";
            }
            catch (Exception ex)
            {
                lb_short.Text = "-";
                lb_int.Text = "-";
                lb_double.Text = "-";
                lb_Exception.Text = ex.ToString();
            }
        }

        private void Bth_int_Click(object sender, EventArgs e)
        {
            try
            {
                int inum = int.Parse(txt_Number.Text);
                lb_int.Text = inum.ToString();
                lb_Exception.Text = "-";
            }
            catch (Exception ex)
            {
                lb_short.Text = "-";
                lb_int.Text = "-";
                lb_double.Text = "-";
                lb_Exception.Text = ex.ToString();
            }
        }

        private void Btn_double_Click(object sender, EventArgs e)
        {
            try
            {
                double dnum = double.Parse(txt_Number.Text);
                lb_double.Text = dnum.ToString();
                lb_Exception.Text = "-";
            }
            catch (Exception ex)
            {
                lb_short.Text = "-";
                lb_int.Text = "-";
                lb_double.Text = "-";
                lb_Exception.Text = ex.ToString();
            }
        }

        private void Bth_All_Click(object sender, EventArgs e)
        {
            short snum2 = 0;
            int inum2 = 0;
            double dnum2 = 0.0;
            lb_Exception.Text = "-";

            if (short.TryParse(txt_Number.Text, out snum2))
            {
                lb_short.Text = snum2.ToString();
                lb_int.Text = "-";
                lb_double.Text = "-";
            }
            else if (int.TryParse(txt_Number.Text, out inum2))
            {
                lb_int.Text = inum2.ToString();
                lb_short.Text = "-";
                lb_double.Text = "-";
            }
            else if (double.TryParse(txt_Number.Text, out dnum2))
            {
                lb_double.Text = dnum2.ToString();
                lb_short.Text = "-";
                lb_int.Text = "-";
            }
            else
            {
                lb_Exception.Text = "변환 할 수 없습니다. ";
                lb_short.Text = "-";
                lb_int.Text = "-";
                lb_double.Text = "-";
            }
        }
    }
}
