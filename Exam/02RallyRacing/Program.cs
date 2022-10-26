using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02RallyRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string racingNumber = Console.ReadLine();
            char[,] field = new char[n, n];
            int racerRow = 0;
            int racerCol = 0;
            int km = 0;
            for (int row = 0; row < n; row++)
            {
                char[] data = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = data[col];
                }
            }
            bool finishReached = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;
                if (command == "up")
                {
                    racerRow--;
                }
                else if (command == "down")
                {
                    racerRow++;
                }
                else if (command == "left")
                {
                    racerCol--;
                }
                else if (command == "right")
                {
                    racerCol++;
                }

                if (field[racerRow, racerCol] == '.')
                {
                    km += 10;
                }
                else if (field[racerRow, racerCol] == 'T')
                {
                    km += 30;
                    field[racerRow, racerCol] = '.';
                    for (int row = 0; row < n; row++)
                    {
                        bool exitFound = false;
                        for (int col = 0; col < n; col++)
                        {
                            if (field[row, col] == 'T')
                            {
                                exitFound = true;
                                field[row, col] = '.';
                                racerRow = row;
                                racerCol = col;
                                break;
                            }
                        }

                        if (exitFound)
                        {
                            break;
                        }
                    }
                }
                else if (field[racerRow, racerCol] == 'F')
                {
                    km += 10;
                    field[racerRow, racerCol] = '.';
                    finishReached = true;
                }

                if (finishReached) break;
            }

            Console.WriteLine(finishReached == true
                ? $"Racing car {racingNumber} finished the stage!"
                : $"Racing car {racingNumber} DNF.");
            Console.WriteLine($"Distance covered {km} km.");
            field[racerRow, racerCol] = 'C';
            StringBuilder sb = new StringBuilder();
            List<string> lines = new List<string>();
            for (int row = 0; row < n; row++)
            {
                string line = String.Empty;
                for (int col = 0; col < n; col++)
                {
                    line += field[row, col];
                }
                lines.Add(line);
            }
            string l = string.Join(Environment.NewLine, lines);
            sb.Append(l);
            Console.WriteLine(sb.ToString());
        }
    }
}
