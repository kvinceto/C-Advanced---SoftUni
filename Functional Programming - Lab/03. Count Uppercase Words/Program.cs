using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> function = s => char.IsUpper(s[0]);

            Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Where(function)
                    .ToList()
                    .ForEach(Console.WriteLine);
        }
    }
}
