using DemoSession6_WFP.Entity;
using DemoSession6_WFP.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession6_WFP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file";
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = @"C:\Users\DELL\Desktop\Hình PR";
            openFileDialog.Filter = "CSV(*.csv)|*.csv|All Files(*.*)|*.*";
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var fileNames = openFileDialog.FileNames;
                var products = ProductHelper.ImportCSVs(fileNames);
                dataGridView1.DataSource = products;
            }
        }

        
    }
}
