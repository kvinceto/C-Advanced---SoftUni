using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mealsInfo = new Dictionary<string, int>
            {
                { "salad", 350 },
                { "soup", 490 },
                { "pasta", 680 },
                { "steak", 790 }
            };
            string[] mealsData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Queue<string> meals = new Queue<string>(mealsData);
            int mealsCount = meals.Count;
            int[] caloriesData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> calories = new Stack<int>(caloriesData);

            while (meals.Count > 0 && calories.Count > 0)
            {
                string currentMeal = meals.Dequeue();
                int currentCalories = calories.Pop();
                if (currentCalories - mealsInfo[currentMeal] >= 0)
                {
                    currentCalories -= mealsInfo[currentMeal];
                    if (currentCalories > 0)
                    {
                        calories.Push(currentCalories);
                    }
                }
                else
                {
                    int n = mealsInfo[currentMeal];
                    if (calories.Count > 0)
                    {
                        currentCalories += calories.Pop();
                        currentCalories -= n;
                        if (currentCalories > 0)
                        {
                            calories.Push(currentCalories);
                        }
                    }
                }
            }

            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {mealsCount} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealsCount - meals.Count} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }

        }
    }
}
