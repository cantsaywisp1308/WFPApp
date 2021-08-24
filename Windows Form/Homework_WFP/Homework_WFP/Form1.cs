using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework_WFP.Entity;

namespace Homework_WFP
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Object> data;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Dictionary<string, Object> data) : this()
        {
            this.data = data;
        }

        private void loadData()
        {
            var db = new DemoEntityFrameworkEntities();
            var root = new TreeNode("Category");
            treeViewCategory.Nodes.Add(root);
            foreach(var category in db.Categories)
            {
                var treeNode = new TreeNode(category.Name);
                treeNode.Tag = category;
                root.Nodes.Add(treeNode);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            var account = data["account"] as Account;
            welcomeToolStripMenuItem.Text = "Welcome " + account.Username;
        }

        private void treeViewCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var db = new DemoEntityFrameworkEntities();
            var selectedNode = treeViewCategory.SelectedNode;
            if(selectedNode.Tag != null)
            {
                var category = selectedNode.Tag as Category;
                dataGridViewProducts.DataSource = db.Products.Where(p => p.CategoryId == category.Id).ToList();
            }
        }
    }
}
