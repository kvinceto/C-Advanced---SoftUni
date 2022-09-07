using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixData[0], matrixData[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = rowData[column];
                }
            }

            int maxSum = int.MinValue;
            int rowIndex = -1;
            int columnIndex = -1;

            for (int currentRow = 0; currentRow < matrix.GetLength(0) - 1; currentRow++)
            {
                for (int currentColumn = 0; currentColumn < matrix.GetLength(1) - 1; currentColumn++)
                {
                    int currentSquareSum = (matrix[currentRow, currentColumn]) + (matrix[currentRow, currentColumn + 1]) + (matrix[currentRow + 1, currentColumn]) + (matrix[currentRow + 1, currentColumn + 1]);

                    if (currentSquareSum > maxSum)
                    {
                        maxSum = currentSquareSum;
                        rowIndex = currentRow;
                        columnIndex = currentColumn;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowIndex, columnIndex]} {matrix[rowIndex, columnIndex + 1]}");
            Console.WriteLine($"{matrix[rowIndex + 1, columnIndex]} {matrix[rowIndex + 1, columnIndex + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
