using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomException;

namespace SeatReservation
{
    //The reserve class is responsible for reserving a seat 
    public class ReserveSeat : UserInputHandler
    {
        //Constructor for ReserveSeat, takes the row and column as parameters
        public ReserveSeat(int row, int column)
        {
            //Check if the seat is already reserved
           if(isSeatReserved(row, column))
           {
                //If the seat is reserved, throw a custom exception
                throw new AlreadyReservedSeatException();
           }
            else
            {
                //If the seat is available, mark it as reserved and inform the user
                MovieTheater.seatLayout[row, column] = "X";  //"X" represents a reserved seat
                Console.WriteLine("***Your Reservation Has Been Successful");
                Console.WriteLine();
            }
        }

    }
}
