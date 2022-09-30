using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> addSir = s => Console.WriteLine($"Sir {s}");

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(addSir);
        }
    }
}
