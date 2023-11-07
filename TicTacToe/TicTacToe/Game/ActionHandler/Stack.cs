using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game.ActionHandler
{
    public class Stack
    {
        //max size of the stack
        private int maxSize { get; set; }

        //index of the top of the stack
        private int top { get; set; }

        //array to hold the stack elements
        private int[]? stackArray { get; set; }


        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
            this.stackArray = new int[maxSize];
            this.top = -1;  //init the top to -1 since the stack is empty
        }


        //push value onto the stack
        public void push(int value)
        {
            top++;
            stackArray[top] = value;
        }

        //pop the top element from the stack
        public void pop()
        {
            top--;
        }

        //peek at the top element of the stack
        public int peek()
        {
            return stackArray[top];
        }
    }
}
