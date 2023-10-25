using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.CustomException;
using Banking.ValueValidator;

namespace Banking.UserPrompt
{
    public class UserAccountOptionPrompt
    {
        static Validate validate = new Validate();
        public void promptUser()
        {
            Console.WriteLine("Welcome To The National Bank of Computer Programming");
            Console.WriteLine("Do you have an account?");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register an account");

            Console.Write("Your choice: ");

            string? userChoice = Console.ReadLine();
            int choiceNumber;

            try
            {
                if (String.IsNullOrEmpty(userChoice))
                {
                    throw new EmptyOrNullException("Value provided is empty");
                }
                else
                {
                    choiceNumber = validate.parseInt(userChoice);
                    validate.checkNumberRange(0, 3, choiceNumber);
                }
                
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(EmptyOrNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred");
            }


        }
    }
}
