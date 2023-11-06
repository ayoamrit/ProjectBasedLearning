using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game.ActionHandler
{
    public class Stack
    {
        private int maxSize { get; set; }
        private int top { get; set; }
        private int[]? stackArray { get; set; }

        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
            this.stackArray = new int[maxSize];
            this.top = -1;
        }

        public void push(int value)
        {
            top++;
            stackArray[top] = value;
        }

        public void pop()
        {
            top--;
        }

        public int peek()
        {
            return stackArray[top];
        }
    }
}
