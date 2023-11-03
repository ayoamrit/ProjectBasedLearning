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
        public bool inRange(int number, int min, int max)
        {
            if (number > min && number < max)
            {
                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"^^{number} is out of range");
            }
        }

        public bool isEmptyOrNull(string? str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return true;
            }
            else
            {
                throw new EmptyOrNullException($"Value you have entered is either empty or null");
            }
        }

        public bool isValueValid(string? input)
        {
            try
            {
                isEmptyOrNull(input);
                inRange(Convert.ToInt32(input), 0, 10);

                return true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (EmptyOrNullException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("^^An unexpected error occurred during the execution of the program");
                return false;
            }
        }
    }
}
