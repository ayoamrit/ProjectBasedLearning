using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsEngine.BoardHandler
{
    public class Board
    {
        //Number of rows
        private const int ROW = 25;

        //Number of columns 
        private const int COL = 120;

        public static int totalBoardRow { get { return ROW; } }
        public static int totalBoardColumn { get { return COL; } }

        //Board property
        public static char[,] _board { get; set; }


        //Constructor
        public Board()
        {
            _board = new char[ROW, COL];
            FillArray();
        }

        private void FillArray()
        {
            for(int x = 0; x < _board.GetLength(0); x++)
            {
                for(int y = 0; y < _board.GetLength(1); y++)
                {
                    _board[x, y] = ' ';
                }
            }
        }

        public static void RenderBoard()
        {
            for(int x = 0; x < _board.GetLength(0); x++)
            {
                for(int y = 0; y < _board.GetLength(1); y++)
                {
                    Console.Write(_board[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
