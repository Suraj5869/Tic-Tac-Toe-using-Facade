using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocToeUsingFacade.Exceptions;
using TicTocToeUsingFacade.Models;
using TicTocToeUsingFacade.Services;

namespace TicTocToeUsingFacade.Presentation
{
    internal class GameGUI
    {
        public void DisplayBoard(Board board)
        {
            
            for (int i = 0; i<9; i++)
            {
                if (board.GetCellMark(i) == MarkType.EMPTY)
                {
                    Console.Write("   |");
                }
                else
                {
                    Console.Write($" {board.GetCellMark(i)} |");
                }
                if(i == 2 || i == 5)
                {
                    Console.WriteLine("\n------------");
                }
            }
        }

        public void StartGame(Player player1, Player player2, Board board, ResultAnalyzer analyzer)
        {
            while (!board.IsBoardFull())
            {   try
                {
                    player1.PlayGame(board);
                    if (analyzer.CheckAll(board))
                    {
                        Console.WriteLine("Player 1 win the match");
                        break;
                    }
                    DisplayBoard(board);
                    player2.PlayGame(board);
                    if (analyzer.CheckAll(board))
                    {
                        Console.WriteLine("Player 2 win the match");
                        break;
                    }
                    DisplayBoard(board);
                }
                catch(CellAlreadyOccupiedException ce)
                {
                    Console.WriteLine(ce.Message);
                }
            }

            Console.WriteLine("You want to play again:\n" +
                "1. Yes\n" +
                "2. No");
            int choice = int.Parse(Console.ReadLine());

            PlayAgain(choice);
        }

        private void PlayAgain(int choice)
        {
            switch(choice)
            {
                case 1:
                    ResetBoard();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        private void ResetBoard()
        {
            Board board = new Board();

            Player player1 = new Player(MarkType.X);
            Player player2 = new Player(MarkType.O);

            GameGUI game = new GameGUI();

            ResultAnalyzer analyzer = new ResultAnalyzer();

            game.DisplayBoard(board);
            game.StartGame(player1, player2, board, analyzer);
        }
    }
}
