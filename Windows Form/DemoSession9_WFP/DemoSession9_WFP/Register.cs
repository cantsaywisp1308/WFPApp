using DemoSession9_WFP.Entity;
using DemoSession9_WFP.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession9_WFP
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var securityCode = Guid.NewGuid().ToString().Replace("-", "");
            var db = new DatabaseContext();
            var account = new Account
            {

                Username = textBoxUsername.Text,
                Password = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text),
                Email = textBoxEmail.Text,
                FullName = textBoxFullName.Text,
                Birthday = dateTimePickerBirthday.Value,
                Status = false,
                SecurityCode = securityCode
            };
            db.Accounts.Add(account);
            if (db.SaveChanges() > 0)
            {
                var email = textBoxEmail.Text;
                MailHelper.Send(textBoxEmail.Text, "Security Code", "Security code: " + securityCode);
                MessageBox.Show("Create account successfully! ");
                var data = new Dictionary<string, Object>();
                data.Add("email", email);
                var active = new Active(data);
                active.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Fail to add account! ");
            }
        }
    }
}
