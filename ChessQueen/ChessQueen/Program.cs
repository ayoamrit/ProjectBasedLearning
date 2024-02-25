using ChessQueen.BoardHandler;

namespace ChessQueen
{

    //Find out all the valid moves that the queen is eligible to take.
    //All the moves are represented by number 1, # represents queens on the board
    public class Program
    {
        private static Moves queenMoves = new Moves();

        static void Main(string[] args)
        {
            queenMoves.StraightDown();
            queenMoves.StraightUp();


            //Display the board without showing moves that the queen could take
            BoardHandler.Board.DisplayBoard();

            ValidMoves();
        }

        private static void ValidMoves()
        {

        }
    }
}