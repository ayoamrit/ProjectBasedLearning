using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.CustomException;
using TicTacToe.Game;

namespace TicTacToe.Player
{
    public class PlayerMove : Player
    {
        //function to get the player's move
        public int getMove()
        {
            Console.Write("Place Your Symbol: ");
            string? userInput = Console.ReadLine();

            if (validate.isValueValid(userInput))
            {
                //if the user input is valid, convert it to an integer and return
                return Convert.ToInt32(userInput);
            }
            else
            {
                //if the input is not valid
                return 0;
            }
        }
    }
}
