using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.ExceptionHandler
{
    public class InvalidNumberOfSuffix : IOException
    {

        public InvalidNumberOfSuffix(string message): base(message)
        {

        }
    }
}
