using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int column = 0; column < n; column++)
                {
                    matrix[row,column] = rowData[column];
                }
            }

            int sumOfPrimaryDiagonal = 0;

            for (int position = 0; position < n; position++)
            {
                sumOfPrimaryDiagonal += matrix[position, position];
            }

            Console.WriteLine(sumOfPrimaryDiagonal);
        }
    }
}
