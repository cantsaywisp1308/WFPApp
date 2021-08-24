using DemoSession7_WFP.Entity;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var account = login(username, password);
            if(account!= null)
            {
                MessageBox.Show("Done !");
                var data = new Dictionary<string, Object>();
                data.Add("username", username);
                var formMain = new FormMain(data);
                formMain.Show();
                Hide();
            } else
            {
                MessageBox.Show("Failed ! ");
            }
        }

        private Account login(string username, string password)
        {
            var db = new DatabaseContext();
            var account = db.Accounts.SingleOrDefault(a => a.Username == username);
            if(account != null)
            {
                if(BCrypt.Net.BCrypt.Verify(password, account.Password))
                {
                    return account;
                }
                
            }
            return null;
        }
    }
}
