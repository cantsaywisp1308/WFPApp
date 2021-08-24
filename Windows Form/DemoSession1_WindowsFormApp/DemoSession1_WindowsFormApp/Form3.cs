using DemoSession1_WindowsFormApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoSession1_WindowsFormApp.Model;

namespace DemoSession1_WindowsFormApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Id = textBoxID.Text,
                Name = textBoxName.Text,
                Price = double.Parse(textBoxPrice.Text),
                Quantity = int.Parse(textBoxQuantity.Text),
                Description = textBoxDescription.Text
            };
            var productModel = new ProductModel();
            productModel.SaveToFile(product);
        }
    }
}
