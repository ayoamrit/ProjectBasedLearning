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

            //Main program loop
            while (true)
            {
                try
                {
                    //Display the user prompt
                    StartPrompt();
                    int userChoice = Convert.ToInt32(Console.ReadLine());

                    if (ValidateChoice(userChoice))
                    {
                        //Process user choice
                        switch (userChoice)
                        {
                            //Add new folder to monitor
                            case 1:
                                {
                                    Console.WriteLine();  //Leave a line for better formatting

                                    Console.Write("Enter the folder path: ");
                                    string? folderPath = Console.ReadLine();  //Read folder path from user input

                                    FolderHandler.Folder.InsertPathToList(folderPath);  //Insert folder path to list

                                    break;
                                }
                            case 2:  //Show folders path
                                {
                                    //Display list of monitored folder path
                                    FolderHandler.Folder.ShowFolderList();
                                    break;
                                }
                            case 3: ProcessHandler.Process.Begin(); break;  //Begin the process to monitor paths
                            case 4:  //Save
                                {
                                    _write.SaveContent();  //Save content to file
                                    break;
                                }
                            case 5: Environment.Exit(0); break;  //Terminate program
                        }

                    }
                }
                catch (ExceptionHandler.ToastException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input Format Exception: The format that you used for the input is incorrect.\nUse a valid format and continue\n");
                }
                catch(ExceptionHandler.WriterException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception)
                {
                    Console.WriteLine("Error occurred: An unexpected error occurred during the execution of the program\n");
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

        //Method to check if the user's choice is valid or not 
        private static bool ValidateChoice(int choice)
        {
            return (choice > 0 && choice < 6);
        }
    }
}