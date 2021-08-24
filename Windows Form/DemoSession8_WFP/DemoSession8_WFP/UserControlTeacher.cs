using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession8_WFP
{
    public partial class UserControlTeacher : UserControl
    {
        public UserControlTeacher()
        {
            InitializeComponent();
        }

        private void UserControlTeacher_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            var db = new DatabaseContext();
            dataGridViewProduct.DataSource = db.Products.ToList();
        }
    }
}
