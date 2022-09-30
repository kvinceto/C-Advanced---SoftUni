using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string[], int, List<string>> filter =
                (arr, n) => arr.Where(a => a.Length <= n).ToList();
            int n = int.Parse(Console.ReadLine());
            filter(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray(), n)
                .ForEach(Console.WriteLine);
        }
    }
}
