using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLaunch.CustomException
{
    public class EmptyOrNullString : Exception
    {
        public EmptyOrNullString(string message) : base(message)
        {

        }
    }

    public class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException(string message) : base(message)
        {

        }
    }

    public class AccountDoesNotExist : Exception
    {
        public AccountDoesNotExist(string message) : base(message)
        {

        }
    }
}
