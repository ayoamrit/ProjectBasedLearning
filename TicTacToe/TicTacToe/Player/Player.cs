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

        //A reference to the Validate class to validate player move
        protected Validate? validate;

        public Player()
        {
            //Initialize the player character as 'O' be default
            this.player = 'O';
            //Initialize the Validate object for move validation
            this.validate = new Validate();
        }

        //method to get the player's symbol
        public char getPlayer()
        {
            return player;
        }
    }
}
