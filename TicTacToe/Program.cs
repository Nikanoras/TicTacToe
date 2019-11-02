using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            bool isGameRestarted;
            do
            {
                var game = new Game();
                var currentGameState = new[] { new[] { "", "", "" }, new[] { "", "", "" }, new[] { "", "", "" } };
                string winner = string.Empty;
                for (int turn = 1; turn < 10; turn++)
                {
                    PrintCurrentGameState(currentGameState);
                    winner = game.DetermineWinner(currentGameState);
                    if (IsWinnerDetermined(winner))
                    {
                        Console.WriteLine($"The winner is: {winner}");
                        break;
                    }
                    RegisterNextTurn(currentGameState, turn);

                    Console.Clear();
                }
                if (!IsWinnerDetermined(winner))
                {
                    PrintCurrentGameState(currentGameState);
                    Console.WriteLine("It's a draw");
                }

                Console.WriteLine($"Restart game? \"y\"/\"n\"");
                string restartGame = Console.ReadLine();
                isGameRestarted = restartGame == "y";
                Console.Clear();
            } while (isGameRestarted);
        }

        private static void RegisterNextTurn(string[][] currentGameState, int turn)
        {
            Console.WriteLine(turn % 2 != 0 ? "First player's turn" : "Second player's turn");
            bool cellIsEmpty;
            do
            {
                try
                {
                    Console.WriteLine("Please enter row:");
                    int rowIndex = ParseConsoleInput();

                    Console.WriteLine("Please enter column:");
                    int columnIndex = ParseConsoleInput();

                    cellIsEmpty = string.IsNullOrEmpty(currentGameState[rowIndex][columnIndex]);
                    if (cellIsEmpty)
                    {
                        string currentMarker = turn % 2 != 0 ? "x" : "o";
                        currentGameState[rowIndex][columnIndex] = currentMarker;
                    }
                    else
                        Console.WriteLine("Cell already has a value");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input, provide valid cell coordinates.");
                    cellIsEmpty = false;
                }
            } while (!cellIsEmpty);
        }

        private static int ParseConsoleInput()
        {
            string rowNumber = Console.ReadLine();
            int rowIndex = int.Parse(rowNumber) - 1;
            return rowIndex;
        }

        private static bool IsWinnerDetermined(string winner)
        {
            return !string.IsNullOrEmpty(winner);
        }

        private static void PrintCurrentGameState(string[][] currentGameState)
        {
            var columnIndexes = new[] { " ", "1", "2", "3" };
            Console.WriteLine(string.Join("|", columnIndexes) + "|");
            PrintHorizontalSeparator();
            var rowIndexes = new[] { "1", "2", "3" };
            for (int i = 0; i < currentGameState.Length; i++)
            {
                var row = currentGameState[i].Select(cell => string.IsNullOrEmpty(cell) ? " " : cell);
                Console.WriteLine(rowIndexes[i] + "|" + string.Join("|", row) + "|");
                PrintHorizontalSeparator();
            }
        }

        private static void PrintHorizontalSeparator()
        {
            Console.WriteLine("________");
        }
    }
}
