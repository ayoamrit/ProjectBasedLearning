using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessQueen.BoardHandler
{
    public static class Board
    {
        public const int ROW = 10;
        public const int COLUMN = 10;

        public static int QueenX = 5;
        public static int QueenY = 5;
        public static string[,] ChessBoard = new string[ROW, COLUMN]
        {
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 "},
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 "},
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 "},
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 "},
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 "},
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " # ", " 0 ", " 0 ", " 0 ", " 0 "},
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 "},
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 "},
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " 0 "},
            { " 0 ", " 0 ", " 0 ", " 0 ", " 0 ", " & ", " 0 ", " 0 ", " 0 ", " 0 "}
        };

        public static void DisplayBoard()
        {
            //Row loop
            for(int x = 0; x < ChessBoard.GetLength(0); x++)
            {
                //Column loop
                for(int y = 0; y < ChessBoard.GetLength(1); y++)
                {
                    Console.Write($"{ChessBoard[x, y]} \t");
                }

                //Leave a line for better formatting
                Console.WriteLine();
            }
        }

    }
}
