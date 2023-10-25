using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UserAuthentication
{
    //Namespace for user authentication-related classes
    public class Authentication
    {
        //Nested class for user login information
        public class Login
        {
            //Properties to store email and password
            public string email { get; set; } = string.Empty;
            public string password { get; set; } = string.Empty;

            //Constructor to initialize login information
            public Login(string email, string password)
            {
                this.email = email;
                this.password = password;
            }
        }

        //Nested class for user registration information
        public class Registration {

            //Properties to store user registration details
            public string firstname { get; set; } = string.Empty;
            public string lastname { get; set; } = string.Empty;
            public string email { get; set; } = string.Empty;
            public string password { get; set; } = string.Empty;

            //Constructor to initialize user registration details
            public Registration(string firstname, string lastname, string email, string password)
            {
                this.firstname = firstname;
                this.lastname = lastname;
                this.email = email;
                this.password = password;
            }
        }
    }
}
