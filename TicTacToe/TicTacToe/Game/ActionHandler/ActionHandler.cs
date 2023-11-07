using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.CustomException;

namespace TicTacToe.Game.ActionHandler
{
    public class ActionHandler
    {
        private Stack stack;
        private Validate validate;
        private char[,] gameBoard;

        public ActionHandler(Stack stack, Validate validate, char[,] gameBoard)
        {
            this.stack = stack;
            this.validate = validate;
            this.gameBoard = gameBoard;
        }

        //push the player's move position onto the stack
        public void pushToStack(int position)
        {
            stack.push(position);
        }

        //undo the last two moves (player and computer)
        public bool undoMove()
        {
            try
            {
                for (int x = 0; x < 2; x++)
                {
                    int boardPosition = stack.peek();
                    (int row, int col) position = validate.getPosition(boardPosition);

                    //update the board by removing last two moves
                    updateBoard(position.row, position.col);

                    //remove the position from the stack
                    stack.pop();
                }

                return true;

            }catch(Exception)
            {
                //In case of any error, throw an UndoException
                throw new UndoException();
            }
        }

        //update the gameBoard by clearing a cell
        private void updateBoard(int row, int col)
        {
            gameBoard[row, col] = ' ';
        }
    }
}
