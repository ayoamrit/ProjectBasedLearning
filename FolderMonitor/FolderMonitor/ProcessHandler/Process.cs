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
                }
            }
        }
    }
}
