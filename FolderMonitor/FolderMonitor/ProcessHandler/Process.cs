using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FolderMonitor.ProcessHandler
{
    public class Process
    {
        public static void Begin()
        {
            Thread processThread = new Thread(ProcessHelper);
            processThread.Start();
            Message(processThread);
        }

        private static void ProcessHelper()
        {
            IList<int> FilesList = new List<int>();

            for(int x = 0; x < FolderHandler.Folder.List.Count; x++)
            {
                int currentCount = Directory.GetFiles(FolderHandler.Folder.List[x], "*",SearchOption.TopDirectoryOnly).Length;

                FilesList.Add(currentCount);
            }

            int pointer = 0;
            while (true)
            {
                int currentCount = Directory.GetFiles(FolderHandler.Folder.List[pointer], "*", SearchOption.TopDirectoryOnly).Length;

                if(currentCount > FilesList[pointer])
                {
                    FilesList[pointer] = currentCount;
                    new ToastHandler.Toast("New file has been added to the folder", FolderHandler.Folder.List[pointer]);
                }

                if(pointer == FolderHandler.Folder.List.Count - 1)
                {
                    pointer = 0;
                }
            }

        }

        private static void Message(Thread processThread)
        {
            while (processThread.IsAlive)
            {
                Console.Clear();
                Console.Write("Monitoring");

                for(int x = 0; x < 3; x++)
                {
                    Console.Write(".");
                    Thread.Sleep(5000);
                }
            }
        }
    }
}
