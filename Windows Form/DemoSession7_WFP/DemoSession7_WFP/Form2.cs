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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonMenu1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var userControlMenu1 = new UserControlMenu1();
            panelMain.Controls.Add(userControlMenu1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var userControlMenu1 = new UserControlMenu1();
            panelMain.Controls.Add(userControlMenu1);

        }

        private void buttonMenu2_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var userControlMenu2 = new UserControlMenu2();
            panelMain.Controls.Add(userControlMenu2);
        }

        private void buttonMenu3_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var userControlMenu3 = new UserControlMenu3();
            panelMain.Controls.Add(userControlMenu3);
        }

        private void buttonMenu4_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var userControlMenu4 = new UserControlMenu4();
            panelMain.Controls.Add(userControlMenu4);
        }
    }
}
