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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var db = new DatabaseContext();
            var account = login(username, password);
            if(account != null)
            {
                var data = new Dictionary<string, Object>();
                data.Add("username", username);
                MessageBox.Show("Login successfully !");
                var formMain = new FormMain(data);
                formMain.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login fail !");
            }
        }

        private Account login(string username, string password)
        {
            var db = new DatabaseContext();
            var account = db.Accounts.SingleOrDefault(a => a.Username == username && a.Status == true);
            if (BCrypt.Net.BCrypt.Verify(password, account.Password))
            {
                return account;
            }
            return null;
        }
    }
}
