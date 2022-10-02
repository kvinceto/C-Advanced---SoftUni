using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Beaver_at_Work
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] pond = new char[n, n];
            int beverRow = 0;
            int beverCol = 0;

            DrawPond(n, pond, ref beverRow, ref beverCol);

            Stack<char> branches = new Stack<char>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end") break;

                switch (command)
                {
                    case "up":
                        if (beverRow == 0)
                        {
                            if (branches.Count > 0) branches.Pop();
                        }
                        else
                        {
                            beverRow--;
                            char character = pond[beverRow, beverCol];
                            if (Char.IsLower(character))
                            {
                                branches.Push(character);
                                pond[beverRow, beverCol] = '-';
                            }
                            else if (character == 'F')
                            {
                                pond[beverRow, beverCol] = '-';
                                if (beverRow == 0) beverRow = n - 1;
                                else if (beverRow == n - 1) beverRow = 0;
                                else if (beverCol == 0) beverCol = n - 1;
                                else if (beverCol == n - 1) beverCol = 0;
                                else
                                {
                                    beverRow = 0;
                                }

                                if (Char.IsLower(pond[beverRow, beverCol]))
                                {
                                    branches.Push(pond[beverRow, beverCol]);
                                    pond[beverRow, beverCol] = '-';
                                }
                            }
                        }
                        break;
                    case "down":
                        if (beverRow == n - 1)
                        {
                            if (branches.Count > 0) branches.Pop();
                        }
                        else
                        {
                            beverRow++;
                            char character = pond[beverRow, beverCol];
                            if (Char.IsLower(character))
                            {
                                branches.Push(character);
                                pond[beverRow, beverCol] = '-';
                            }
                            else if (character == 'F')
                            {
                                pond[beverRow, beverCol] = '-';
                                if (beverRow == 0) beverRow = n - 1;
                                else if (beverRow == n - 1) beverRow = 0;
                                else if (beverCol == 0) beverCol = n - 1;
                                else if (beverCol == n - 1) beverCol = 0;
                                else
                                {
                                    beverRow = n - 1;
                                }

                                if (Char.IsLower(pond[beverRow, beverCol]))
                                {
                                    branches.Push(pond[beverRow, beverCol]);
                                    pond[beverRow, beverCol] = '-';
                                }
                            }
                        }
                        break;
                    case "left":
                        if (beverCol == 0)
                        {
                            if (branches.Count > 0) branches.Pop();
                        }
                        else
                        {
                            beverCol--;
                            char character = pond[beverRow, beverCol];
                            if (Char.IsLower(character))
                            {
                                branches.Push(character);
                                pond[beverRow, beverCol] = '-';
                            }
                            else if (character == 'F')
                            {
                                pond[beverRow, beverCol] = '-';
                                if (beverRow == 0) beverRow = n - 1;
                                else if (beverRow == n - 1) beverRow = 0;
                                else if (beverCol == 0) beverCol = n - 1;
                                else if (beverCol == n - 1) beverCol = 0;
                                else
                                {
                                    beverCol = 0;
                                }

                                if (Char.IsLower(pond[beverRow, beverCol]))
                                {
                                    branches.Push(pond[beverRow, beverCol]);
                                    pond[beverRow, beverCol] = '-';
                                }
                            }
                        }
                        break;
                    case "right":
                        if (beverCol == n - 1)
                        {
                            if (branches.Count > 0) branches.Pop();
                        }
                        else
                        {
                            beverCol++;
                            char character = pond[beverRow, beverCol];
                            if (Char.IsLower(character))
                            {
                                branches.Push(character);
                                pond[beverRow, beverCol] = '-';
                            }
                            else if (character == 'F')
                            {
                                pond[beverRow, beverCol] = '-';
                                if (beverRow == 0) beverRow = n - 1;
                                else if (beverRow == n - 1) beverRow = 0;
                                else if (beverCol == 0) beverCol = n - 1;
                                else if (beverCol == n - 1) beverCol = 0;
                                else
                                {
                                    beverCol = n - 1;
                                }

                                if (Char.IsLower(pond[beverRow, beverCol]))
                                {
                                    branches.Push(pond[beverRow, beverCol]);
                                    pond[beverRow, beverCol] = '-';
                                }
                            }
                        }
                        break;
                }
            }

            pond[beverRow, beverCol] = 'B';
            bool collected = true;
            foreach (char character in pond)
            {
                if (Char.IsLower(character))
                {
                    collected = false;
                    break;
                }
            }

            if (collected)
            {
                List<char> branchesCollected = new List<char>();
                int iteration = branches.Count;
                for (int i = 0; i < iteration; i++)
                {
                    branchesCollected.Add(branches.Pop());
                }

                char[] branchesCollectedArr = branchesCollected.ToArray().Reverse().ToArray();
                Console.WriteLine($"The Beaver successfully collect {branchesCollectedArr.Length} wood branches: {string.Join(", ", branchesCollectedArr)}.");
            }
            else
            {
                int count = 0;
                foreach (char character in pond)
                {
                    if (Char.IsLower(character))
                    {
                        count++;
                    }
                }
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {count} branches left.");
            }
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < n; row++)
            {
                string line = String.Empty;
                for (int col = 0; col < n; col++)
                {
                    line += $" {pond[row, col]}";
                }

                line = line.Remove(0, 1);
                sb.AppendLine(line);
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static void DrawPond(int n, char[,] pond, ref int beverRow, ref int beverCol)
        {

            for (int row = 0; row < n; row++)
            {
                char[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    pond[row, col] = data[col];
                    if (data[col] == 'B')
                    {
                        beverRow = row;
                        beverCol = col;
                        pond[row, col] = '-';
                    }
                }
            }
        }
    }
}
