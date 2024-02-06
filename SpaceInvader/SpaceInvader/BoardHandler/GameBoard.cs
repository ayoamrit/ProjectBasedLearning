using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader.BoardHandler
{
    public class GameBoard
    {
        private char[,] gameBoard = new char[10, 10];

        public GameBoard(int playerX, int playerY)
        {
            RenderBoard();
        }

        public void RenderBoard()
        {
            for(int x = 0; x < gameBoard.GetLength(0); x++)
            {

                for(int z = 0; z < gameBoard.GetLength(1); z++)
                {
                    gameBoard[x, z] = ' ';
                    Console.WriteLine(gameBoard[x, z]);
                }
                Console.WriteLine();
            }

            gameBoard[PlayerHandler.Player.playerX, PlayerHandler.Player.playerY] = '#';
        }
    }
}
