using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    //Custom exception class for when a seat is already reserved
    public class AlreadyReservedSeatException : Exception
    {
        public AlreadyReservedSeatException() { }
    }

    //Custom exception class for when a seat is not reserved
    public class SeatNotReservedException : Exception
    {
        public SeatNotReservedException() { }
    }
}
