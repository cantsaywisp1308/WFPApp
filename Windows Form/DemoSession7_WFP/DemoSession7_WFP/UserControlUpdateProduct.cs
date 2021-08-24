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
    public partial class UserControlUpdateProduct : UserControl
    {
        private Dictionary<string, Object> data;

        public UserControlUpdateProduct(Dictionary<string, Object> data) : this()
        {
            this.data = data;
        }
        public UserControlUpdateProduct()
        {
            InitializeComponent();
        }

        private void UserControlUpdateProduct_Load(object sender, EventArgs e)
        {
            var id = int.Parse(data["id"].ToString());
            var db = new DatabaseContext();
            var product = db.Products.SingleOrDefault(p => p.Id == id);
            textBoxName.Text = product.Name;
            textBoxDescription.Text = product.Description;
            textBoxPrice.Text = product.Price.ToString();
            textBoxQuantity.Text = product.Quantity.ToString();
            checkBoxStatus.Checked = product.Status;
            dateTimePickerCreated.Value = product.Created;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(data["id"].ToString());
            var db = new DatabaseContext();
            var product = db.Products.SingleOrDefault(p => p.Id == id);
            product.Name = textBoxName.Text;
            product.Description = textBoxDescription.Text ;
            product.Price = (decimal)double.Parse(textBoxPrice.Text);
            product.Quantity = int.Parse(textBoxQuantity.Text);
            product.Status = checkBoxStatus.Checked;
            product.Created = dateTimePickerCreated.Value;
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;  
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Updated Successfully! ");
                Panel panelMain = (Panel)Parent;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new UserControlProductList());
            }
            else
            {
                MessageBox.Show("Fail to update! ");
            }
        }
    }


}
