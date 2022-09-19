using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheSquareMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfTheSquareMatrix, sizeOfTheSquareMatrix];

            for (int row = 0; row < sizeOfTheSquareMatrix; row++)
            {
                int[] rowDate = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int column = 0; column < sizeOfTheSquareMatrix; column++)
                {
                    matrix[row, column] = rowDate[column];
                }
            }

            int sumOfPrimaryDiagonal = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                sumOfPrimaryDiagonal += matrix[r, r];
            }
            int sumOfSecondaryDiagonal = 0;
            int col = 0;
            for (int c = matrix.GetLength(0) - 1; c >= 0; c--)
            {
                sumOfSecondaryDiagonal += matrix[c, col];
                col++;
            }

            Console.WriteLine(Math.Abs(sumOfPrimaryDiagonal - sumOfSecondaryDiagonal));
        }
    }
}
