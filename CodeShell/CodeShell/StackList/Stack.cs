using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.StackList
{
    public class Stack
    {
        private ListNode StackNode { get; set; }

        //Constructor
        public Stack()
        {
            //Initialize the StackNode
            StackNode = new ListNode();

        }

        //Push elements to start of the StackNode
        public void Push(string value)
        {
            ListNode newNode = new ListNode(value, StackNode);
            StackNode = newNode;
        }

        //Remove the last added element from the stack
        public void Pop()
        {
            ListNode tempStack = StackNode.Next;
            StackNode = tempStack;
        }

        //Peek at the last added element in the stack
        public string Peek()
        {
            return StackNode.Value;
        }
    }
}
