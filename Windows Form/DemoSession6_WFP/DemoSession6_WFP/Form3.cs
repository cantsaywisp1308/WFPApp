using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession6_WFP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Text File";
            var dialogResult = saveFileDialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                var fileName = saveFileDialog.FileName;
                var content = textBoxContent.Text;
                File.WriteAllText(fileName, content);
                Debug.WriteLine(fileName);
            }
        }

        private void buttonInfoDialog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done !");
        }

        private void buttonConfirmDialog_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                Debug.WriteLine("Yes");
            } else if(result == DialogResult.No)
            {
                Debug.WriteLine("No");
            } else
            {
                Debug.WriteLine("Cancel");
            }
        }
    }
}
