using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession7_WFP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMenu1 = new FormMenu1();
            formMenu1.MdiParent = this;
            formMenu1.Show();
        }

        private void menu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMenu2 = new FormMenu2();
            formMenu2.MdiParent = this;
            formMenu2.Show();
        }
    }
}
