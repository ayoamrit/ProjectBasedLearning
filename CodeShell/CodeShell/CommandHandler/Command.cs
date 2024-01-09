using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.CommandHandler
{
    public class Command
    {
        //Gets or sets the name of the command
        public string CommandName { get; set; }

        //Gets ot sets the description of the command
        public string Description { get; set; }

        public int SuffixRequired { get; set; }

        //Constructor to init the Command object with a name and description
        public Command(string CommandName, string Description, int SuffixRequired)
        {
            this.CommandName = CommandName;
            this.Description = Description;
            this.SuffixRequired = SuffixRequired;
        }
    }
}
