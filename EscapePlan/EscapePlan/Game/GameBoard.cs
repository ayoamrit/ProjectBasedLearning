using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapePlan.Game
{
    public class GameBoard
    {
        private static char[,] gameBoard { get; set; }
        private static int currentPlayerPositionX { get; set; }
        private static int currentPlayerPositionY { get; set; }
        private static ValidateMove validateMove;

        public GameBoard()
        {
            gameBoard = new char[20, 20] {
                {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
                {'1', ' ', ' ', ' ', ' ', ' ', '1', ' ', ' ', ' ', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
                {'1', '1', '1', ' ', '1', ' ', '1', ' ', '1', ' ', ' ', ' ', ' ', '1', '1', '1', '1', '1', '1', '1'},
                {'1', '1', '1', ' ', '1', ' ', '1', ' ', '1', '1', '1', '1', ' ', ' ', ' ', '1', ' ', ' ', ' ', '1'},
                {'1', ' ', ' ', ' ', '1', ' ', '1', ' ', ' ', ' ', '1', '1', ' ', '1', ' ', '1', ' ', '1', ' ', '1'},
                {'1', '1', '1', ' ', '1', ' ', '1', ' ', '1', ' ', ' ', '1', ' ', '1', ' ', '1', ' ', '1', ' ', '1'},
                {'1', '1', '1', ' ', '1', ' ', '1', ' ', '1', '1', ' ', '1', ' ', '1', ' ', '1', ' ', '1', ' ', '1'},
                {'1', ' ', '1', ' ', '1', ' ', '1', ' ', ' ', '1', ' ', '1', ' ', '1', ' ', ' ', ' ', '1', ' ', '1'},
                {'1', '1', ' ', ' ', '1', ' ', ' ', '1', ' ', '1', ' ', '1', ' ', '1', ' ', '1', '1', '1', ' ', '1'},
                {'1', ' ', ' ', '1', '1', '1', '1', '1', ' ', '1', ' ', '1', ' ', '1', ' ', ' ', '1', ' ', ' ', '1'},
                {'1', '1', '1', ' ', ' ', ' ', ' ', ' ', ' ', '1', ' ', '1', '1', '1', ' ', '1', '1', ' ', '1', '1'},
                {'1', '1', '1', ' ', '1', ' ', '1', ' ', '1', '1', '1', '1', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '1'},
                {'1', ' ', ' ', ' ', '1', ' ', '1', ' ', '1', ' ', ' ', '1', ' ', ' ', '1', ' ', '1', '1', ' ', '1'},
                {'1', ' ', '1', ' ', ' ', ' ', '1', ' ', '1', ' ', '1', '1', '1', ' ', '1', ' ', '1', '1', ' ', '1'},
                {'1', ' ', '1', '1', '1', '1', '1', ' ', '1', '1', ' ', ' ', '1', ' ', '1', ' ', '1', ' ', ' ', '1'},
                {'1', ' ', ' ', ' ', '1', '1', '1', ' ', '1', '1', '1', ' ', '1', ' ', '1', ' ', '1', '1', ' ', '1'},
                {'1', '1', '1', ' ', '1', '1', '1', ' ', ' ', ' ', '1', ' ', '1', ' ', '1', ' ', '1', '1', ' ', '1'},
                {'1', ' ', ' ', ' ', '1', '1', '1', ' ', '1', ' ', '1', ' ', ' ', ' ', ' ', ' ', '1', ' ', ' ', '1'},
                {'1', ' ', '1', '1', '1', '1', '1', ' ', ' ', ' ', '1', '1', '1', '1', '1', '1', '1', ' ', '1', '1'},
                {'1', ' ', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', ' ', ' ', ' ', '1'}
            };

            currentPlayerPositionX = 19;
            currentPlayerPositionY = 1;
            validateMove = new ValidateMove();
        }

        public void DisplayBoard()
        {
            for(int x = 0; x < gameBoard.GetLength(0); x++)
            {
                for(int y = 0; y < gameBoard.GetLength(1); y++)
                {
                    Console.Write(gameBoard[x, y]);
                }
                Console.WriteLine();
            }
        }

        public static void UpdateBoard(ConsoleKeyInfo keyInfo)
        {
            if(keyInfo.Key == ConsoleKey.Enter)
            {
                gameBoard[currentPlayerPositionX, currentPlayerPositionY] = '0';
            }
            else if(keyInfo.Key == ConsoleKey.D)
            {
                if (validateMove.CheckMove(gameBoard, currentPlayerPositionX, currentPlayerPositionY + 1))
                {
                    UpdateMove(currentPlayerPositionX, currentPlayerPositionY, ' ');
                    UpdateMove(currentPlayerPositionX, currentPlayerPositionY + 1, '0');

                    currentPlayerPositionY++;
                }
                
            }
            else if(keyInfo.Key == ConsoleKey.S)
            {
                if (validateMove.CheckMove(gameBoard, currentPlayerPositionX + 1, currentPlayerPositionY))
                {
                    UpdateMove(currentPlayerPositionX, currentPlayerPositionY, ' ');
                    UpdateMove(currentPlayerPositionX + 1, currentPlayerPositionY, '0');

                    currentPlayerPositionX++;
                }
            }
            else if (keyInfo.Key == ConsoleKey.W)
            {
                if (validateMove.CheckMove(gameBoard, currentPlayerPositionX - 1, currentPlayerPositionY))
                {
                    UpdateMove(currentPlayerPositionX, currentPlayerPositionY, ' ');
                    UpdateMove(currentPlayerPositionX - 1, currentPlayerPositionY, '0');
                    currentPlayerPositionX--;
                }
            }
            else if (keyInfo.Key == ConsoleKey.A)
            {
                if (validateMove.CheckMove(gameBoard, currentPlayerPositionX, currentPlayerPositionY - 1))
                {
                    UpdateMove(currentPlayerPositionX, currentPlayerPositionY, ' ');
                    UpdateMove(currentPlayerPositionX, currentPlayerPositionY - 1, '0');
                    currentPlayerPositionY--;
                }
            }
        }

        private static void UpdateMove(int x, int y, char value)
        {
            gameBoard[x, y] = value;
        }
    }
}
