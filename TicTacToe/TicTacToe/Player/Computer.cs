using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Game;

namespace TicTacToe.Player
{
    public class Computer
    {
        //represent the button assigned to the computer, either 'O' or 'X'
        private char computer { get; set; }

        public Computer()
        {

            //initialize the player character as 'O' by default
            this.computer = 'X';

        }

        //function to get computer's symbol
        public char getComputer()
        {
            return computer;
        }
    }
}
