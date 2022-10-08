using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                Box<int> s = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(s);
            }

            int[] indexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Swap(boxes, indexes[0], indexes[1]);
            boxes.ForEach(Console.WriteLine);
        }

        public static void Swap<T>(List<T> list, int index1, int index2)
        {
            T item1 = list[index1];
            T item2 = list[index2];
            list[index1] = item2;
            list[index2] = item1;
        }
    }
}
