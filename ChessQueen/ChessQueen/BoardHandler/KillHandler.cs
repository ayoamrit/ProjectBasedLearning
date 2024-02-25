using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessQueen.BoardHandler
{
    public class KillHandler
    {
        public int XAxis { get; private set; }
        public int YAxis { get; private set; }
        public string Symbol { get; private set; }
        public string Message { get; private set; }

        public KillHandler(int xAxis, int yAxis, string Symbol,string message)
        {
            this.XAxis = xAxis;
            this.YAxis = yAxis;
            this.Symbol = Symbol;
            this.Message = message;
        }
    }
}
