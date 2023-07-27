using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class ModalessForm : Form
    {
        public ModalessForm()
        {
            InitializeComponent();
        }
        
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
