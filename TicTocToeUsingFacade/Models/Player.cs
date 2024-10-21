using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocToeUsingFacade.Exceptions;

namespace TicTocToeUsingFacade.Models
{
    internal class Player
    {
        MarkType markType;

        public Player(MarkType mark)
        {
            markType = mark;
        }

        public void PlayGame(Board board)
        {
            Console.WriteLine("\nChoose you position (between 0 to 8):");
            int position = int.Parse(Console.ReadLine());
           
            board.SetCellMark(position, markType);
            
        }
    }
}
