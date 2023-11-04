using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Game;

namespace TicTacToe.Player
{
    public class ComputerMove : Computer
    {
        Random random;

        //constructor to init the random number generator
        public ComputerMove()
        {
            random = new Random();
        }

        //function to get a random move for the computer (1, 9)
        public int getMove()
        {
            return random.Next(1, 10);
        }
    }
}
