using DemoSession9_WFP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession9_WFP
{
    public partial class FormMain : Form
    {
        private Dictionary<string, Object> data;

        public FormMain(Dictionary<string, Object> data) : this()
        {
            this.data = data;
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            var username = data["username"].ToString();
            var db = new DatabaseContext();
            var account = db.Accounts.SingleOrDefault(a => a.Username.Equals(username));
            welcomeToolStripMenuItem.Text = "Welcome " + account.Username; 
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userControlUpdate = new UserControlUpdate(data);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlUpdate);
        }
    }
}
