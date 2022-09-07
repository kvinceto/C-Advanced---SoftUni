using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixRowsCount = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[matrixRowsCount][];

            for (int i = 0; i < matrixRowsCount; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (cmd[0])
                {
                    case "Add":
                        AddCommand(cmd, jaggedArray);
                        break;
                    case "Subtract":
                        SubtractCommand(cmd, jaggedArray);
                        break;
                }
            }

            foreach (var array in jaggedArray)
            {
                Console.WriteLine(string.Join(' ', array));
            }
        }


        private static void AddCommand(string[] cmd, int[][] jaggedArray)
        {
            int row = int.Parse(cmd[1]);
            int col = int.Parse(cmd[2]);
            int value = int.Parse(cmd[3]);

            if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
            {
                jaggedArray[row][col] += value;
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
            }
        }

        private static void SubtractCommand(string[] cmd, int[][] jaggedArray)
        {
            int row = int.Parse(cmd[1]);
            int column = int.Parse(cmd[2]);
            int value = int.Parse(cmd[3]);

            if (row >= 0 && row < jaggedArray.Length && column >= 0 && column < jaggedArray[row].Length)
            {
                jaggedArray[row][column] -= value;
            }
            else
            {
                Console.WriteLine("Invalid coordinates");
            }
        }
    }
}
