using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> collection = new SortedDictionary<char, int>();

            foreach (char c in input)
            {
                if (!collection.ContainsKey(c))
                {
                    collection.Add(c, 1);
                    continue;
                }

                collection[c]++;
            }

            foreach (var character in collection)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
