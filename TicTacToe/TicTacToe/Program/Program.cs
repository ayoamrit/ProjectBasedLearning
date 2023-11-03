namespace Program;
using TicTacToe.Game;
using TicTacToe.Player;

//Abstract class is a class that cannot be initiated in any other class.
//It is more like an incomplete class that you don't want anybody to access.
abstract class Program
{

    private static GameBoard gameBoard = new GameBoard();
    private static Player? player;
    private static Computer? computer;
    private static PlayerMove? playerMove;
    private static ComputerMove? computerMove;
    private static bool alive = true;

    //main method 
    public static void Main(string[] args)
    {
        gameBoard = new GameBoard();
        player = new Player();
        computer = new Computer();
        playerMove = new PlayerMove();
        computerMove = new ComputerMove();

        while (alive)
        {

        }
    }
}