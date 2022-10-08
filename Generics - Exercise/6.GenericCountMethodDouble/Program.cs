using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double s = double.Parse(Console.ReadLine());
                list.Add(s);
            }

            double input = double.Parse(Console.ReadLine());
            Console.WriteLine(Compare<double>(list, input));
        }

        public static int Compare<T>(List<T> list, T element) where T : IComparable
        {
            int counter = 0;
            foreach (T item in list)
            {
                int v = element.CompareTo(item);
                if (v < 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
