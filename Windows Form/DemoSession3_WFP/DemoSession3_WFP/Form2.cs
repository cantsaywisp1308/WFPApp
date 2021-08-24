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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach(var control in panelGender.Controls)
            {
                if(control is RadioButton)
                {
                    var radioButton = control as RadioButton;
                    if (radioButton.Checked)
                    {
                        Debug.WriteLine(radioButton.Text);
                    }
                }
                
            }

            foreach(var control1 in panelPayment.Controls)
            {
                if(control1 is RadioButton)
                {
                    var radioButton1 = control1 as RadioButton;
                    if (radioButton1.Checked)
                    {
                        Debug.WriteLine(radioButton1.Text);
                    }
                }
            }
        }

        private void buttonSave2_Click(object sender, EventArgs e)
        {
            var status = checkBoxStatus.Checked;
            Debug.WriteLine(status);
        }

        private void buttonSave3_Click(object sender, EventArgs e)
        {
            foreach(var control in panelLanguages.Controls)
            {
                if(control is CheckBox)
                {
                    var checkbox = control as CheckBox;
                    if (checkbox.Checked)
                    {
                        Debug.WriteLine(checkbox.Text);
                    }
                }
            }
        }

        private void buttonSave4_Click(object sender, EventArgs e)
        {
            foreach(var control in groupBoxRoles.Controls)
            {
                if(control is CheckBox)
                {
                    var checkBox = control as CheckBox;
                    if (checkBox.Checked)
                    {
                        Debug.WriteLine(checkBox.Text);
                    }
                }
            }
        }
    }
}
