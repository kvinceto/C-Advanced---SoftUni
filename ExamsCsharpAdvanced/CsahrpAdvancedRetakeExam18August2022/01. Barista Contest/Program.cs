using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Barista_Contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> drinksPrepared = new Dictionary<string, int>();
            drinksPrepared.Add("Cortado", 0);
            drinksPrepared.Add("Espresso", 0);
            drinksPrepared.Add("Capuccino", 0);
            drinksPrepared.Add("Americano", 0);
            drinksPrepared.Add("Latte", 0);
            int[] coffeeData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> coffeeQuantity = new Queue<int>(coffeeData);
            int[] milkData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> milkQuantity = new Stack<int>();
            foreach (int entry in milkData)
            {
                milkQuantity.Push(entry);
            }

            while (coffeeQuantity.Count > 0 && milkQuantity.Count > 0)
            {
                int productsQuantity = coffeeQuantity.Peek() + milkQuantity.Peek();
                if (productsQuantity == 50)
                {
                    drinksPrepared["Cortado"]++;
                    coffeeQuantity.Dequeue();
                    milkQuantity.Pop();
                }
                else if (productsQuantity == 75)
                {
                    drinksPrepared["Espresso"]++;
                    coffeeQuantity.Dequeue();
                    milkQuantity.Pop();
                }
                else if (productsQuantity == 100)
                {
                    drinksPrepared["Capuccino"]++;
                    coffeeQuantity.Dequeue();
                    milkQuantity.Pop();
                }
                else if (productsQuantity == 150)
                {
                    drinksPrepared["Americano"]++;
                    coffeeQuantity.Dequeue();
                    milkQuantity.Pop();
                }
                else if (productsQuantity == 200)
                {
                    drinksPrepared["Latte"]++;
                    coffeeQuantity.Dequeue();
                    milkQuantity.Pop();
                }
                else
                {
                    coffeeQuantity.Dequeue();
                    int milk = milkQuantity.Pop() - 5;
                    if (milk > 0)
                    {
                        milkQuantity.Push(milk);
                    }
                }
            }

            if (coffeeQuantity.Count == 0 && milkQuantity.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

            Console.WriteLine(coffeeQuantity.Count == 0
                ? "Coffee left: none"
                : $"Coffee left: {string.Join(", ", coffeeQuantity)}");

            Console.WriteLine(milkQuantity.Count == 0
                ? "Milk left: none"
                : $"Milk left: {string.Join(", ", milkQuantity)}");
            drinksPrepared = drinksPrepared
                .OrderBy(d => d.Value)
                .ThenByDescending(d => d.Key)
                .ToDictionary(d => d.Key, d => d.Value);
            foreach (var drink in drinksPrepared)
            {
                if (drink.Value == 0)
                {
                    continue;
                }
                Console.WriteLine($"{drink.Key}: {drink.Value}");
            }
        }
    }
}
