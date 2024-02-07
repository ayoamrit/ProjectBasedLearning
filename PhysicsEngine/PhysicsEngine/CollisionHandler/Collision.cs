using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsEngine.CollisionHandler
{
    public class Collision
    {
        private static int RigidPlayerRow = 0;
        private const int RigidPlayerColumn = 56;
        private const int RigidBodyRows = 5;
        private const int RigidBodyColumns = 15;

        public Collision()
        {
            AddBodyToBoard();
            AddPlayerToBoard();

            if (CollisionLoop())
            {
                Console.WriteLine("The player body did not come in contact with a rigid body on its way down to the bottom");
            }
            else
            {
                Console.WriteLine("The player body came in contact with a rigid body on its way down to the bottom");
            }
        }

        private void AddBodyToBoard()
        {
            int startRow = 10;
            int startCol = 50;

            for(int x = startRow; x < startRow + RigidBodyRows ; x++)
            {
                for(int y = startCol; y < startCol + RigidBodyColumns; y++)
                {
                    BoardHandler.Board._board[x, y] = '#';
                }
            }
        }

        private void AddPlayerToBoard()
        {
            BoardHandler.Board._board[RigidPlayerRow, RigidPlayerColumn] = '@';
        }

        private bool CollisionLoop()
        {
            int rigidPlayerX = RigidPlayerRow;
            int numberOfRows = BoardHandler.Board.totalBoardRow;

            while(rigidPlayerX < numberOfRows)
            {

                if (BoardHandler.Board._board[rigidPlayerX + 1, RigidPlayerColumn] == '#')
                {
                    return false;
                }
                BoardHandler.Board._board[rigidPlayerX, RigidPlayerColumn] = ' ';
                rigidPlayerX++;
                BoardHandler.Board._board[rigidPlayerX, RigidPlayerColumn] = '@';

                System.Console.Clear();
                BoardHandler.Board.RenderBoard();

                Thread.Sleep(500);
            }

            return true;
        }
    }
}
