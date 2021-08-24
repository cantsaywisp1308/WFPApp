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
    public partial class UserControlMenu1 : UserControl
    {
        public UserControlMenu1()
        {
            InitializeComponent();
        }

        private void UserControlMenu1_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            Panel panelMain = (Panel)Parent;
            panelMain.Controls.Clear();
            var userControlMenu2 = new UserControlMenu2();
            panelMain.Controls.Add(userControlMenu2);
        }
    }
}
