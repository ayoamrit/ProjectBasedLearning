using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.CommandHandler
{
    public class CommandList
    {
        //Field to store list of commands
        private List<Command> _commands { get; set; }
        public IList<Command> Commands { get { return _commands; } }

        //Constructor to init the commandList and populate it with predefined commands
        public CommandList()
        {
            _commands = PushCommands();
            SortCommandList();
        }

        //Adds predefined commands to the list
        private List<Command> PushCommands()
        {
            return new List<Command>
            {
                new Command("cd", "This command can be used to move across different directories/folders.", 1),
                new Command("mkdir", "This command can be used to create new directories/folders.", 1),
                new Command("touch", "This command can be used to create new files.", 1),
                new Command("clear", "This command can be used to clear the console.", 0),
                new Command("back", "This command can be used to move back to previous directory/folder.", 0)
            };
        }

        private void SortCommandList()
        {
            _commands.Sort((leftPointer, rightPointer) => leftPointer.CommandName.CompareTo(rightPointer.CommandName));
        }
    }
}
