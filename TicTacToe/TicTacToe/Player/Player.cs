using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Player
{
    public class Player
    {
        //object of player to store the selected button by the user to play the game, either 'O' or 'X'
        private char player { get; set; }

        public Player(char player)
        {
            this.player = player;
        }

        public char getPlayer()
        {
            return player;
        }
    }
}
