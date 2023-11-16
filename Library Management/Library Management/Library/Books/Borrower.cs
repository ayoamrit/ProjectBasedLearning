using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.MainLibrary.Books
{
    public class Borrower
    {
        private string Email { get; set; }

        public Borrower(string Email)
        {
            this.Email = Email;
        }

        public string getEmail()
        {
            return this.Email;
        }
    }
}
