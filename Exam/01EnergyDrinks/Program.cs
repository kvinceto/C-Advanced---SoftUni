using System;
using System.Collections.Generic;
using System.Linq;

namespace _01EnergyDrinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxCaffeine = 300;
            Stack<int> caffeine = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Queue<int> drinks = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int stamatCaffeine = 0;

            while (caffeine.Count > 0 && drinks.Count > 0)
            {
                int currentCaffeine = caffeine.Peek();
                int currentDrink = drinks.Peek();
                int n = currentDrink * currentCaffeine;
                if (n <= maxCaffeine)
                {
                    if (stamatCaffeine + n <= maxCaffeine)
                    {
                        stamatCaffeine += n;
                        caffeine.Pop();
                        drinks.Dequeue();
                    }
                    else
                    {
                        caffeine.Pop();
                        drinks.Enqueue(drinks.Dequeue());
                        if (stamatCaffeine < 30)
                        {
                            stamatCaffeine = 0;
                        }
                        else
                        {
                            stamatCaffeine -= 30;
                        }
                    }
                }
                else
                {
                    caffeine.Pop();
                    drinks.Enqueue(drinks.Dequeue());
                    if (stamatCaffeine < 30)
                    {
                        stamatCaffeine = 0;
                    }
                    else
                    {
                        stamatCaffeine -= 30;
                    }
                }
            }

            Console.WriteLine(drinks.Count > 0
                ? $"Drinks left: {string.Join(", ", drinks)}"
                : "At least Stamat wasn't exceeding the maximum caffeine.");
            Console.WriteLine($"Stamat is going to sleep with {stamatCaffeine} mg caffeine.");
        }
    }
}
