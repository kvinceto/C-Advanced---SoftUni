using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                list.Add(s);
            }

            string input = Console.ReadLine();
            Console.WriteLine(Compare<string>(list, input));
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
