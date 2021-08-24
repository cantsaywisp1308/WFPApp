using DemoSession2_WFP.Entity;
using DemoSession2_WFP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession2_WFP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataCountry();
        }

        private void loadData2()
        {
            var categoryModel = new CategoryModel();
            comboBoxCategory2.DataSource = categoryModel.findAll();
            comboBoxCategory2.ValueMember = "Id";
            comboBoxCategory2.DisplayMember = "Name";
        }
        private void loadData1()
        {
            comboBoxCategory.Items.Add("Category 1");
            comboBoxCategory.Items.Add("Category 2");
            comboBoxCategory.Items.Add("Category 3");
            comboBoxCategory.Items.Add("Category 4");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var value = comboBoxCategory.Text;
            textBoxCategory.Text = value;
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            var id = comboBoxCategory2.SelectedValue.ToString();
            Debug.WriteLine(id);
            var category = comboBoxCategory2.SelectedItem as Category;
            //Category category2 = (Category)comboBoxCategory2.SelectedItem;
            Debug.WriteLine("ID: " + category.Id);
            Debug.WriteLine("name: " + category.Name);
        }

        private void comboBoxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Debug.WriteLine(comboBoxCategory.Text);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Selected Index Change" + comboBoxCategory.Text);
        }

        private void comboBoxCategory2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var id = comboBoxCategory2.SelectedValue.ToString();
            Debug.WriteLine(id);
            var category = comboBoxCategory2.SelectedItem as Category;
            //Category category2 = (Category)comboBoxCategory2.SelectedItem;
            Debug.WriteLine("ID: " + category.Id);
            Debug.WriteLine("name: " + category.Name);
        }

        private void loadDataCountry()
        {
            var countryModel = new CountryModel();
            comboBoxCountry.DataSource = countryModel.findAll();
            comboBoxCountry.DisplayMember = "Name";
            comboBoxCountry.ValueMember = "Id";
            
        }

        private void comboBoxCountry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var country = comboBoxCountry.SelectedItem as Country;
            comboBoxCity.DataSource = country.Cities;
            comboBoxCity.DisplayMember = "Name";
            comboBoxCity.ValueMember = "Id";
        }

        
    }
}
