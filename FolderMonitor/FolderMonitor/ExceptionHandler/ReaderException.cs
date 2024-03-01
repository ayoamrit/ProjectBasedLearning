using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.ExceptionHandler
{
    public class ReaderException : IOException
    {
        public ReaderException(string message) : base(message)
        {

        }
    }
}
