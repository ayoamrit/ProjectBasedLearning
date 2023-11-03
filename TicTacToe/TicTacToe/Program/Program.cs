namespace Program;
using TicTacToe.Game;
using TicTacToe.Player;
using TicTacToe.Prompt;

//Abstract class is a class that cannot be initiated in any other class.
//It is more like an incomplete class that you don't want anybody to access.
abstract class Program
{

    private static GameBoard gameBoard = new GameBoard();
    private static Prompt prompt = new Prompt();
    private static Player player;
    private static Computer computer;

    //main method 
    public static void Main(string[] args)
    {
        gameBoard.display();

        char selectedSymbol = prompt.getSymbol();

        if(selectedSymbol == 'X')
        {
            player = new Player(selectedSymbol);
            computer = new Computer('O');
        }
        else
        {
            player = new Player(selectedSymbol);
            computer = new Computer('X');
        }

        Console.WriteLine("Player: "+player.getPlayer());
        Console.WriteLine("Computer: "+computer.getComputer());

    }
}