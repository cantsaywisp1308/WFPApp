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
    public partial class Active : Form
    {
        private Dictionary<string, Object> data;

        public Active(Dictionary<string, Object> data) : this()
        {
            this.data = data;
        }
        public Active()
        {
            InitializeComponent();
        }

        private void Active_Load(object sender, EventArgs e)
        {
            var email = data["email"].ToString();
            textBoxEmail.Text = email;
        }

        private void buttonActive_Click(object sender, EventArgs e)
        {
            
                var email = data["email"].ToString();
                var db = new DatabaseContext();
                var account = db.Accounts.SingleOrDefault(a => a.Email.Equals(email));
            if (account != null)
            {
                account.Status = true;
                db.Entry(account).State = System.Data.Entity.EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Activate account Successfully !");
                    var login = new Login();
                    login.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Fail to activate");
                }
            }
        }
    }
}
