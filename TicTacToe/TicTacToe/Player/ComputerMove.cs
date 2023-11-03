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

        public ComputerMove()
        {
            random = new Random();
        }

        public int getMove()
        {
            return random.Next(0, 11);
        }
    }
}
