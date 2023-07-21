using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace sm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startDateTime = DateTime.Now; //초기화 주석하면 01년01월01일뜬다.
        }
        DateTime startDateTime;
        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStartDateTime().ToString()); //클릭시 시간띄우기
        }
    }
}
