using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.CommandHandler
{
    public class CommandAction : CommandList
    {

        public bool Validate(string? userCommand)
        {
            //check if the command is empty or null
            if (userCommand == null || userCommand == "")
            {
                return false;
            }
            else
            {
                //Split the user command into parts 
                string[] splitUserCommand = userCommand.Split(" ");

                //function to get the location of the prefix in the CommandsList
                //and check whether the command exist in the list or not 
                int commandLocationInList = ValidateCommandPrefix(splitUserCommand[0]);

                //function to check if the userCommand contain correct number of Suffix to execute the command
                ValidateCommandSuffix(splitUserCommand, commandLocationInList);

                //return true if userCommand is perfect
                return true;
            }


        }

        //Validate the command prefix (the first part of the userCommand)
        private int ValidateCommandPrefix(string? userCommand)
        {
            //perform a binary search to find the command in the list
            (bool flag, int commandLocationInList) = new SearchHandler.BinarySearch().Search(Commands, userCommand);

            if (flag)
            {
                //command found, return its location in the list
                return commandLocationInList;
            }
            else
            {
                //command not found, throw an exception
                throw new ExceptionHandler.CommandDoesNotExist("Command does not exist in the current interface", userCommand);
            }
        }

        //validates the command suffix(additional parts of the user command)
        private void ValidateCommandSuffix(string[] userCommand, int commandLocationInList)
        {
            int userCommandLength = userCommand.Length - 1;
            
            //check if the number of suffixes matches the required number for the command
            if(userCommandLength != Commands[commandLocationInList].SuffixRequired)
            {
                //Number of suffixes is invalid, throw an exception
                throw new ExceptionHandler.InvalidNumberOfSuffix("Command requires valid number of suffix to execute the function");
            }
        }
    }
}
