using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.DirectoryHandler
{
    public class DirectoryAction
    {
        //Function to validate the _directory path
        protected bool Validate(string _directory)
        {
            //return true if the _directory exists
            if (System.IO.Directory.Exists(_directory))
            {
                return true;
            }
            //if not return false
            else
            {
                return false;
            }
        }

    }
}
