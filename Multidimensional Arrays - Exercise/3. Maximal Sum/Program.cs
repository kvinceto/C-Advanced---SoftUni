using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixDimensions[0], matrixDimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int[,] biggestMatrix = new int[3, 3];
            int maxSum = Int32.MinValue;

            for (int r = 0; r < matrix.GetLength(0) - 2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {
                    int currentMatrixSum =
                        matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] +
                        matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] +
                        matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];
                    if (currentMatrixSum > maxSum)
                    {
                        maxSum = currentMatrixSum;
                        biggestMatrix[0, 0] = matrix[r, c];
                        biggestMatrix[0, 1] = matrix[r, c + 1];
                        biggestMatrix[0, 2] = matrix[r, c + 2];
                        biggestMatrix[1, 0] = matrix[r + 1, c];
                        biggestMatrix[1, 1] = matrix[r + 1, c + 1];
                        biggestMatrix[1, 2] = matrix[r + 1, c + 2];
                        biggestMatrix[2, 0] = matrix[r + 2, c];
                        biggestMatrix[2, 1] = matrix[r + 2, c + 1];
                        biggestMatrix[2, 2] = matrix[r + 2, c + 2];
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < biggestMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < biggestMatrix.GetLength(1); j++)
                {
                    Console.Write(biggestMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
