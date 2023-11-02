using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses.Stack
{
    public class Stack
    {
        //To init size of the array
        private int maxSize { get; set; }

        //to store values
        private char[] chars { get; set; }

        //position of top most element
        private int top { get; set; }


        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
            this.chars = new char[maxSize];
            this.top = -1;
        }

        //function to push values onto the stack
        public void push(char c)
        {
            top++;
            chars[top] = c;
        }

        //function to remove value from the stack
        public void pop()
        {
            top--;
        }

        //function to check the value on the top of the stack
        public char peek()
        {
            return chars[top];
        }
    }
}
