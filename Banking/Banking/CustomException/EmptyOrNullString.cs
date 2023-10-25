using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.CustomException
{
    //Custom exception class to represent an empty or null string
    public class EmptyOrNullException : Exception
    {
        //Constructor that accepts a custom error message
        public EmptyOrNullException(string message) : base(message) { }
    }
}
