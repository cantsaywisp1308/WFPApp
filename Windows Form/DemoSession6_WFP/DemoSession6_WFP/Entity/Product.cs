using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession6_WFP.Entity
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Created { get; set; }

        public Product(string line)
        {
            var result = line.Trim().Split(new char[] { ',' });
            Id = result[0];
            Name = result[1];
            Quantity = int.Parse(result[2]);
            Price = double.Parse(result[3]);
            Created = DateTime.ParseExact(result[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
