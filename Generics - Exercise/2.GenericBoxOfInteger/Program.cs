using System;
using System.Collections.Generic;

namespace GenericBoxOfInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> numbers = new List<Box<int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<int> num = new Box<int>(int.Parse(Console.ReadLine()));
                numbers.Add(num);
            }

            numbers.ForEach(Console.WriteLine);
        }
    }
}
