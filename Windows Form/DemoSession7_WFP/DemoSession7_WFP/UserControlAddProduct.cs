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
    public partial class UserControlAddProduct : UserControl
    {
        public UserControlAddProduct()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new DatabaseContext();
                var product = new Product
                {
                    Name = textBoxName.Text,
                    Price = (decimal)double.Parse(textBoxPrice.Text),
                    Quantity = int.Parse(textBoxQuantity.Text),
                    Created = dateTimePickerCreated.Value,
                    Status = checkBoxStatus.Checked,
                    CategoryId = int.Parse(comboBoxCategory.SelectedValue.ToString())
                };
                db.Products.Add(product);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Done! ");
                    Panel panelMain = (Panel)Parent;
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(new UserControlProductList());
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

        private void loadData()
        {
            var db = new DatabaseContext();
            var categories = db.Categories.ToList();
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";
        }

        private void UserControlAddProduct_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
