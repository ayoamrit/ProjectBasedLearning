using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.ExceptionHandler
{
    public class DirectoryNotFoundException : IOException
    {
        public DirectoryNotFoundException( string directory, string message) : base($"'{directory}': {message}")
        {
            
        }
    }
}
