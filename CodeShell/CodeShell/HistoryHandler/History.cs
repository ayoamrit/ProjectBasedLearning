using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeShell.HistoryHandler
{
    public class History
    {
        public History(StackList.Stack stack)
        {
            stack.PrintStack();
        }
    }
}
