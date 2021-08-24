using DemoSession1_WindowsFormApp.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession1_WindowsFormApp.Model
{
    public class ProductModel
    {
        public void SaveToFile(Product product)
        {
            File.AppendAllText(@"D:\Data\product.txt", product.ToString());

        }
    }
}
