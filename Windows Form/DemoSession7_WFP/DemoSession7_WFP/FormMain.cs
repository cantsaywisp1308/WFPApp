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
    public partial class FormMain : Form
    {
        private Dictionary<string, Object> data;
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(Dictionary<string, Object>data) : this()
        {
            this.data = data;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            welcomeToolStripMenuItem.Text = "Welcome " + data["username"].ToString();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var userControlProfile = new UserControlProfile(data);
            panelMain.Controls.Add(userControlProfile);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var usercontrolProductList = new UserControlProductList();
            panelMain.Controls.Add(usercontrolProductList);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProduct = new UserControlAddProduct();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(addProduct);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            var id = int.Parse(data["id"].ToString());
            var product = db.Products.SingleOrDefault(p => p.Id == id);
            db.Products.Remove(product);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Deleted Successfully");
                Panel panelMain = (Panel)Parent;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new UserControlProductList());
            }

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var userControlUpdateProduct = new UserControlUpdateProduct(data);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlUpdateProduct);
        }
    }
}
