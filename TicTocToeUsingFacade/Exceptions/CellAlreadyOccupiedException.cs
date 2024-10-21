using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToeUsingFacade.Exceptions
{
    internal class CellAlreadyOccupiedException:Exception
    {
        public CellAlreadyOccupiedException(string message):base(message) { }
    }
}
