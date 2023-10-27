using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLaunch.CustomException
{
    //Exception for when a string is empty or null
    public class EmptyOrNullString : Exception
    {
        public EmptyOrNullString(string message) : base(message)
        {
            
        }
    }

    //Exception for when an incorrect password is provided
    public class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException(string message) : base(message)
        {

        }
    }

    //Exception for when an account does not exist
    public class AccountDoesNotExist : Exception
    {
        public AccountDoesNotExist(string message) : base(message)
        {

        }
    }

    //Exception for database connection failures
    public class DatabaseConnectionException : Exception
    {
        public DatabaseConnectionException()
            :base("Database Connection Failed: Unable to establish a connection to the database server")
        {

        }
    }

    public class FetchDataFromDatabaseException : Exception
    {
        public FetchDataFromDatabaseException()
            : base("Unable To Fetch Data From Database: An unexpected occurred")
        {

        }
    }
}
