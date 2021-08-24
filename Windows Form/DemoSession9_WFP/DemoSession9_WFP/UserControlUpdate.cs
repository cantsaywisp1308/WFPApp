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
    public partial class UserControlUpdate : UserControl
    {
        private Dictionary<string, Object>data;

        public UserControlUpdate(Dictionary<string, Object>data) : this()
        {
            this.data = data;
        }
        public UserControlUpdate()
        {
            InitializeComponent();
        }

        private void UserControlUpdate_Load(object sender, EventArgs e)
        {
            var username = data["username"].ToString();
            var db = new DatabaseContext();
            var account = db.Accounts.SingleOrDefault(a => a.Username.Equals(username));
            textBoxUsername.Text = account.Username;
            textBoxEmail.Text = account.Email;
            dateTimePickerBirthday.Value = account.Birthday.Value;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var username = data["username"].ToString();
                var db = new DatabaseContext();
                var account = db.Accounts.SingleOrDefault(a => a.Username.Equals(username));
                if (account != null)
                {
                    account.Username = textBoxUsername.Text;
                    account.Email = textBoxEmail.Text;
                    account.Birthday = dateTimePickerBirthday.Value;
                    db.Entry(account).State = System.Data.Entity.EntityState.Modified;
                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Updated successfully !");
                    }
                    else
                    {
                        MessageBox.Show("Fail to Update");
                    }
                }
            } catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
            
            
        }
    }
}
