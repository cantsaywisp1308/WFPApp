using DemoSession5_WFP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession5_WFP
{
    public partial class Form2 : Form
    {
        private Dictionary<string, Object> data;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Dictionary<string,Object> data) : this()
        {
            this.data = data;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxID.Text = data["id"].ToString();
            textBoxUsername.Text = data["username"].ToString();
            var account = data["account"] as Account;
            Debug.WriteLine("username: " + account.Username);
            Debug.WriteLine("password: " + account.Password);
            Debug.WriteLine("Fullname: " + account.Fullname);
            Debug.WriteLine("Role: " + account.Role);
            solutionExplorerToolStripMenuItem.Enabled = false;
            gitChangesToolStripMenuItem.Visible = false;
        }

        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Code Menu");
        }

        private void designerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Designer Menu");
        }
    }
}
