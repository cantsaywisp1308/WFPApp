using Homework_WFP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_WFP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var account = login(username, password);
            if(account != null)
            {
                MessageBox.Show("Successfully Login ! ");
                var data = new Dictionary<string, Object>();
                data.Add("account", account);
                var form1 = new Form1(data);
                form1.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Fail to login !");
            }
        }

        private Account login(string username, string password)
        {
            var db = new DemoEntityFrameworkEntities();
            var account = db.Accounts.SingleOrDefault(a => a.Username == username);
            if(account != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                } 
            }
            return null;
        }
    }
}
