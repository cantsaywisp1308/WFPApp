using DemoSession2_WFP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession2_WFP.Model
{
    public class CountryModel
    {
        public List<Country> findAll()
        {
            return new List<Country>
            {
                new Country
                {
                    Id = "Vie",
                    Name = "Vietnam",
                    Cities = new List<City> { new City { Id = "HN", Name = "Ha Noi" }, new City { Id = "HCM", Name = "ho Chi Minh City" }, new City { Id = "DN", Name = "Da Nang" } }
                },
                new Country
                {
                    Id = "Jap",
                    Name = "Japan",
                    Cities = new List<City> { new City { Id = "TO", Name = "Tokyo" }, new City { Id = "Kyo", Name = "Kyoto" }, new City { Id = "HOK", Name = "Hokkaido" } }
                },
                new Country
                {
                    Id = "Kor",
                    Name = "Korea",
                    Cities = new List<City> { new City { Id = "SE", Name = "Seoul" }, new City { Id = "BU", Name = "Busan" }, new City { Id = "JE", Name = "Jeju" } }
                }
            };
        }
    }
}
