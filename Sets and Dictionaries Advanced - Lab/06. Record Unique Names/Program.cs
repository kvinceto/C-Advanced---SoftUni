using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                names.Add(Console.ReadLine());
            }

            names.ToList().ForEach(Console.WriteLine);
        }
    }
}
