using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    public class GameBoard
    {

        public static char[,] gameBoard = new char[5,5];

        public GameBoard()
        {
            gameBoard = new char[,]
            {
                {' ','|',' ','|',' ' },
                { '-','-','-','-','-'},
                {' ','|',' ','|',' ' },
                { '-','-','-','-','-'},
                {' ','|',' ','|',' ' }
            };
        }

        public void display()
        {
            for(int x = 0; x < gameBoard.GetLength(0); x++)
            {
                for(int y = 0; y < gameBoard.GetLength(1); y++)
                {
                    Console.Write(gameBoard[x, y]);
                }

                Console.WriteLine();  //leaving a line for better formatting
            }
        }
    }
}
