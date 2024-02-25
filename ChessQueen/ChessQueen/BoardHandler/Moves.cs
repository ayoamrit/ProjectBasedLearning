using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessQueen.BoardHandler
{
    public class Moves
    {
        public static IList<KillHandler> KillList;

        public Moves()
        {
            KillList = new List<KillHandler>();
            StraightDown();
            StraightUp();
            StraightLeft();
            StraightRight();
            Diagonal();
        }
        
        //Down from the current location
        private void StraightDown()
        {
            for(int x = Board.QueenX + 1; x < Board.ROW; x++)
            {
                if(!IsMoveValid(x, Board.QueenY))
                {
                    AddKillToList(x, Board.QueenY, "Proceed downwards to kill");
                    break;
                }

                Board.ChessBoard[x, Board.QueenY] = " 1 ";
            }
        }

        //Up from the current location
        private void StraightUp()
        {
            for(int x = Board.QueenX - 1; x >= 0; x--)
            {
                if(!IsMoveValid(x, Board.QueenY))
                {
                    AddKillToList(x, Board.QueenY, "Proceed upwards to kill");
                    break;
                }

                Board.ChessBoard[x, Board.QueenY] = " 1 ";
            }
        }

        //Left from the current location
        private void StraightLeft()
        {
            for(int x = Board.QueenY - 1; x >= 0; x--)
            {
                if(!IsMoveValid(Board.QueenX, x))
                {
                    AddKillToList(Board.QueenX, x, "Proceed left to kill");
                    break;
                }

                Board.ChessBoard[Board.QueenX, x] = " 1 ";
            }
        }

        //Right from the current location
        private void StraightRight()
        {
            for(int x = Board.QueenY + 1; x < Board.COLUMN; x++)
            {

                if(!IsMoveValid(Board.QueenX, x))
                {
                    AddKillToList(Board.QueenX, x, "Proceed right to kill");
                    break;
                }

                Board.ChessBoard[Board.QueenX, x] = " 1 ";
            }
        }

        private void Diagonal()
        {
            int xAxis = Board.QueenX - 1;
            int yAxis = Board.QueenY + 1;

            //Right up
            while(xAxis >= 0 && yAxis < Board.COLUMN)
            {

                if(!IsMoveValid(xAxis, yAxis))
                {
                    AddKillToList(xAxis, yAxis, "Proceed right up diagonally to kill");
                    break;
                }

                Board.ChessBoard[xAxis, yAxis] = " 1 ";
                xAxis--;
                yAxis++;
            }

            xAxis = Board.QueenX + 1;
            yAxis = Board.QueenY - 1;

            //Left down
            while(xAxis < Board.ROW && yAxis >= 0)
            {

                if(!IsMoveValid(xAxis, yAxis))
                {
                    AddKillToList(xAxis, yAxis, "Proceed left down diagonally to kill");
                    break;
                }

                Board.ChessBoard[xAxis, yAxis] = " 1 ";
                xAxis++;
                yAxis--;
            }

            xAxis = Board.QueenX + 1;
            yAxis = Board.QueenY + 1;

            //Right down
            while(xAxis < Board.ROW && yAxis <= Board.COLUMN)
            {

                if(!IsMoveValid(xAxis, yAxis))
                {
                    AddKillToList(xAxis, yAxis, "Proceed right down diagonally to kill");
                    break;
                }

                Board.ChessBoard[xAxis, yAxis] = " 1 ";
                xAxis++;
                yAxis++;
            }

            xAxis = Board.QueenX - 1;
            yAxis = Board.QueenY - 1;

            //Left up
            while(xAxis >= 0 && yAxis >= 0)
            {

                if(!IsMoveValid(xAxis, yAxis))
                {
                    AddKillToList(xAxis, yAxis, "Proceed left up diagonally to kill");
                    break;
                }

                Board.ChessBoard[xAxis, yAxis] = " 1 ";
                xAxis--;
                yAxis--;
            }
        }

        /// <summary>
        /// Check if the move is valid
        /// </summary>
        /// <param name="xAxis">position on x axis</param>
        /// <param name="yAxis">position on y axis</param>
        /// <returns>TRUE if move is valid</returns>
        private bool IsMoveValid(int xAxis, int yAxis)
        {
            //" 0 " represents the location is empty
            if (Board.ChessBoard[xAxis, yAxis].Equals(" 0 "))
            {
                return true;
            }

            return false;
        }

        private void AddKillToList(int xAxis, int yAxis, string message)
        {
            string symbol = Board.ChessBoard[xAxis, yAxis];
            KillList.Add(new KillHandler(xAxis + 1, yAxis + 1, symbol, message));
        }
    }
}
