using System;
namespace TicTacToe
{
    public class Game
    {
        public string DetermineWinner(string[][] result)
        {
            string winner = DetermineHorizontalCombinationsWinner(result);
            if (string.IsNullOrEmpty(winner))
                winner = DetermineVerticalCombinationsWinner(result);
            if (string.IsNullOrEmpty(winner))
                winner = DetermineAcrossCombinationWinnerFromUpperLeftToBottomRight(result);
            if (string.IsNullOrEmpty(winner))
                winner = DetermineAcrossCombinationWinnerFromBottomLeftToUpperRight(result);
            return winner;
        }

        private string DetermineHorizontalCombinationsWinner(string[][] result)
        {
            for (int rowIndex = 0; rowIndex < result.Length; rowIndex++)
            {
                bool isCombinationValid = false;
                string lastResult = "";
                for (int columnIndex = 1; columnIndex < result[rowIndex].Length; columnIndex++)
                {
                    bool valuesAreEqual = result[rowIndex][columnIndex - 1] == result[rowIndex][columnIndex];
                    string cellValue = result[rowIndex][columnIndex];
                    if (valuesAreEqual && !string.IsNullOrEmpty(cellValue))
                    {
                        lastResult = cellValue;
                        isCombinationValid = true;
                    }
                    else
                    {
                        isCombinationValid = false;
                        break;
                    }
                }

                if (isCombinationValid)
                    return lastResult == "x" ? "first player" : "second player";
            }
            return "";
        }

        private string DetermineVerticalCombinationsWinner(string[][] result)
        {
            for (int columnIndex = 0; columnIndex < result.Length; columnIndex++)
            {
                bool isCombinationValid = false;
                string lastResult = "";
                for (int rowIndex = 1; rowIndex < result[columnIndex].Length; rowIndex++)
                {
                    bool valuesAreEqual = result[rowIndex - 1][columnIndex] == result[rowIndex][columnIndex];
                    string cellValue = result[rowIndex][columnIndex];
                    if (valuesAreEqual && !string.IsNullOrEmpty(cellValue))
                    {
                        lastResult = cellValue;
                        isCombinationValid = true;
                    }
                    else
                    {
                        isCombinationValid = false;
                        break;
                    }
                }

                if (isCombinationValid)
                    return lastResult == "x" ? "first player" : "second player";
            }
            return "";
        }

        private string DetermineAcrossCombinationWinnerFromUpperLeftToBottomRight(string[][] result)
        {
            bool isValidCombination = false;
            string lastResult = "";
            for (int i = 1; i < result.Length; i++)
            {
                if (result[i - 1][i - 1] == result[i][i] && !string.IsNullOrEmpty(result[i][i]))
                {
                    lastResult = result[i][i];
                    isValidCombination = true;
                }
                else
                {
                    isValidCombination = false;
                    break;
                }
            }
            if (isValidCombination)
                return lastResult == "x" ? "first player" : "second player";
            return "";
        }

        private string DetermineAcrossCombinationWinnerFromBottomLeftToUpperRight(string[][] result)
        {
            bool isValidCombination = false;
            string lastResult = "";
            for (int i = 1, x = result.Length; i < result.Length; i++, x--)
            {
                if (result[i - 1][x - 1] == result[i][x - 2] && !string.IsNullOrEmpty(result[i][x - 2]))
                {
                    lastResult = result[i][x - 2];
                    isValidCombination = true;
                }
                else
                {
                    isValidCombination = false;
                    break;
                }
            }
            if (isValidCombination)
                return lastResult == "x" ? "first player" : "second player";
            return "";
        }
    }
}
