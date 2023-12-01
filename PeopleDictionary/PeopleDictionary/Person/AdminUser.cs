using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleDictionary.Interface;

namespace PeopleDictionary.Person
{
    internal class AdminUser : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } = "Admin";
        public List<string> Duties { get; set; }

        public AdminUser(string Name, string Email, List<string> Duties)
        {
            this.Name = Name;
            this.Email = Email;
            this.Duties = Duties;
        }
    }
}
