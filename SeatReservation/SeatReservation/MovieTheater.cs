using SeatReservation;
using System.Data;
using System.Xml.Serialization;

namespace SeatReservation
{

    public class MovieTheater
    {
        //Declare a 2d array to represent seat layout
        public static string[,] seatLayout = new string[5, 5];

        //Instance of TypeChecker and UserInputHandler
        private static TypeChecker typeChecker = new TypeChecker();
        private static UserInputHandler userInputHandler = new UserInputHandler();

        //Main method
        public static void Main(string[] args)
        {
            //Calling method to fill the seat layout with 'O' for available seats
            fillSeats();

            //Print the seat layout to the console
            printSeats();

            while (true)
            {
                Console.WriteLine();  //Leave a line for better formatting

                //Get the user's choice from the menu and process the request
                int userChoice = userMenu();

                userInputHandler.processRequest(userChoice);
            }
        }

        //Method to initialize the seat layout
        private static void fillSeats()
        {

            //using for loop to iterate through the 2d seatLayout array
            for (int row = 0; row < seatLayout.GetLength(0); row++)
            {
                for (int column = 0; column < seatLayout.GetLength(1); column++)
                {
                    seatLayout[row, column] = "0";
                }
            }
        }

        public static void printSeats()
        {
            //Print column header for seat labels
            Console.WriteLine("\tA \tB \tC \tD \tE");
            for (int row = 0; row < seatLayout.GetLength(0); row++)
            {
                //print the row number
                Console.Write((row + 1) + "\t");
                for (int col = 0; col < seatLayout.GetLength(1); col++)
                {
                    //print the status of each seat in the layout 
                    Console.Write(seatLayout[row, col] + "\t");
                }
                //Leave a line for better formatting
                Console.WriteLine();
            }
        }

        //Method to display a menu and get the user's choice
        private static int userMenu()
        {

            string? userChoice = null;
            int userSelectedOption = 0;

            while (true)
            {
                Console.WriteLine("Select an option to continue: \n" +
                    "1. Show Available Seats \n" +
                    "2. Reserve a Seat \n" +
                    "3. Cancel Reserved Seat \n");
                Console.Write("Your Choice: ");

                //Read the user's input from the console
                userChoice = Console.ReadLine();

                //Check if the input is empty or null
                if (typeChecker.isEmpty(userChoice))
                {

                    //prompt the user to enter a valid input
                    Console.WriteLine("$$Please Enter A Valid Input");
                }
                else
                {
                    //Check if the input is a valid integer
                    if (typeChecker.isInteger(userChoice))
                    {
                        //Convert the input to an integer
                        userSelectedOption = Convert.ToInt32(userChoice);
                        break;  //Exit the loop when a valid choice is made
                    }
                    else
                    {
                        Console.WriteLine("$$Make A Valid Selection");
                    }
                }
            }

            //Return the user's selected option
            return userSelectedOption;
        }
    }
}
