using System;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, string> first =
                new Tuple<string, string>($"{firstInput[0]} {firstInput[1]}", firstInput[2]);
            string[] secondInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, int> second =
                new Tuple<string, int>(secondInput[0], int.Parse(secondInput[1]));
            string[] thirdInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Tuple<int, double> third =
                new Tuple<int, double>(int.Parse(thirdInput[0]), double.Parse(thirdInput[1]));
            Console.WriteLine($"{first.Item1} -> {first.Item2}");
            Console.WriteLine($"{second.Item1} -> {second.Item2}");
            Console.WriteLine($"{third.Item1} -> {third.Item2}");
        }
    }
}
