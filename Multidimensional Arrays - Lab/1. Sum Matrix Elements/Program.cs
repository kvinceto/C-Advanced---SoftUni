using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] matrixData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
           int[,] matrix = new int[matrixData[0], matrixData[1]];

           for (int i = 0; i < matrix.GetLength(0); i++)
           {
               int[] currentRowData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse).ToArray();
               for (int j = 0; j < currentRowData.Length; j++)
               {
                    matrix[i, j] = currentRowData[j];
               }
           }

           Console.WriteLine(matrix.GetLength(0));
           Console.WriteLine(matrix.GetLength(1));
           int sum = 0;

           foreach (int item in matrix)
           {
               sum += item;
           }

           Console.WriteLine(sum);
        }

    }
}
