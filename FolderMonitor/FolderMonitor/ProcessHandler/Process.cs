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
        //Entry point for the process monitoring 
        public static void Begin()
        {
            //Start a new thread to handle the monitoring process
            Thread processThread = new Thread(ProcessHelper);
            processThread.Start();

            //Display a message indicating that monitoring has started
            Message(processThread);
        }

        //Method to perform the actual monitoring of folders
        private static void ProcessHelper()
        {

            //List to store the count of files in each folder being monitored
            IList<int> FilesList = new List<int>();

            //Loop through each folder to initialize the file count list
            for(int x = 0; x < FolderHandler.Folder.List.Count; x++)
            {

                //Get the current count of files in the folder
                int currentCount = Directory.GetFiles(FolderHandler.Folder.List[x], "*",SearchOption.TopDirectoryOnly).Length;

                //Add the count to the list
                FilesList.Add(currentCount);
            }

            //Init pointer
            int pointer = 0;

            //Continuous loop for monitoring
            while (true)
            {
                //Get the current count of files in the folder
                int currentCount = Directory.GetFiles(FolderHandler.Folder.List[pointer], "*", SearchOption.TopDirectoryOnly).Length;

                //Check if new files are added to the folder
                if(currentCount > FilesList[pointer])
                {
                    //Update the count in the list
                    FilesList[pointer] = currentCount;

                    //Display a toast notification for the new file
                    new ToastHandler.Toast("New File Added","New file has been added to the folder", FolderHandler.Folder.List[pointer]);
                }

                //Check if files are removed from the folder
                if(currentCount < FilesList[pointer])
                {
                    //Update the count in the list
                    FilesList[pointer] = currentCount;

                    //Display a toast notification for the removed file
                    new ToastHandler.Toast("A File Removed", "A file has been removed from the folder", FolderHandler.Folder.List[pointer]);
                }

                //Move to the next folder in the list
                if(pointer == FolderHandler.Folder.List.Count - 1)
                {
                    //Reset pointer to the first folder if at the end of the list
                    pointer = 0;
                }
                else
                {
                    //Move to the next folder
                    pointer++;
                }
            }

        }

        //Method to display monitoring message
        private static void Message(Thread processThread)
        {
            //Continuous display a message indicating that monitoring is active
            while (processThread.IsAlive)
            {
                //Clear the console to update the message
                Console.Clear();
                Console.Write("Monitoring");

                //Display the dots to indicate activity
                for(int x = 0; x < 3; x++)
                {
                    Console.Write(".");

                    //Pause for 5 seconds between each dot
                    Thread.Sleep(5000);
                }
            }
        }
    }
}
