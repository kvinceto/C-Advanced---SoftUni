using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            if (numbers.Count <= 3)
            {
                foreach (int number in numbers.OrderByDescending(n => n))
                {
                    Console.Write($"{number} ");
                }
            }
            else
            {
                numbers = numbers.OrderByDescending(n => n).ToList();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
