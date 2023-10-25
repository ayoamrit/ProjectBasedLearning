using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UserAccounts
{
    internal class Account
    {
        //Properties to store account information
        public string firstname { get; set; } = string.Empty;
        public string lastname { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string accountId { get; set; } = string.Empty;
        public string accountType { get; set; } = string.Empty;
        public double accountBalance { get; set; }

        //Constructor to initialize an Account object
        public Account(string firstname, string lastname, string email, 
            string accountId, string accountType, double accountBalance)
        {

            //Initialize the object's properties with the provided values
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.accountId = accountId;
            this.accountType = accountType;
            this.accountBalance = accountBalance;
        }
    }
}
