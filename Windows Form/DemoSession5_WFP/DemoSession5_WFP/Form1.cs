using DemoSession5_WFP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession5_WFP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            var data = new Dictionary<string, Object>();
            data.Add("id", 123);
            data.Add("username", "abc");
            data.Add("account", new Account
            {
                Username = "acc1",
                Password = "def",
                Fullname = "name 1",
                Role = "role 1"
            }) ;
            var form2 = new Form2(data);
            form2.Show();
            Hide();
        }
    }
}
