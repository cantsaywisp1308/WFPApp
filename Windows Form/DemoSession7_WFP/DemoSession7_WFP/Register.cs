using DemoSession7_WFP.Entity;
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

namespace DemoSession7_WFP
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try {
                var db = new DatabaseContext();
                var account = new Account
                {
                    Username = textBoxUsername.Text,
                    Password = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text),
                    Fullname = textBoxFullname.Text,
                    Email = textBoxEmail.Text,
                    Birthday = DateTime.ParseExact(dateTimePickerBirthday.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                };
                db.Accounts.Add(account);
                if(db.SaveChanges() > 0)
                {
                    MessageBox.Show("Done !");
                    var login = new Login();
                    login.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            } catch (Exception e1) {
                Console.WriteLine(e1);
            }
            

        }
    }
}
