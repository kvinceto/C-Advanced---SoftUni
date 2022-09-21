using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] setsLength = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < setsLength[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < setsLength[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }
            HashSet<int> equalNumbers = new HashSet<int>();
            foreach (int number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    equalNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(' ', equalNumbers));
            ;
        }
    }
}
