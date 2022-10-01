using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] forest = new char[n, n];

            CreateForest(n, forest);
            Dictionary<char, int> trufflesCollected = new Dictionary<char, int>
            {
                { 'B', 0 },
                { 'S', 0 },
                { 'W', 0 }
            };
            int trufflesEaten = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop the hunt") break;
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                ExecuteCommand(cmd, forest, trufflesCollected, ref trufflesEaten);
            }

            Console.WriteLine($"Peter manages to harvest {trufflesCollected['B']} black, {trufflesCollected['S']} summer, and {trufflesCollected['W']} white truffles.");
            Console.WriteLine($"The wild boar has eaten {trufflesEaten} truffles.");
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < n; row++)
            {
                string line = String.Empty;
                for (int col = 0; col < n; col++)
                {
                    line += $" {forest[row, col]}";
                }

                line = line.Remove(0, 1);
                sb.AppendLine(line);
            }

            Console.WriteLine(sb.ToString());
        }

        private static void ExecuteCommand(string[] cmd, char[,] forest, Dictionary<char, int> trufflesCollected, ref int trufflesEaten)
        {
            switch (cmd[0])
            {
                case "Collect":
                    CollectMethod(cmd, forest, trufflesCollected);
                    break;
                case "Wild_Boar":
                    WildBoarMethod(forest, cmd, ref trufflesEaten);
                    break;
            }
        }

        private static void WildBoarMethod(char[,] forest, string[] cmd, ref int trufflesEaten)
        {
            int rowIndex = int.Parse(cmd[1]);
            int columnIndex = int.Parse(cmd[2]);
            string direction = cmd[3];
            if (forest[rowIndex, columnIndex] != '-')
            {
                trufflesEaten++;
            }
            forest[rowIndex, columnIndex] = '-';
            switch (direction)
            {
                case "up":
                    int counter = 1;
                    while (rowIndex > 0)
                    {
                        rowIndex--;
                        counter++;
                        if (counter % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (forest[rowIndex, columnIndex] != '-')
                            {
                                trufflesEaten++;
                            }
                            forest[rowIndex, columnIndex] = '-';
                        }
                    }
                    break;
                case "down":
                    counter = 1;
                    while (rowIndex < forest.GetLength(0) - 1)
                    {
                        rowIndex++;
                        counter++;
                        if (counter % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (forest[rowIndex, columnIndex] != '-')
                            {
                                trufflesEaten++;
                            }
                            forest[rowIndex, columnIndex] = '-';
                        }
                    }
                    break;
                case "left":
                    counter = 1;
                    while (columnIndex > 0)
                    {
                        columnIndex--;
                        counter++;
                        if (counter % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (forest[rowIndex, columnIndex] != '-')
                            {
                                trufflesEaten++;
                            }
                            forest[rowIndex, columnIndex] = '-';
                        }
                    }
                    break;
                case "right":
                    counter = 1;
                    while (columnIndex < forest.GetLength(1) - 1)
                    {
                        columnIndex++;
                        counter++;
                        if (counter % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (forest[rowIndex, columnIndex] != '-')
                            {
                                trufflesEaten++;
                            }
                            forest[rowIndex, columnIndex] = '-';
                        }
                    }
                    break;
            }
        }

        private static void CollectMethod(string[] cmd, char[,] forest, Dictionary<char, int> trufflesCollected)
        {
            int row = int.Parse(cmd[1]);
            int col = int.Parse(cmd[2]);
            char character = forest[row, col];
            if (character != '-')
            {
                forest[row, col] = '-';
                trufflesCollected[character]++;
            }
        }

        private static void CreateForest(int n, char[,] forest)
        {
            for (int row = 0; row < n; row++)
            {
                char[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    forest[row, col] = data[col];
                }
            }
        }
    }
}
