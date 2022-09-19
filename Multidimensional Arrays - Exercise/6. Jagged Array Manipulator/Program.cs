using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[int.Parse(Console.ReadLine())][];

            for (int row = 0; row < array.Length; row++)
            {
               array[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int r = 0; r < array.Length - 1; r++)
            {
                if (array[r].Length == array[r + 1].Length)
                {
                    for (int c = 0; c < array[r].Length; c++)
                    {
                        array[r][c] *= 2;
                        array[r + 1][c] *= 2;
                    }
                }
                else
                {
                    array[r] = array[r].Select(n => n / 2).ToArray();
                    array[r + 1] = array[r + 1].Select(n => n / 2).ToArray();
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "End")
                {
                    foreach (var row in array)
                    {
                        Console.WriteLine(string.Join(' ', row));
                    }
                    break;
                }
                else if (command[0] == "Add")
                {
                    AddValue(command, array);
                }
                else if (command[0] == "Subtract")
                {
                    SubtractValue(command, array);
                }
            }
        }


        private static void AddValue(string[] command, int[][] array)
        {
            int row = int.Parse(command[1]);
            int cow = int.Parse(command[2]);
            int value = int.Parse(command[3]);

            if (row >= 0 && row < array.Length &&
                cow >= 0 && cow < array[row].Length)
            {
                array[row][cow] += value;
            }
        }

        private static void SubtractValue(string[] command, int[][] array)
        {
            int row = int.Parse(command[1]);
            int cow = int.Parse(command[2]);
            int value = int.Parse(command[3]);

            if (row >= 0 && row < array.Length &&
                cow >= 0 && cow < array[row].Length)
            {
                array[row][cow] -= value;
            }
        }
    }
}
