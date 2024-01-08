using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.StackList
{
    //Represents a pair of stacks: one for directory operations and another for command history
    public class StackPair
    {
        //Fields to store actual stacks
        private Stack _dirStack { get ; set; }
        private Stack _cmdHistoryStack { get; set; }

        /// <summary>
        /// Get the directory stack, allowing the read-only access
        /// </summary>
        public Stack DirectoryStack { get { return _dirStack; } }

        /// <summary>
        /// Gets the command history stack, allowing the read-only access
        /// </summary>
        public Stack CommandHistoryStack { get { return _cmdHistoryStack; } }


        public StackPair()
        {
            //Creating a new pair of stacks
            _dirStack = new Stack();
            _cmdHistoryStack = new Stack();
        }
    }
}
