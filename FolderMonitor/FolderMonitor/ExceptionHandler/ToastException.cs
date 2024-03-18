using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.ExceptionHandler
{
    public class ToastException : IOException
    {
        public ToastException(string message) : base(message)
        {

        }
    }
}
