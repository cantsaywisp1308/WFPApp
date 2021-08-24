using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession2_WFP.Entity
{
    public class Country
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<City> Cities { get; set; }
    }
}
