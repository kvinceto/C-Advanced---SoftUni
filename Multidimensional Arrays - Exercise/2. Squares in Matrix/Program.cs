using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrixChar = new char[matrixDimensions[0], matrixDimensions[1]];

            for (int row = 0; row < matrixChar.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrixChar.GetLength(1); col++)
                {
                    matrixChar[row, col] = rowData[col];
                }
            }

            int countOfEqualSquares = 0;
            for (int r = 0; r < matrixChar.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrixChar.GetLength(1) - 1; c++)
                {
                    if (matrixChar[r, c] == matrixChar[r, c + 1] &&
                        matrixChar[r, c] == matrixChar[r + 1, c] &&
                        matrixChar[r, c] == matrixChar[r + 1, c + 1])
                    {
                        countOfEqualSquares++;
                    }
                }
            }

            Console.WriteLine(countOfEqualSquares);
        }
    }
}
