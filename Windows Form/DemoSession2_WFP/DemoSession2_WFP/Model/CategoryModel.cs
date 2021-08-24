using DemoSession2_WFP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession2_WFP.Model
{
    public class CategoryModel
    {
        public List<Category> findAll()
        {
            return new List<Category>{
                new Category { Id="C1",Name="Category 1"},
                new Category { Id="C2",Name="Category 2"},
                new Category { Id="C3",Name="Category 3"},
                new Category { Id="C4",Name="Category 4"},
                new Category { Id="C5",Name="Category 5"}
            };
        }
    }
}
