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
        protected Validate validate;

        public Computer()
        {
            this.computer = 'X';
            this.validate = new Validate();
        }

        public char getComputer()
        {
            return computer;
        }
    }
}
