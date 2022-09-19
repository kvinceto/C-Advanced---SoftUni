using System;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = ReadInitialMatrixData(size);
            string[] bombs = Console.ReadLine().Split();
            for (int bombIndex = 0; bombIndex < bombs.Length; bombIndex++)
            {
                BombBoom(matrix, bombs[bombIndex]);
            }
            PrintResults(matrix);
        }

        static int[,] ReadInitialMatrixData(int size)
        {
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] line = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            return matrix;
        }

        static void BombBoom(int[,] matrix, string coordinates)
        {
            int rowIndex = coordinates.Split(",").Select(x => int.Parse(x)).First();
            int colIndex = coordinates.Split(",").Select(x => int.Parse(x)).Last();
            if (matrix[rowIndex, colIndex] <= 0) return;

            int boomValue = matrix[rowIndex, colIndex];
            for (int row = rowIndex - 1; row <= rowIndex + 1; row++)
            {
                for (int col = colIndex - 1; col <= colIndex + 1; col++)
                {
                    DealDamageToACell(matrix, row, col, boomValue);
                }
            }
        }

        static void DealDamageToACell(int[,] matrix, int targetRowIndex, int targetColIndex, int boomValue)
        {
            if (targetRowIndex >= 0 && targetRowIndex < matrix.GetLength(0) &&
                targetColIndex >= 0 && targetColIndex < matrix.GetLength(1) &&
                matrix[targetRowIndex, targetColIndex] > 0)
            {
                matrix[targetRowIndex, targetColIndex] -= boomValue;
            }
        }

        static void PrintResults(int[,] matrix)
        {
            int aliveCells = 0;
            int sumOfCells = 0;
            foreach (int number in matrix)
            {
                if (number > 0)
                {
                    aliveCells++;
                    sumOfCells += number;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumOfCells}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
