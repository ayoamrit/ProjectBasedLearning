using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CodeShell.ExceptionHandler;
using CodeShell.StackList;

namespace CodeShell.DirectoryHandler
{
    public class Directory : DirectoryAction
    {
        private string _directory { get; set; } = "D:\\";
        public string CurrentDirectory => _directory;

        public bool Exists(string newDirectory) => Validate(newDirectory);
    }
}
