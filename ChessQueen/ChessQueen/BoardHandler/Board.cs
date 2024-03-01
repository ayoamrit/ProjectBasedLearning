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
        
        private static readonly char[] Alphabets = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

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

            for(int x = 0; x < Alphabets.Length; x++)
            {
                Console.Write($"  {Alphabets[x]} \t");
            }

            Console.WriteLine();

            //Row loop
            for(int x = 0; x < ChessBoard.GetLength(0); x++)
            {
                Console.Write($"{Alphabets[x]}");
                //Column loop
                for(int y = 0; y < ChessBoard.GetLength(1); y++)
                {
                    Console.Write($" {ChessBoard[x, y]} \t");
                }

                //Leave a line for better formatting
                Console.WriteLine();
            }
        }

    }
}
