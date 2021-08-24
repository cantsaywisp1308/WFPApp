using DemoSession6_WFP.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession6_WFP.Helper
{
    public class ProductHelper
    {
        public static List<Product> ImportCSV(string fileName)
        {
            var products = new List<Product>();
            var lines = File.ReadAllLines(fileName);
            foreach(var line in lines)
            {
                products.Add(new Product(line));
            }
            return products;
        }

        public static List<Product> ImportCSVs(string[] fileNames)
        {
            var products = new List<Product>();
            foreach (var fileName in fileNames)
            {
                products.AddRange(ImportCSV(fileName));
            }
            return products;
        }
    }

    
}
