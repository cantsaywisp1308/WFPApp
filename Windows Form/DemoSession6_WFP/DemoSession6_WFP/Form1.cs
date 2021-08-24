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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file";
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = @"C:\Users\DELL\Desktop\Hình PR";
            openFileDialog.Filter = "GIF(*.gif)|*.gif|PNG(*.png)|*.png|JPEG(*.jpeg)|*jpeg|All Files(*.*)|*.*";
            var dialogResult =  openFileDialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                Debug.WriteLine(openFileDialog.FileName);
                var fileInfo = new FileInfo(openFileDialog.FileName);
                Debug.WriteLine("Length: "+ fileInfo.Length);
                Debug.WriteLine("Name: " + fileInfo.FullName);
                Debug.WriteLine("Name: " + fileInfo.Name);
                Debug.WriteLine("Extension: " + fileInfo.Extension);
                pictureBoxPhoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void buttonOpenFiles_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file";
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = @"C:\Users\DELL\Desktop\Hình PR";
            openFileDialog.Filter = "GIF(*.gif)|*.gif|PNG(*.png)|*.png|JPEG(*.jpeg)|*jpeg|All Files(*.*)|*.*";
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                var fileNames = openFileDialog.FileNames;
                Debug.WriteLine("Files: " + fileNames.Length);
                foreach(var fileName in fileNames)
                {
                    var fileInfo = new FileInfo(fileName);
                    Debug.WriteLine("Length: " + fileInfo.Length);
                    Debug.WriteLine("Name: " + fileInfo.FullName);
                    Debug.WriteLine("Name: " + fileInfo.Name);
                    Debug.WriteLine("Extension: " + fileInfo.Extension);
                    Debug.WriteLine("==================");

                }
            }
        }
    }
}
