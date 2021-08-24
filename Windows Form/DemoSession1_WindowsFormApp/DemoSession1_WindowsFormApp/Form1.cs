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

namespace DemoSession1_WindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var content = labelHello.Text;
            Debug.WriteLine(content);
            labelHello.Text = "ABC";
        }

        private void buttonClickMe_Click(object sender, EventArgs e)
        {
            labelHello.Text = "DEF";
             

        }

        
    }
}
