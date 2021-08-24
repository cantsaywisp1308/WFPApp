using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession6_WFP
{
    public partial class UserControlHi : UserControl
    {
        public string FullName { get; set; }
        public UserControlHi()
        {
            InitializeComponent();
        }

        private void UserControlHi_Load(object sender, EventArgs e)
        {
            labelMsg.Text = "Hi " + FullName;
        }
    }
}
