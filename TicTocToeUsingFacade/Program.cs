using TicTocToeUsingFacade.Models;
using TicTocToeUsingFacade.Presentation;
using TicTocToeUsingFacade.Services;

namespace TicTocToeUsingFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            Player player1 = new Player(MarkType.X);
            Player player2 = new Player(MarkType.O);

            GameGUI game = new GameGUI();

            ResultAnalyzer analyzer = new ResultAnalyzer();

            game.DisplayBoard(board);
            game.StartGame(player1, player2,board, analyzer);


        }
    }
}
