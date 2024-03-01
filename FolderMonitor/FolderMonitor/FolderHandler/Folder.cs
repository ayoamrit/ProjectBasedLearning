using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.FolderHandler
{
    public class Folder
    {
        public static IList<string> List { get; private set; }
        public static bool IsEmpty
        {
            get
            {
                return List.Count == 0;
            }
        }

        public Folder()
        {
            List = new List<string>();
        }
        
    }
}
