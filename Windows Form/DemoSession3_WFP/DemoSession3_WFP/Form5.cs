using DemoSession3_WFP.Entity;
using DemoSession3_WFP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession3_WFP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            var categoryModel = new CategoryModel();
            var root = new TreeNode("Category");
            treeViewCategory.Nodes.Add(root);
            foreach(var category in categoryModel.findAll())
            {
                var treeNode = new TreeNode(category.Name);
                treeNode.Tag = category;
                root.Nodes.Add(treeNode);
            }
        }

        private void treeViewCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = treeViewCategory.SelectedNode;
            if(selectedNode.Tag != null)
            {
                var category = selectedNode.Tag as Category;
                dataGridViewProduct.DataSource = category.Products;
                    /*Select(p => new
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }).ToList();*/
            }
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = dataGridViewProduct.CurrentRow.DataBoundItem as Product;
            textBoxID.Text = product.Id;
            textBoxName.Text = product.Name;
            textBoxPrice.Text = product.Price.ToString();
            textBoxQuantity.Text = product.Quantity.ToString();
            checkBoxStatus.Checked = product.Status;
            dateTimePickerCreated.Value = product.Created;
        }
    }
}
