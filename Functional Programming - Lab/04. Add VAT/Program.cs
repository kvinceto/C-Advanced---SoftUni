using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> function = n => $"{(double.Parse(n) * 1.2):f2}";

            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(function)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
