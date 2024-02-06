using SpaceInvader.BoardHandler;

namespace SpaceInvader
{
    public class Program
    {
        //Init objects
        static BoardHandler.GameBoard gameBoard;
        static PlayerHandler.Player player;
        static Random random = new Random();

        private static void Main(string[] args)
        {
            Thread keyThread = new Thread(MovePlayer);
            (int playerX, int playerY) = RandomPlayerPosition();
            player = new PlayerHandler.Player(playerX, playerY);
            gameBoard = new GameBoard(playerX, playerY);

            keyThread.Start();
            GameLoop();
        }

        private static void GameLoop()
        {
            while (true)
            {
                System.Console.Clear();
                gameBoard.RenderBoard();

                Thread.Sleep(200);
            }
        }

        private static void MovePlayer()
        {
            while (true)
            {
                char keyPressed = Console.ReadKey().KeyChar;

                if (keyPressed == 'A' || keyPressed == 'a')
                {
                    PlayerHandler.Player.playerY--;
                }

                if(keyPressed == 'S' || keyPressed == 's')
                {
                    PlayerHandler.Player.playerX++;
                }

                if(keyPressed == 'W' || keyPressed == 'w')
                {
                    PlayerHandler.Player.playerX--;
                }

                if(keyPressed == 'D' || keyPressed == 'd')
                {
                    PlayerHandler.Player.playerY++;
                }
            }

        }

        private static (int, int) RandomPlayerPosition()
        {
            int playerX = random.Next(0, 10);
            int playerY = random.Next(0, 10);

            return (playerX, playerY);
        }
    }
}