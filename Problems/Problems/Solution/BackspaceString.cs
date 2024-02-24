using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Solution
{
    public class BackspaceString
    {
        public BackspaceString()
        {
            string firstString = "aaa###a";
            string secondString = "aaaa###a";

            Console.WriteLine(BackSpaceContain(firstString, secondString));
        }

        private bool BackSpaceContain(string first, string second)
        {
            return GetString(first) == GetString(second);
        }

        private string GetString(string temp)
        {
            Stack<char> tempStack = new Stack<char>();

            for(int x = 0; x < temp.Length; x++)
            {
                char selectedChar = temp[x];

                if(selectedChar != '#')
                {
                    tempStack.Push(selectedChar);
                }
                else
                {
                    if(tempStack.Count != 0)
                    {
                        tempStack.Pop();
                    }
                }
            }

            string tempString = String.Empty;
            int stackCount = tempStack.Count;

            for(int x = 0; x < stackCount; x++)
            {
                tempString += tempStack.Pop();
            }

            return tempString;

        }
    }
}
