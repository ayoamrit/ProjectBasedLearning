using ChessQueen.BoardHandler;

namespace ChessQueen
{

    //Find out all the valid moves that the queen is eligible to take.
    //All the moves are represented by number 1, # represents queens on the board
    public class Program
    {

        static void Main(string[] args)
        {
            
            //Call constructor to check for all possible moves
            new Moves();

            //Print entire board 
            BoardHandler.Board.DisplayBoard();

            //Print the kill list if there's a piece that could be terminated form that location
            PrintKillList();
        }

        private static void PrintKillList()
        {
            if(Moves.KillList.Count <= 0)
            {
                Console.WriteLine("No piece can be executed from this location");
                return;
            }

            int serialNumber = 1;
            foreach(var list in Moves.KillList)
            {
                Console.WriteLine($"{serialNumber}. Piece Position: xAxis => {list.XAxis} & yAxis => {list.YAxis}");
                Console.WriteLine($"    Piece Symbol:{list.Symbol}");
                Console.WriteLine($"    Message: {list.Message}");
            }
        }
    }
}