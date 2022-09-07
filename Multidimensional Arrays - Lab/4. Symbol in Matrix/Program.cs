using System;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int column = 0; column < n; column++)
                {
                    matrix[row,column] = rowData[column];
                }
            }

            char characterToFind = char.Parse(Console.ReadLine());
            bool isPresent = false;
            for (int currentRow = 0; currentRow < n; currentRow++)
            {
                for (int currentColumn = 0; currentColumn < n; currentColumn++)
                {
                    char currentChar = matrix[currentRow,currentColumn];
                    if (currentChar == characterToFind)
                    {
                        isPresent = true;
                    }

                    if (!isPresent) continue;
                    Console.WriteLine($"({currentRow}, {currentColumn})");
                    return;
                }
            }

            Console.WriteLine($"{characterToFind} does not occur in the matrix ");
        }
    }
}
