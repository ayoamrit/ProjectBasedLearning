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
            //Init properties
            gameBoard = new GameBoard();
            gameFlag = true;

            //ThreadStart instance pointing to the Run function
            threadStart = new ThreadStart(this.Run);

            //Thread with specified ThreadStart
            thread = new Thread(this.threadStart);

            //Start the thread
            thread.Start();
        }

        //Function that runs the game loop
        public void Run()
        {
            while (gameFlag)
            {
                Update();

                //Pause for 200ms to control the loop speed
                Thread.Sleep(200);

                //Clear console to refresh the display
                Console.Clear();
            }
        }

        //diplay the current state of game board
        public void Update()
        {
            gameBoard.DisplayBoard();
        }
    }
}
