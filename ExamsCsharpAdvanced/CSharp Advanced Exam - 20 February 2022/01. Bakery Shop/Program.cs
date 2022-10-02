using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> productsRecipes = new Dictionary<string, string>()
            {
                { "5050", "Croissant" },
                { "4060", "Muffin" },
                { "3070", "Baguette" },
                { "2080", "Bagel" },
            };
            Dictionary<string, int> productsMade = new Dictionary<string, int>()
            {
                { "Croissant", 0 },
                { "Muffin", 0 },
                { "Baguette", 0 },
                { "Bagel", 0 }
            };

            double[] waterData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Queue<double> waterQueue = new Queue<double>(waterData);
            double[] flourData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Stack<double> flourStack = new Stack<double>(flourData);

            while (waterQueue.Count > 0 && flourStack.Count > 0)
            {
                double water = waterQueue.Dequeue();
                double flour = flourStack.Pop();
                double waterPercent = water * 100 / (water + flour);
                double flourPercent = 100 - waterPercent;
                string recipe = waterPercent.ToString() + flourPercent.ToString();
                if (productsRecipes.ContainsKey(recipe))
                {
                    productsMade[productsRecipes[recipe]]++;

                }
                else
                {
                    productsMade["Croissant"]++;
                    flour -= water;
                    flourStack.Push(flour);
                }
            }

            productsMade = productsMade
                .Where(p => p.Value > 0)
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key)
                .ToDictionary(p => p.Key, p => p.Value);
            foreach (var product in productsMade)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            Console.WriteLine(waterQueue.Count > 0
            ? $"Water left: {string.Join(", ", waterQueue)}"
            : "Water left: None");
            Console.WriteLine(flourStack.Count > 0
            ? $"Flour left: {string.Join(", ", flourStack)}"
            : "Flour left: None");
        }
    }
}
