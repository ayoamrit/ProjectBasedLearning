using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLaunch.UserAccount
{
    public class Account
    {
        //properties of Account class for storing user information
        public string firstname { get; set; } = string.Empty;
        public string lastname { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string[]? hobbies { get; set; }

        //Constructor, used to initialize an account object
        public Account(string firstname, string lastname, string email, string[] hobbies)
        {
            //assign the values provided to the corresponding properties.
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.hobbies = hobbies;
        }

        //function overrides the default ToString() method
        public override string ToString()
        {
            //return a formatted string
            return $"Firstname: {firstname} \nLastname: {lastname} \nEmail: {email} \nHobbies: {hobbies.ToString}";
        }
    }
}
