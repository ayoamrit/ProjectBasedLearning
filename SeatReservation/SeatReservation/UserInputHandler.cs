using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomException;

namespace SeatReservation
{
    //The UserInputHandler manages user interactions and seat reservation/cancellation requests.
    public class UserInputHandler
    {
        TypeChecker typeChecker;

        //Constructor to initialize the TypeChecker
        public UserInputHandler()
        {
            typeChecker = new TypeChecker();
        }
        
        //Process the user's choice based on the menu selection
        public void processRequest(int userChoice)
        {
            switch (userChoice)
            {
                case 1: MovieTheater.printSeats(); break;
                case 2: seatRequest("reserve"); break;
                case 3: seatRequest("cancel"); break;
                
                default: Console.WriteLine("$$Select A Valid Choice"); break;
            }
        }

        //Handle seat reservation or cancellation based on the action
        private void seatRequest(string action)
        {
            //Display the current seat layout to the user
            MovieTheater.printSeats();

            try
            {
                Console.Write("Select A Row: ");
                int row = getSelectedRow();  //Get the user's selected row

                Console.Write("Select A Column: ");
                int column = getSelectedColumn();  //Get the user's selected column

                if(action == "reserve")
                {
                    //If the action is to reserve a seat, create a new Reservation and mark the seat as reserved
                    new ReserveSeat(row, column);
                }
                else
                {
                    //If the action is to cancel a reservation, create a new CancelReservation and mark the seat as available
                    new CancelReservation(row, column);
                }

                MovieTheater.printSeats();

            }catch(FormatException)
            {
                //Handle invalid input exception
                Console.WriteLine("$$Please Enter A Valid Input");
            }
            catch (SeatNotReservedException)
            {
                //Handle attempts to cancel unreserved seats
                Console.WriteLine("$$The Seat That You Are Trying To Cancel Has Not Been Reserved Yet.");
            }
            catch (AlreadyReservedSeatException)
            {
                //Handle attempts to reserve already reserved seats
                Console.WriteLine("$$The Seat That You Are Trying To Book Is Already Reserved");
            }
            catch (ArgumentOutOfRangeException)
            {
                //Handle out-of-range row or column values
                Console.WriteLine("$$Selected Value Is Out Of Scope");
            }
            catch(Exception)
            {
                //Handle of other unexpected exception
                Console.WriteLine("$$An Error Occurred");
            }
        }

        //Get the selected row from the user and perform validation
        private int getSelectedRow()
        {
            try
            {
                //Read user input as row number
                int row = Convert.ToInt32(Console.ReadLine());

                //Check if the number is within the range (1-5)
                if (typeChecker.checkNumber(row)){
                    return row - 1;  //Adjust to match array indexing (0-based)
                }
                else
                {
                    //Throw an exception for out-of-range values.
                    throw new ArgumentOutOfRangeException();
                }

            }catch(FormatException)
            {
                //Handle invalid input format exceptions
                throw new FormatException();
            }
            catch (Exception)
            {
                //Handle any other unexpected exception
                throw new Exception();
            }
        }

        //Get the selected column from the user and perform validation
        private int getSelectedColumn()
        {
            try
            {
                //Read the user input as a character
                char column = Convert.ToChar(Console.ReadLine());

                //Check if the char is within the range (a-e)
                if (typeChecker.checkChar(char.ToLower(column)))
                {
                    //Convert the character to its numeric index
                    return getColumnNumber(column);
                }
                else
                {
                    //Throw an exception for invalid column choices
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                //Handle invalid input format
                throw new FormatException();
            }
            catch (Exception)
            {
                //Handle any other unexpected exceptions
                throw new Exception();
            }
        }

        //Map the selected characters column (a, b, c, d, e) to numberic index
        private int getColumnNumber(char column)
        {
            switch (column)
            {
                case 'a':
                case 'A': return 0; //Map "A" to column 0
                case 'b':
                case 'B': return 1; //Map "B" to column 1
                case 'c':
                case 'C': return 2; // Map "C" to column 2
                case 'd':
                case 'D': return 3; // Map "D" to column 3

                default: return 4; // Map "E" to column 4
            }
        }

        //Check if a seat is reserved at the specified row and column
        public bool isSeatReserved(int row, int column)
        {
            if (MovieTheater.seatLayout[row, column] == "X")
            {
                return true;  //return true if the reserved
            }
            else
            {
                return false;  //the seat is not reserved
            }
        }
    }
}
