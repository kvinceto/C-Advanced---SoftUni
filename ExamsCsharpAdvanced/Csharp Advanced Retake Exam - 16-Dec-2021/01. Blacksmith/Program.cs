using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> swordData = new Dictionary<int, string>()
            {
                { 70, "Gladius" },
                { 80, "Shamshir" },
                { 90, "Katana" },
                { 110, "Sabre" },
                { 150, "Broadsword" }
            };
            Dictionary<string, int> swordsForged = new Dictionary<string, int>()
            {
                { "Gladius", 0 },
                { "Shamshir", 0 },
                { "Katana", 0 },
                { "Sabre", 0 },
                { "Broadsword", 0 }
            };
            int[] steelData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> steel = new Queue<int>(steelData);
            int[] carbonData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> carbon = new Stack<int>(carbonData);

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int currentSteelQuantity = steel.Dequeue();
                int currentCarbonQuantity = carbon.Pop();
                int sum = currentCarbonQuantity + currentSteelQuantity;
                if (swordData.ContainsKey(sum))
                {
                    swordsForged[swordData[sum]]++;
                }
                else
                {
                    currentCarbonQuantity += 5;
                    carbon.Push(currentCarbonQuantity);
                }
            }

            int counter = 0;
            foreach (var sword in swordsForged)
            {
                counter += sword.Value;
            }

            Console.WriteLine(counter == 0
            ? "You did not have enough resources to forge a sword."
            : $"You have forged {counter} swords.");

            Console.WriteLine(steel.Count == 0
            ? "Steel left: none"
            : $"Steel left: {string.Join(", ", steel)}");

            Console.WriteLine(carbon.Count == 0
            ? "Carbon left: none"
            : $"Carbon left: {string.Join(", ", carbon)}");

            swordsForged = swordsForged.OrderBy(s => s.Key)
                .ToDictionary(s => s.Key, s => s.Value);
            foreach (var sword in swordsForged)
            {
                if (sword.Value > 0)
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }
            }
        }
    }
}
