using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    public class WinnerHandler
    {
        //function to check if either a computer or the player has won the game
        public bool checkWinner(char[,] gameBoard, char symbol)
        {
            if (gameBoard[0,0] == symbol && gameBoard[0,2] == symbol && gameBoard[0,4] == symbol || //first horizontal row
                gameBoard[2,0] == symbol && gameBoard[2,2] == symbol && gameBoard[2,4] == symbol || //second horizontal row
                gameBoard[4,0] == symbol && gameBoard[4,2] == symbol && gameBoard[4,4] == symbol || //third horizontal row
                gameBoard[0,0] == symbol && gameBoard[2,2] == symbol && gameBoard[4,4] == symbol || //diagonal
                gameBoard[0,4] == symbol && gameBoard[2,2] == symbol && gameBoard[4,0] == symbol || //diagonal
                gameBoard[0,0] == symbol && gameBoard[2,0] == symbol && gameBoard[4,0] == symbol || //first vertical column
                gameBoard[0,2] == symbol && gameBoard[2,2] == symbol && gameBoard[4,2] == symbol || //second vertical column
                gameBoard[0,4] == symbol && gameBoard[2,4] == symbol && gameBoard[4,4] == symbol)   //third vertical column
            {
                return true;
            }
            else
            {
                //No win condition has been met
                return false;
            }
        }
    }
}
