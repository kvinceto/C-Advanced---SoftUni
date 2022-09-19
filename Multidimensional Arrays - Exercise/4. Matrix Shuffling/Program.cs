using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[matrixDimensions[0], matrixDimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            string pattern = @"^swap (?<r1>\d+) (?<c1>\d+) (?<r2>\d+) (?<c2>\d+)$";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                if (regex.IsMatch(command))
                {
                    Match validCommand = regex.Match(command);
                    int row1 = int.Parse(validCommand.Groups["r1"].Value);
                    int cow1 = int.Parse(validCommand.Groups["c1"].Value);
                    int row2 = int.Parse(validCommand.Groups["r2"].Value);
                    int cow2 = int.Parse(validCommand.Groups["c2"].Value);

                    if (row1 < 0 || row1 > matrix.GetLength(0) - 1 ||
                        cow1 < 0 || cow1 > matrix.GetLength(1) - 1 ||
                        row2 < 0 || row2 > matrix.GetLength(0) - 1 ||
                        cow2 < 0 || cow2 > matrix.GetLength(1) - 1)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    string firstValue = matrix[row1, cow1];
                    string secondValue = matrix[row2, cow2];
                    matrix[row1, cow1] = secondValue;
                    matrix[row2, cow2] = firstValue;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
