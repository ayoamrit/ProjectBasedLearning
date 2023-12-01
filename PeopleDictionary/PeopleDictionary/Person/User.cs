using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleDictionary.Interface;

namespace PeopleDictionary.Person
{
    public class User : IUser
    {
        public string Name { get ; set; }
        public string Email { get; set; }
        public string Role { get; set; } = "Regular";
        public List<string> Duties { get; set; }

        public User(string Name, string Email, List<string> Duties)
        {
            this.Name = Name;
            this.Email = Email;
            this.Duties = Duties;
        }
    }
}
