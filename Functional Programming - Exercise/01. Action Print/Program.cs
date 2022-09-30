using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = s => Console.WriteLine(s);

            List<string> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            list.ForEach(print);
        }
    }
}
