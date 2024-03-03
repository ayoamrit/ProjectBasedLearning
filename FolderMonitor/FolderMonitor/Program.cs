using FolderMonitor.FileHandler;

namespace FolderMonitor
{
    public class Program
    {
        //Constant file path for the file to be read
        private const string _path = "ReaderContent.txt";

        //Static instances of Folder and Read classes
        static FolderHandler.Folder _folder;
        static FileHandler.Write _write;

        //Main method
       public static void Main(string[] args)
       {
            //Initialize Folder and Read instances
            _folder = new FolderHandler.Folder();
            _write = new FileHandler.Write();
            new FileHandler.Read();

            //Check if there are any folder paths to monitor
            if (FolderHandler.Folder.IsEmpty)
            {
                //If no paths are found, prompt the user to add paths
                Console.WriteLine("There are no folder paths found to monitor. Add Paths to get things going.....");
            }

            while (true)
            {
                StartPrompt();
                int userChoice = Convert.ToInt32(Console.ReadLine());

                if (ValidateChoice(userChoice))
                {
                    switch (userChoice)
                    {
                        case 1:
                            {
                                Console.WriteLine();  //Leave a line for better formatting

                                Console.Write("Enter the folder path: ");
                                string? folderPath = Console.ReadLine();

                                FolderHandler.Folder.InsertPathToList(folderPath);

                                break;
                            }
                        case 2:
                            {
                                FolderHandler.Folder.ShowFolderList();
                                break;
                            }
                        case 3: StartProcess();  break;
                        case 4:
                            {
                                _write.SaveContent();
                                break;
                            }
                        case 5: Environment.Exit(0); break;
                    }
                }
            }
       }

        private static void StartPrompt()
        {
            Console.WriteLine("1. Add new folder to monitor");
            Console.WriteLine("2. Show folders path");
            Console.WriteLine("3. Start process");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Terminate program");
            Console.Write("Your choice: ");
        }

        private static bool ValidateChoice(int choice)
        {
            return (choice > 0 && choice < 6);
        }


        private static void StartProcess()
        {

        }
    }
}