using TicTocToeUsingFacade.Models;
using TicTocToeUsingFacade.Presentation;
using TicTocToeUsingFacade.Services;

namespace TicTocToeUsingFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameGUI gameGUI = new GameGUI();
            gameGUI.StartBoard();


        }
    }
}
