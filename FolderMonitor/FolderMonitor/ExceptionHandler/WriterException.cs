using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.ExceptionHandler
{
    public class WriterException : IOException
    {
        public WriterException(string message) : base(message)
        {

        }
    }
}
