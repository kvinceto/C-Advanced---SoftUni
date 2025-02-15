﻿using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continents = 
                new Dictionary<string, Dictionary<string,List<string>>>();
            int numberOfEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEntries; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (continents.ContainsKey(continent))
                {
                    if (continents[continent].ContainsKey(country))
                    {
                        continents[continent][country].Add(city);
                    }
                    else
                    {
                        continents[continent].Add(country, new List<string>());
                        continents[continent][country].Add(city);
                    }

                }
                else
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                    continents[continent].Add(country, new List<string>());
                    continents[continent][country].Add(city);
                }
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.Write($"  {country.Key} -> ");
                    Console.WriteLine(string.Join(", ", country.Value));
                }
            }
        }
    }
}
