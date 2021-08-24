using DemoSession3_WFP.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession3_WFP.Model
{
    public class CategoryModel
    {
        public List<Category> findAll()
        {
            return new List<Category>
            {
                new Category{Id="Cate1",Name="Laptop",Products=new List<Product>{new Product{ Id = "pr01", Name = "Laptop 1", Price = 4.5, Quantity = 11, Status = true, Created = DateTime.ParseExact("11/06/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture)},new Product{ Id = "pr02", Name = "Laptop 2", Price = 14.5, Quantity = 18, Status = false, Created = DateTime.ParseExact("11/06/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture)}}},
                new Category{Id="Cate2",Name="Tivi",Products=new List<Product>{new Product{ Id = "pr03", Name = "Tivi 1", Price = 41.5, Quantity = 21, Status = true, Created = DateTime.ParseExact("12/06/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture)},new Product{ Id = "pr04", Name = "Tivi 2", Price = 41.5, Quantity = 21, Status = true, Created = DateTime.ParseExact("12/06/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture)}}}
            };
        }

        public List<Product> searchByCategory(string categoryName)
        {
            List<Product> products = new List<Product>();
            foreach(var category in findAll())
            {
                if (category.Name.ToLower().Contains(categoryName.ToLower()))
                {
                    products = category.Products;
                }
            }
            return products;
        }
    }
}
