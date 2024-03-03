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

        //Method to list folderPaths
        public static void ShowFolderList()
        {
            int serialNumber = 1;
            foreach(var folderPath in List)
            {
                Console.WriteLine($"{serialNumber++}. {folderPath}");
            }

            Console.WriteLine();  //Leave a line for better formatting
        }

        //Method to insert folderPath to the list
        public static void InsertPathToList(string? folderPath)
        {

            //Check if the folderPath is empty or null
            if (String.IsNullOrEmpty(folderPath))
            {
                Console.WriteLine("'Empty value caught': Enter a value to proceed");
                return;
            }

            //Check if the folderPath already exists in the list or not
            if (List.Contains(folderPath))
            {
                Console.WriteLine($"{folderPath}: Path mentioned already exists in the list of paths");
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
