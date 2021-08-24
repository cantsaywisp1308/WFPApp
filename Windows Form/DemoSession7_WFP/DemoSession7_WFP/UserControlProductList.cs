using DemoSession7_WFP.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession7_WFP
{

    public partial class UserControlProductList : UserControl
    {
        
        public UserControlProductList()
        {
            InitializeComponent();
        }

        private void UserControlProductList_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            var db = new DatabaseContext();
            dataGridViewProductList.DataSource = db.Products.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                Category = p.Category.Name
            }).ToList(); ;
            comboBoxCategory.DataSource = db.Categories.ToList();
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }

       

        private void comboBoxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            
            var id = int.Parse(comboBoxCategory.SelectedValue.ToString());
            dataGridViewProductList.DataSource = db.Products.Where(p => p.CategoryId == id).Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                Category = p.Category.Name
            }).ToList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var key = textBoxProductName.Text;
            var db = new DatabaseContext();
            dataGridViewProductList.DataSource = db.Products.Where(p => p.Name.ToLower().Contains(key)).Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
                Category = p.Category.Name
            }).ToList();
        }



        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try 
            {
                var db = new DatabaseContext();
                var id = int.Parse(dataGridViewProductList.CurrentRow.Cells[0].Value.ToString());
                var product = db.Products.SingleOrDefault(p => p.Id == id);
                db.Products.Remove(product);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Remove Product Successfully! ");
                    Panel panelMain = (Panel)Parent;
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(new UserControlProductList());
                }
                else
                {
                    MessageBox.Show("Fail to remove Product! ");
                }
            } catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        

        private void dataGridViewProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = new Dictionary<string, Object>();
            var id = dataGridViewProductList.CurrentRow.Cells[0].Value.ToString();
            Debug.WriteLine(id);
            data.Add("id", id);
            var formMain = new FormMain(data);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var db = new DatabaseContext();
            var id = int.Parse(dataGridViewProductList.CurrentRow.Cells[0].Value.ToString());
            var data = new Dictionary<string, Object>();
            data.Add("id", id);
            var userControlUpdateProduct = new UserControlUpdateProduct(data);
            Panel panelMain = (Panel)Parent;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControlUpdateProduct);
        }
    }
}
