using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }
        private int x;
        private int y;
        private int h = 0;
        private MsgForm msg;

        private void btnMO_Click(object sender, EventArgs e)
        {
            x = Screen.PrimaryScreen.Bounds.Width - 350;
            y = Screen.PrimaryScreen.Bounds.Height;
            msg = new MsgForm();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (h > 300) { h = 0; timer1.Stop(); Thread.Sleep(2000); msg.Close();}
            else { msg.Location = new Point(x, y); msg.Show(); h += 10; }
        }
    }
}
