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
        public int getMove()
        {
            Console.Write("Place Your Symbol: ");
            string? userInput = Console.ReadLine();

            if (validate.isValueValid(userInput))
            {
                return Convert.ToInt32(userInput);
            }
            else
            {
                return 0;
            }
        }
    }
}
