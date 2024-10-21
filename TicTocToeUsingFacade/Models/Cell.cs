using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToeUsingFacade.Models
{
    internal class Cell
    {
        private MarkType _mark;

        public Cell()
        {
            _mark = MarkType.EMPTY;
        }

        public bool ISEmpty(Cell cell)
        {
            if (cell._mark == MarkType.EMPTY)
            {
                return true;
            }
            return false;
        }

        public MarkType GetMark()
        {
            if (_mark == MarkType.EMPTY || _mark == null)
            {
                return MarkType.EMPTY;
            }
            return _mark;
        }

        public void SetMark(MarkType mark)
        {
            if(_mark == MarkType.EMPTY)
            {
                _mark = mark;
            }
            else
            {
                throw new Exception("Cell is already full");
            }
        }

        
    }
}
