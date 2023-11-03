using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Game;

namespace TicTacToe.Player
{
    public class Player
    {
        //object of player to store the selected button by the user to play the game, either 'O' or 'X'
        private char player { get; set; }
        protected Validate validate;

        public Player()
        {
            this.player = 'O';
            this.validate = new Validate();
        }

        public char getPlayer()
        {
            return player;
        }
    }
}
