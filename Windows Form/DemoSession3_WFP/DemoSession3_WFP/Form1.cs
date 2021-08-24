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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData1();
        }

        private void loadData1()
        {
            var languages = new List<string>
            {
                "Language 1", "language 2", "Language 3","Language 4"
            };
            foreach(var language in languages)
            {
                checkedListBoxLanguage.Items.Add(language);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var count = checkedListBoxLanguage.CheckedItems.Count;
            Debug.WriteLine("count: " + count);
            if(count > 0)
            {
                foreach(var checkedItem in checkedListBoxLanguage.CheckedItems)
                {
                    Debug.WriteLine(checkedItem.ToString());
                }
            }
        }

        private void loadData2()
        {
            pictureBoxPhoto.ImageLocation = "Image/cheems.jpg";
        }

        
    }
}
