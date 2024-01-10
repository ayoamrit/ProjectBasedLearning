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

                    if (_command.Validate(userCommand))
                    {
                        switch (_command.Prefix)
                        {
                            case "cd": break;
                            case "mkdir": break;
                            case "touch": break;
                            case "clear": break;
                            case "back": break;
                            case "history": new HistoryHandler.History(_stack.CommandHistoryStack);
                                    break;
                            default: throw new ExceptionHandler.NullPrefixFound("The prefix of the command has an invalid value");
                        }

                        //Push command to the stack once it has been validated and executed
                        PushCommandToStack(userCommand);
                    }

                }catch(ExceptionHandler.CommandDoesNotExist ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(ExceptionHandler.InvalidNumberOfSuffix ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ExceptionHandler.NullPrefixFound ex)
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

        private static void PushCommandToStack(string userCommand)
        {
            _stack.CommandHistoryStack.Push(userCommand);
        }
    }
}