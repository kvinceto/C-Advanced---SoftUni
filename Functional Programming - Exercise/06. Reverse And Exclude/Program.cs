using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int, int[]> filter = (arr, n) => arr.Where(x => x % n != 0).Reverse().ToArray();
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(' ', filter(array, n)));
        }
    }
}
