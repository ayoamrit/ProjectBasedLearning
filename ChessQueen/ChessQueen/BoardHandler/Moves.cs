using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessQueen.BoardHandler
{
    public class Moves
    {
        
        public void StraightDown()
        {
            for(int x = Board.QueenX + 1; x < Board.ROW; x++)
            {

                if (Board.ChessBoard[x, Board.QueenY].Equals(" & "))
                {
                    break;
                }
                Board.ChessBoard[x, Board.QueenY] = " 1 ";
            }
        }

        public void StraightUp()
        {
            for(int x = Board.QueenX - 1; x >= 0; x--)
            {
                if (Board.ChessBoard[x, Board.QueenY].Equals(" & "))
                {
                    break;
                }

                Board.ChessBoard[x, Board.QueenY] = " 1 ";
            }
        }

        public void StraightLeft()
        {

        }

        public void StraightRight()
        {

        }

        public void Diagonal()
        {

        }
    }
}
