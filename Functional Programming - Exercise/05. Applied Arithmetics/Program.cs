using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Func<int[], int[]> add = x => x.Select(n => n + 1).ToArray();
            Func<int[], int[]> multiply = x => x.Select(n => n * 2).ToArray();
            Func<int[], int[]> subtract = x => x.Select(n => n - 1).ToArray();
            Action<int[]> print = x => Console.WriteLine(string.Join(' ', x));

            int[] arrayOfIntegers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end") break;
                switch (command)
                {
                    case "add": arrayOfIntegers = add(arrayOfIntegers); break;
                    case "multiply": arrayOfIntegers = multiply(arrayOfIntegers); break;
                    case "subtract": arrayOfIntegers = subtract(arrayOfIntegers); break;
                    case "print": print(arrayOfIntegers); break;
                    case "end": return;
                }
            }
        }
    }
}
