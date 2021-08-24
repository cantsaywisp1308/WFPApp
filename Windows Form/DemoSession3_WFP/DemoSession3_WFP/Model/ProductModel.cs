using DemoSession3_WFP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DemoSession3_WFP.Model
{
    public class ProductModel
    {
        public List<Product> findAll()
        {
            List<Product> products = new List<Product>
            {
                new Product{Id = "pr01", Name ="Laptop 1", Price=4.5, Quantity =11,Status=true, Created = DateTime.ParseExact("11/06/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)},
                new Product{Id = "pr02", Name ="Laptop 2", Price=3.5, Quantity =14,Status=false, Created = DateTime.ParseExact("12/06/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)},
                new Product{Id = "pr03", Name ="Tivi 1", Price=12.5, Quantity =32,Status=false, Created = DateTime.ParseExact("13/06/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)},
                new Product{Id = "pr04", Name ="Tivi 2", Price=24.3, Quantity =25,Status=true, Created = DateTime.ParseExact("14/06/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)},
                new Product{Id = "pr05", Name ="Desktop 1", Price=14.1, Quantity =5,Status=false, Created = DateTime.ParseExact("07/06/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)},
                new Product{Id = "pr06", Name ="Desktop 2", Price=11.8, Quantity =7,Status=true, Created = DateTime.ParseExact("09/06/2021","dd/MM/yyyy",CultureInfo.InvariantCulture)},
            };
            return products;
        }

        public List<Product> search(string key)
        {
            return findAll().Where(p => p.Name.ToLower().Contains(key.ToLower())).ToList();
        }

        public List<Product> searchByPrice(double min, double max)
        {
            return findAll().Where(p => p.Price >= min && p.Price <= max).ToList();
        }

        public List<Product> searchByDate(DateTime from, DateTime to)
        {
            return findAll().Where(p => p.Created >= from && p.Created <= to).ToList();
        }
    }
}
