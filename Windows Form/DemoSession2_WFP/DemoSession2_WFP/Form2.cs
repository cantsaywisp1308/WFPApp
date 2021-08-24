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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var categoryModel = new CategoryModel();
            listBoxCategory.DataSource = categoryModel.findAll();
            listBoxCategory.DisplayMember = "Name";
            listBoxCategory.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var count = listBoxCategory.SelectedItems.Count;
            Debug.WriteLine("Count: " + count);
            if(count > 0)
            {
                foreach(var selectedItem in listBoxCategory.SelectedItems)
                {
                    var category = selectedItem as Category;
                    Debug.WriteLine("ID: " + category.Id);
                    Debug.WriteLine("ID: " + category.Name);
                }
            }

            Debug.WriteLine("list 2: ");
            var count2 = listBoxCategory.SelectedIndices.Count;
            Debug.WriteLine("Count: " + count2);
            if(count2 > 0)
            {
                foreach (int i in listBoxCategory.SelectedIndices)
                {
                    var category = listBoxCategory.Items[i] as Category;
                    Debug.WriteLine("ID: "+category.Id);
                    Debug.WriteLine("Name: "+category.Name);
                    Debug.WriteLine("===========================");
                }
            }
        }
    }
}
