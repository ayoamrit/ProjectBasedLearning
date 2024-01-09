using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.SearchHandler
{
    public class BinarySearch
    {
        //Binary Search function to locate the command in the command
        public (bool, int) Search(IList<CommandHandler.Command> list, string? target)
        {
            //Calling the helper method 
            return SearchHelper(list, target);
        }

        private (bool, int) SearchHelper(IList<CommandHandler.Command> list, string? target)
        {
            //Left pointer => pointing at the left side of the list
            int leftPointer = 0;

            //Right pointer => pointing at the right side of the list
            int rightPointer = list.Count - 1;

            while(leftPointer <= rightPointer)
            {
                //Get the midPoint
                int midPointer = (leftPointer + rightPointer) / 2;

                //Compare the listValue with the target value
                int comparisonResult = string.Compare(target, list[midPointer].CommandName);

                if(comparisonResult == 0)
                {
                    //When the target has been located
                    return (true, midPointer);
                }
                else if (comparisonResult < 0)
                {
                    //When the target value is greater than the list value
                    rightPointer = midPointer - 1;
                }
                else
                {
                    //When the target value is smaller than the list value
                    leftPointer = midPointer + 1;
                }
            }

            //return false if the target does not exist in the list
            return (false, -1);
        }
    }
}
