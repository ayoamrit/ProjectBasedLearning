using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public static void ShowFolderList()
        {
            int serialNumber = 1;
            foreach(var folderPath in List)
            {
                Console.WriteLine($"{serialNumber++}. {folderPath}");
            }
        }

        public static void InsertPathToList(string? folderPath)
        {

            if (String.IsNullOrEmpty(folderPath))
            {
                Console.WriteLine("'Empty value caught': Enter a value to proceed");
                return;
            }

            //if the folderPath exists in the system
            if (Path.Exists(folderPath))
            {
                List.Add(folderPath);
            }
            else
            {
                Console.WriteLine($"'{folderPath}': The path does not exist in your system.\n Enter valid path to proceed");
            }
        }
        
    }
}
