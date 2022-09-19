using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END") break;
                switch (input[0])
                {
                    case "IN":
                        cars.Add(input[1]);
                        break;
                    case "OUT":
                        cars.Remove(input[1]);
                        break;
                }
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                cars.ToList().ForEach(Console.WriteLine);
            }
        }
    }
}
