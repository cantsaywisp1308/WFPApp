using DemoSession3_WFP.Model;
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

namespace DemoSession3_WFP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var productModel = new ProductModel();
            dataGridViewProducts.DataSource = productModel.findAll();
            dataGridViewProducts.Columns[0].HeaderText = "Ma San Pham";
            dataGridViewProducts.Columns[2].HeaderText = "Gia San Pham";
            dataGridViewProducts.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0 && e.ColumnIndex >0)
            {
                Debug.WriteLine("Row Index: " + e.RowIndex);
                Debug.WriteLine("Column Index: " + e.ColumnIndex);
                var value = dataGridViewProducts.CurrentCell.Value.ToString();
                Debug.WriteLine("Value: " + value);
                var id = dataGridViewProducts.CurrentRow.Cells[0].Value.ToString();
                Debug.WriteLine("ID: " + id);
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var result = textBoxSearch.Text;
            var productModel = new ProductModel();
            dataGridViewProducts.DataSource = productModel.search(result);
        }

        private void buttonSearchByPrice_Click(object sender, EventArgs e)
        {
            var min = double.Parse(textBoxMin.Text);
            var max = double.Parse(textBoxMax.Text);
            var productModel = new ProductModel();
            dataGridViewProducts.DataSource = productModel.searchByPrice(min, max);
        }

        private void buttonSearchByDate_Click(object sender, EventArgs e)
        {
            var productModel = new ProductModel();
            var from = dateTimePickerFrom.Value;
            var to = dateTimePickerTo.Value;
            dataGridViewProducts.DataSource = productModel.searchByDate(from, to);
        }
    }
}
