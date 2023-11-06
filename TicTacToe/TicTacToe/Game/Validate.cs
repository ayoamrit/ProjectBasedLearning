using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.CustomException;

namespace TicTacToe.Game
{
    public class Validate
    {
        //function to check if a number i within a specified range
        public bool inRange(int number, int min, int max)
        {
            if (number > min && number < max)
            {
                return true;
            }
            else
            {
                //throw exception
                throw new ArgumentOutOfRangeException($"^^{number} is out of range");
            }
        }

        //function to check is string is empty or null
        public bool isEmptyOrNull(string? str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return true;
            }
            else
            {
                //throw exception
                throw new EmptyOrNullException($"Value you have entered is either empty or null");
            }
        }

        //function to check if the user input is valid
        public bool isValueValid(string? input)
        {
            try
            {
                //call function to check whether is value is empty or not
                isEmptyOrNull(input);

                //call function to check whether the value is within the range or not
                inRange(Convert.ToInt32(input), 0, 10);

                return true;
            }
            catch (FormatException e)
            {
                //exception to handle incorrect format error
                Console.WriteLine(e.Message);
                return false;
            }
            catch (ArgumentOutOfRangeException e)
            {
                //exception to handle value out of range error
                Console.WriteLine(e.Message);
                return false;
            }
            catch (EmptyOrNullException e)
            {
                //exception to handle empty or null value error
                Console.WriteLine(e.Message);
                return false;
            }
            catch (Exception)
            {
                //exception to handle unexpected error during runtime
                Console.WriteLine("^^An unexpected error occurred during the execution of the program");
                return false;
            }
        }

        //function to check if a position on the game board is empty
        public bool isPositionEmpty(char[,] gameBoard, int position)
        {
            (int row, int col) cell = getPosition(position);

            if (gameBoard[cell.row, cell.col] == ' ')
            {
                //If the place is empty
                return true;
            }
            else
            {
                //if the place is not empty
                return false;
            }
        }

        //method to perform an action, i.e placing a symbol on the game board
        public void performAction(char[,] gameBoard, int position, char symbol)
        {
            (int row, int col) cell = getPosition(position);

            gameBoard[cell.row, cell.col] = symbol;
        }

        //helper function to convert a position number to row and column indices
        private (int row, int col) getPosition(int position)
        {
            switch (position)
            {
                case 1: return (0,0);
                case 2: return (0,2);
                case 3: return (0,4);
                case 4: return (2,0);
                case 5: return (2,2);
                case 6: return (2,4);
                case 7: return (4,0);
                case 8: return (4,2);
                case 9: return (4, 4);
                default: throw new Exception();
            }
        }
    }
}
