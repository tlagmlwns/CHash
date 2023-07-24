using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Random rand  = new Random();
            int yourLux = rand.Next(1, 101);
            int count = int.Parse(lbUpvalue.Text);
            if( yourLux <= 30 ) { MessageBox.Show("강화 실패"); count--;  }
            else if( yourLux > 30 ) { MessageBox.Show("강화 성공"); count++; }
            else if( yourLux > 50 ) { MessageBox.Show("강화 성공");count++; }
            else if( yourLux > 90 ) { MessageBox.Show("강화 대성공!"); count++; count++; }
            else { MessageBox.Show("사기치지마"); count++; count++; }
        }
    }
}
