using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomException;

namespace SeatReservation
{
    //The CancelReservation class handles the cancellation of seat reservations.
    public class CancelReservation : UserInputHandler
    {
        //Constructor for CancelReservation, takes the row and column as parameters
        public CancelReservation(int row, int column)
        {
            //Check if the seat is already reserved
            if(isSeatReserved(row, column))
            {
                //If the seat is reserved, mark it as available and inform the user
                MovieTheater.seatLayout[row, column] = "O";  //"0" represents an available seat
                Console.WriteLine("Reservation Has Been Canceled");
                Console.WriteLine();
            }
            else
            {
                //If the seat is not reserved, throw a custom exception
                throw new SeatNotReservedException();
            }
        }
    }
}
