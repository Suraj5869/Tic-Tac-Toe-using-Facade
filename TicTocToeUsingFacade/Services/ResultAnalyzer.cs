using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocToeUsingFacade.Models;

namespace TicTocToeUsingFacade.Services
{
    internal class ResultAnalyzer
    {
        public bool CheckRows(Board board)
        {
            if (board.GetCellMark(0) == MarkType.X && board.GetCellMark(0) == board.GetCellMark(1) && board.GetCellMark(1) == board.GetCellMark(2))
                return true;
            else if (board.GetCellMark(0) == MarkType.O && board.GetCellMark(0) == board.GetCellMark(1) && board.GetCellMark(1) == board.GetCellMark(2))
                return true;
            else if (board.GetCellMark(3) == MarkType.X && board.GetCellMark(3) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(5))
                return true;
            else if (board.GetCellMark(3) == MarkType.O && board.GetCellMark(3) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(5))
                return true;
            else if (board.GetCellMark(6) == MarkType.X && board.GetCellMark(6) == board.GetCellMark(7) && board.GetCellMark(7) == board.GetCellMark(8))
                return true;
            else if (board.GetCellMark(6) == MarkType.O && board.GetCellMark(6) == board.GetCellMark(7) && board.GetCellMark(7) == board.GetCellMark(8))
                return true;
            return false;

        }

        public bool CheckColumns(Board board)
        {
            if (board.GetCellMark(0) == MarkType.X && board.GetCellMark(0) == board.GetCellMark(3) && board.GetCellMark(3) == board.GetCellMark(6))
                return true;
            else if (board.GetCellMark(0) == MarkType.O && board.GetCellMark(0) == board.GetCellMark(3) && board.GetCellMark(3) == board.GetCellMark(6))
                return true;
            else if (board.GetCellMark(1) == MarkType.X && board.GetCellMark(1) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(7))
                return true;
            else if (board.GetCellMark(1) == MarkType.O && board.GetCellMark(1) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(7))
                return true;
            else if (board.GetCellMark(2) == MarkType.X && board.GetCellMark(2) == board.GetCellMark(5) && board.GetCellMark(5) == board.GetCellMark(8))
                return true;
            else if (board.GetCellMark(2) == MarkType.O && board.GetCellMark(2) == board.GetCellMark(5) && board.GetCellMark(5) == board.GetCellMark(8))
                return true;
            return false;
        }

        public bool CheckDiagonals(Board board)
        {
            if (board.GetCellMark(0) == MarkType.X && board.GetCellMark(0) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(8))
                return true;
            else if (board.GetCellMark(0) == MarkType.O && board.GetCellMark(0) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(8))
                return true;
            else if (board.GetCellMark(2) == MarkType.X && board.GetCellMark(2) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(6))
                return true;
            else if (board.GetCellMark(2) == MarkType.O && board.GetCellMark(2) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(6))
                return true;
            return false;
        }
        internal bool CheckAll(Board board)
        {
            if (CheckColumns(board) || CheckRows(board) || CheckDiagonals(board))
                return true;
            return false ;
        }
    }
}
