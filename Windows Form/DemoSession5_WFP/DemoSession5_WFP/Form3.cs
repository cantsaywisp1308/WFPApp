using DemoSession5_WFP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession5_WFP
{
    public partial class Form3 : Form
    {
        private Dictionary<string, Object> data;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Dictionary<string, Object> data) :this()
        {
            this.data = data;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var account = data["account"] as Account;
            welcomeToolStripMenuItem.Text = "Welcome " + account.Username;
            if (account.Role == "Employee")
            {
                addToolStripMenuItem.Enabled = false;
                listToolStripMenuItem.Enabled = false;
                
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            Hide();
        }
    }
}
