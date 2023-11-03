using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Player
{
    public class Computer
    {
        //represent the button assigned to the computer, either 'O' or 'X'
        private char computer { get; set; }

        public Computer(char computer)
        {
            this.computer = computer;
        }

        public char getComputer()
        {
            return computer;
        }
    }
}
