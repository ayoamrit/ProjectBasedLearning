using System.Xml.Serialization;
using CodeShell.StackList;

namespace CodeShell
{
    public class Program
    {
        private static StackPair _stack = new StackPair();
        private static CommandHandler.CommandAction _command = new CommandHandler.CommandAction();
        private static DirectoryHandler.Directory _directory = new DirectoryHandler.Directory();

        public static void Main(string[] args)
        {
            foreach(var command in _command.Commands)
            {
                Console.WriteLine(command.CommandName);
            }
            MainLoop();

        }

        private static void MainLoop()
        {

            while (true)
            {
                try
                {
                    Console.Write($"{_directory.CurrentDirectory}> ");
                    string? userCommand = GetUserCommand();
                    Console.WriteLine(_command.Validate(userCommand));

                }catch(ExceptionHandler.CommandDoesNotExist ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(ExceptionHandler.InvalidNumberOfSuffix ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        //Function to get commands from the user to perform further actions
        private static string? GetUserCommand()
        {
            return Console.ReadLine();
        }
    }
}