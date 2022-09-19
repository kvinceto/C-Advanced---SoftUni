using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            Dictionary<double, int> listOfNumbers = new Dictionary<double, int>();

            foreach (double number in numbers)
            {
                if (listOfNumbers.ContainsKey(number))
                {
                    listOfNumbers[number]++;
                }
                else
                {
                    listOfNumbers.Add(number, 1);
                }
            }

            listOfNumbers.ToList().ForEach(number => Console.WriteLine($"{number.Key} - {number.Value} times"));
        }
    }
}
