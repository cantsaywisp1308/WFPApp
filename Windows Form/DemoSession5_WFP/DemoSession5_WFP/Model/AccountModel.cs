using DemoSession5_WFP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5_WFP.Model
{
    public class AccountModel
    {
        private List<Account> accounts;
        public AccountModel()
        {
            accounts = new List<Account>
            {
                new Account { Username = "alchemist", Password = "abc", Fullname = "Alchemist", Role = "Admin" },
                new Account { Username = "abaddon", Password = "abc1", Fullname = "Abaddon", Role = "Employee" },
                new Account { Username = "axe", Password = "abc12", Fullname = "Axe", Role = "Employee" },
                new Account { Username = "ancient", Password = "abc123", Fullname = "Ancient", Role = "Employee" },
                new Account { Username = "bristleback", Password = "abc1234", Fullname = "Bristleback", Role = "Employee" },
            };
        }

        public Account login(string username, string password)
        {
            return accounts.SingleOrDefault(a => a.Username == username && a.Password == password);
        }
    }
}
