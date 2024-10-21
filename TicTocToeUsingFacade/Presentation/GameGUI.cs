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
                PrintBoard(i, board);
            }
        }

        private void PrintBoard(int i, Board board)
        {
            if (board.GetCellMark(i) == MarkType.EMPTY)
            {
                Console.Write("   |");
            }
            else
            {
                Console.Write($" {board.GetCellMark(i)} |");
            }
            if (i == 2 || i == 5)
            {
                Console.WriteLine("\n------------");
            }
        }

        public void StartGame(Player player1, Player player2, Board board, ResultAnalyzer analyzer)
        {
            try
            {
                PlayersMove(player1, player2, board, analyzer);
            }
            catch (CellAlreadyOccupiedException ce)
            {
                Console.WriteLine(ce.Message);
            }
            

            Console.WriteLine("You want to play again:\n" +
                "1. Yes\n" +
                "2. No");
            int choice = int.Parse(Console.ReadLine());

            PlayAgain(choice);
        }

        private void PlayersMove(Player player1, Player player2, Board board, ResultAnalyzer analyzer)
        {
            while (!board.IsBoardFull())
            {
                player1.PlayGame(board);
                DisplayBoard(board);
                if (analyzer.CheckAll(board))
                {
                    Console.WriteLine("\nPlayer 1 win the match");
                    break;
                }
                player2.PlayGame(board);
                DisplayBoard(board);
                if (analyzer.CheckAll(board))
                {
                    Console.WriteLine("\nPlayer 2 win the match");
                    break;
                }
            }
        }

        private void PlayAgain(int choice)
        {
            switch(choice)
            {
                case 1:
                    Console.Clear();
                    StartBoard();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        public void StartBoard()
        {
            Console.WriteLine("~~~~~ Welcome to Tic-Tac-Toe Game ~~~~~");
            Board board = new Board();

            Player player1 = new Player(MarkType.X);
            Player player2 = new Player(MarkType.O);

            ResultAnalyzer analyzer = new ResultAnalyzer();

            DisplayBoard(board);
            StartGame(player1, player2, board, analyzer);
        }
    }
}
