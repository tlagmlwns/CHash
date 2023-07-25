using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        private void cdMhz_CheckedChanged(object sender, EventArgs e)
        {
            if (cdMhz.Checked == true) { tb_message.Text = AppendLine(string.Format($"{cdMhz.Text}이 선택되었습니다.")); cdMhz.Checked = false; }
        }

        private void cdPr_CheckedChanged(object sender, EventArgs e)
        {
            if (cdPr.Checked == true) { tb_message.Text = ($"{cdPr.Text}가 선택되었습니다."); cdPr.Checked = false; }
        }

        private void cdSs_CheckedChanged(object sender, EventArgs e)
        {
            if (cdSs.Checked == true) { tb_message.Text = ($"{cdSs.Text}가 선택되었습니다."); cdSs.Checked = false; }
        }
    }
}