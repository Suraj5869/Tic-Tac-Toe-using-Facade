using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocToeUsingFacade.Exceptions;

namespace TicTocToeUsingFacade.Models
{
    internal class Board
    {
        Cell[] cells = new Cell[9];

        public Board()
        {
            for(int i = 0; i<cells.Length; i++)
            {
                cells[i] = new Cell();
            }
        }

        public bool IsBoardFull()
        {
            foreach(var block in cells)
            {
                if(block.GetMark() == MarkType.EMPTY)
                {
                    return false;
                }
            }
            return true;
        }

        public void SetCellMark(int position, MarkType mark)
        {
            if (cells[position].GetMark() == MarkType.EMPTY)
            {
                cells[position].SetMark(mark);
            }
            else
            {
                throw new CellAlreadyOccupiedException("Cell is already occupied");
            }
        }

        public MarkType GetCellMark(int position)
        {
            if (cells[position].GetMark() == null)
            {
                return MarkType.EMPTY;
            }
            return cells[position].GetMark();
        }
    }
}
