using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.MainLibrary.Account
{
    public class Account
    {
        private string Email { get; set; }
        private string Password { get; set; }
        private List<BorrowedBooks> borrowedBooks { get; set; }

        public Account(string Email, string Password, BorrowedBooks borrowedBooks)
        {
            this.Email = Email;
            this.Password = Password;
            this.borrowedBooks = new List<BorrowedBooks> {borrowedBooks};
        }

        public string getEmail()
        {
            return this.Email;
        }

        public string getPassword()
        {
            return this.Password;
        }
    }
}
