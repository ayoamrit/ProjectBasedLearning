namespace Program;

using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using TicTacToe.CustomException;
using TicTacToe.Game;
using TicTacToe.Player;
using TicTacToe.Game.ActionHandler;
//Abstract class is a class that cannot be initiated in any other class.
//It is more like an incomplete class that you don't want anybody to access.
abstract class Program
{
    private static GameBoard? gameBoard;
    private static Validate? validate;
    private static Player? player;
    private static Computer? computer;
    private static PlayerMove? playerMove;
    private static ComputerMove? computerMove;
    private static WinnerHandler? winnerHandler;
    private static Stack? stack;
    private static bool alive = true;
    private static int totalPossibleMoves = 10;

    //main method 
    public static void Main(string[] args)
    {
        //Initialize objects used in the game
        gameBoard = new GameBoard();
        player = new Player();
        computer = new Computer();
        playerMove = new PlayerMove();
        validate = new Validate();
        computerMove = new ComputerMove();
        winnerHandler = new WinnerHandler();
        stack = new Stack(totalPossibleMoves);

        //display the initial game board
        gameBoard.display();

        //Enter the main game loop while the alive flag is true
        while (alive)
        {
            try
            {
                //Get the position selected by the player
                int playerSelectedPosition = playerMove.getMove();

                if (validate.isPositionEmpty(gameBoard.board, playerSelectedPosition))
                {
                    //If the position is empty, allow the player to make a move
                    validate.performAction(gameBoard.board, playerSelectedPosition, player.getPlayer());
                }
                else
                {
                    //if the position is not empty, throw  a custom exception
                    throw new PositionNotEmptyException(playerSelectedPosition);
                }


                //check if the player has won the game
                if(winnerHandler.checkWinner(gameBoard.board, player.getPlayer()))
                {
                    Console.WriteLine("***Player Won");
                    alive = false;  //end the game loop
                    break;
                }

                //Add a delay to make the game more interactive
                Thread.Sleep(500);

                //Initialize a flag for computer's turn
                bool flag = true;
                while (flag)
                {
                    //Get the position selected by the computer
                    int computerSelectedPosition = computerMove.getMove();

  
                    if (validate.isPositionEmpty(gameBoard.board, computerSelectedPosition))
                    {
                        //If the position is empty, allow the computer to make a move
                        validate.performAction(gameBoard.board, computerSelectedPosition, computer.getComputer());

                        //exit the loop
                        flag = false;
                    }
                    else
                    {
                        //If the position is not empty, generate a new random number to get an empty position
                        continue;
                    }
                    
                }


                //check if the computer has won the game
                if(winnerHandler.checkWinner(gameBoard.board, computer.getComputer()))
                {
                    Console.WriteLine("***Computer Won");
                    alive = false; //exit the game loop
                    break;
                }


            }catch(PositionNotEmptyException e)
            {
                //Handle the specific exception when a position is not empty
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
            }
            finally
            {
                //Display the gameboard at the end of each turn
                gameBoard.display();
            }
            
        }
    }
}