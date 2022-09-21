using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe =
                new Dictionary<string, Dictionary<string,int>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] clothes = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string item in clothes)
                {
                    AddClothes(wardrobe, color, item);
                }
            }

            string[] itemToLook = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string itemColor = itemToLook[0];
            string itemClothes = itemToLook[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothes in color.Value)
                {
                    Console.Write($"* {clothes.Key} - {clothes.Value} ");
                    if (color.Key == itemColor && clothes.Key == itemClothes)
                    {
                        Console.Write("(found!)");
                    }

                    Console.WriteLine();
                }
            }
        }

        private static void AddClothes(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string item)
        {
            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
                if (!wardrobe[color].ContainsKey(item))
                {
                    wardrobe[color].Add(item, 1);
                    return;
                }

                wardrobe[color][item]++;
                return;
            }

            if (!wardrobe[color].ContainsKey(item))
            {
                wardrobe[color].Add(item, 1);
                return;
            }

            wardrobe[color][item]++;
        }
    }
}
