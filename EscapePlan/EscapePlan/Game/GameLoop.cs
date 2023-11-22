using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapePlan.Game
{
    public class GameLoop
    {
        private ThreadStart threadStart { get; set; }
        private Thread thread { get; set; }
        private GameBoard gameBoard;
        private bool gameFlag { get; set; }

        public GameLoop()
        {
            gameBoard = new GameBoard();
            gameFlag = true;
            threadStart = new ThreadStart(this.Run);
            thread = new Thread(this.threadStart);
            thread.Start();
        }

        public void Run()
        {
            while (gameFlag)
            {
                Update();
                Thread.Sleep(200);
                Console.Clear();
            }
        }

        public void Update()
        {
            gameBoard.DisplayBoard();
        }
    }
}
