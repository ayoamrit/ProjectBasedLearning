using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapePlan.Game
{
    public class ValidateMove
    {
        //Function to check whether the move is possible or not
        public bool CheckMove(char[,] gameBoard, int movePositionX, int movePositionY)
        {
            if (movePositionX < 0 || movePositionX > 19 || movePositionY < 0 || movePositionY > 19)
            {
                return false;
            }

            if (gameBoard[movePositionX, movePositionY] == ' ')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
