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
    public partial class UserControlProfile : UserControl
    {
        private Dictionary<string, Object> data; 
        public UserControlProfile()
        {
            InitializeComponent();
        }

        public UserControlProfile(Dictionary<string, Object>data) : this()
        {
            this.data = data;
        }

        private void UserControlProfile_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            var db = new DatabaseContext();
            string username = data["username"].ToString();
            var account = db.Accounts.SingleOrDefault(a => a.Username == username);
            textBoxUsername.Text = account.Username;
            textBoxFullname.Text = account.Fullname;
            textBoxEmail.Text = account.Email;
            dateTimePickerBirthday.Value = account.Birthday.Value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try 
            {
                var db = new DatabaseContext();
                string username = data["username"].ToString();
                var account = db.Accounts.SingleOrDefault(a => a.Username == username);
                if (!string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    BCrypt.Net.BCrypt.HashString(textBoxPassword.Text);
                }
                account.Fullname = textBoxFullname.Text;
                account.Email = textBoxEmail.Text;
                account.Birthday = dateTimePickerBirthday.Value;
                if(db.SaveChanges() > 0)
                {
                    MessageBox.Show("Done !");
                }
                else
                {
                    MessageBox.Show("Failed! ");
                }
            }
            
            catch 
            {
                MessageBox.Show("Failed! ");
            }
        }
    }
}
