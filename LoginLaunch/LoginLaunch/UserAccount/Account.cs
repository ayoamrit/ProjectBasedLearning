using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLaunch.UserAccount
{
    public class Account
    {
        public string firstname { get; set; } = string.Empty;
        public string lastname { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string[]? hobbies { get; set; }

        public Account(string firstname, string lastname, string email, string[] hobbies)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.hobbies = hobbies;
        }

        public String ToString()
        {
            return $"Firstname: {firstname} \nLastname: {lastname} \nEmail: {email} \nHobbies: {hobbies.ToString}";
        }
    }
}
