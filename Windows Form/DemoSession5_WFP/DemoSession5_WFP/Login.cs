using DemoSession5_WFP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace DemoSession5_WFP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            var accountModel = new AccountModel();
            var account = accountModel.login(textBoxUsername.Text, textBoxPassword.Text);
            if(account == null)
            {
                MessageBox.Show("INVALID!");
            }
            var data = new Dictionary<string, Object>();
            data.Add("account", account);
            var form3 = new Form3(data);
            form3.Show();
            Hide();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var accountModel = new AccountModel();
                var account = accountModel.login(textBoxUsername.Text, textBoxPassword.Text);
                if (account == null)
                {
                    MessageBox.Show("INVALID!");
                }
                var data = new Dictionary<string, Object>();
                data.Add("account", account);
                var form3 = new Form3(data);
                form3.Show();
                Hide();
            }
        }
    }
}
