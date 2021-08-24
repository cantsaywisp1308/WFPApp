using Homework_WFP.Entity;
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

namespace Homework_WFP
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var db = new DemoEntityFrameworkEntities();
            var account = new Account
            {
                Username = textBoxUsername.Text,
                Password = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text),
                Fullname = textBoxFullName.Text,
                Email = textBoxEmail.Text,
                Birthday = DateTime.ParseExact(dateTimePickerBirthday.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };
            db.Accounts.Add(account);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Successfully Registered !");
                var login = new Login();
                login.Show();
                Hide();
            } else
            {
                MessageBox.Show("Fail to Register !");
            }

        }
    }
}
