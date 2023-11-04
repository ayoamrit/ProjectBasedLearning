using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    public class GameBoard
    {

        public char[,] board = new char[5,5];


        //Constructor to initialize the game board with empty spaces and lines
        public GameBoard()
        {
            board = new char[,]
            {
                {' ','|',' ','|',' ' },
                { '-','-','-','-','-'},
                {' ','|',' ','|',' ' },
                { '-','-','-','-','-'},
                {' ','|',' ','|',' ' }
            };
        }

        //function to display the current state of the game board
        public void display()
        {
            for(int x = 0; x < board.GetLength(0); x++)
            {
                for(int y = 0; y < board.GetLength(1); y++)
                {
                    Console.Write(board[x, y]);
                }

                Console.WriteLine();  //leaving a line for better formatting
            }
        }
    }
}
