using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game.ActionHandler
{
    public class ActionHandler
    {
        private Stack stack;

        public ActionHandler(Stack stack)
        {
            this.stack = stack;
        }

        public bool undoMove()
        {

            return false;
        }

    }
}
