using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Week2
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
            
        }
        Modaless modaless = null;
        private void 모달리스대화상자ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modaless ==  null) { modaless = new Modaless();modaless.Show(); }
        }
    }
}
