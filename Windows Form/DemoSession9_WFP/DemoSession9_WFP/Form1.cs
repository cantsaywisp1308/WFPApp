using DemoSession9_WFP.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession9_WFP
{
    public partial class Form1 : Form
    {
        private string fileName;
        private string[] fileNames;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var to = textBoxTo.Text;
            var subject = textBoxSubject.Text;
            var content = textBoxContent.Text;

            if (MailHelper.Send(to, subject, content,true,fileNames))
            {
                MessageBox.Show("Sent successfully! ");
            }
            else
            {
                MessageBox.Show("Fail to send! ");
            }
        }

        private void buttonAttach1File_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }
        }

        private void buttonAttachFiles_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNames = openFileDialog.FileNames;
            }
        }
    }
}
