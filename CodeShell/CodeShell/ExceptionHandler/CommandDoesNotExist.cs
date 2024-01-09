using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.ExceptionHandler
{
    public class CommandDoesNotExist : IOException
    {

        public CommandDoesNotExist(string message, string command): base($"'{command}': {message}")
        {

        }
    }
}
