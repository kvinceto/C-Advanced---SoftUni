using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Dictionary<int, int> collection = new Dictionary<int, int>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!collection.ContainsKey(number))
                {
                    collection.Add(number, 1);
                    continue;
                }

                collection[number]++;
            }

            foreach (var number in collection)
            {
                if (number.Value % 2 == 0)
                {
                    Console.Write($"{number.Key} ");
                }
            }
        }
    }
}
