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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var hash = BCrypt.Net.BCrypt.HashString(password);
            var description = textBoxDescription.Text;
            var birthday = dateTimePickerBirthday.Value;
            Debug.WriteLine("Username: "+username);
            Debug.WriteLine("Password: " + password);
            Debug.WriteLine("Hash: " + hash);
            Debug.WriteLine("Description: " + description);
            Debug.WriteLine("Birthday: " + birthday.ToString("dd/MM/yyyy"));
        }
    }
}
