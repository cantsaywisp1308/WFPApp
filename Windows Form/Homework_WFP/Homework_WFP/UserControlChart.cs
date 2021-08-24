using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_WFP
{
    public partial class UserControlChart : UserControl
    {
        public UserControlChart()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            chart1.Series["Salary"].Points.AddXY("Toshiba", 50);
            chart1.Series["Salary"].Points.AddXY("Sony", 80);
            chart1.Series["Salary"].Points.AddXY("Panasonic", 100);
        }

        private void UserControlChart_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
