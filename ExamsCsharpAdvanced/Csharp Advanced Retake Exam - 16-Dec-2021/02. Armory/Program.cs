using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] armory = new char[n, n];
            int officerRow = 0;
            int officerCol = 0;

            for (int row = 0; row < n; row++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    armory[row, col] = data[col];
                    if (data[col] == 'A')
                    {
                        officerRow = row;
                        officerCol = col;
                        armory[row, col] = '-';
                    }
                }
            }

            bool outOfTheArmory = false;
            int moneySpend = 0;
            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        outOfTheArmory = CommandUp(ref officerRow, armory, ref officerCol, n, ref moneySpend);
                        break;
                    case "down":
                        outOfTheArmory = CommandDown(ref officerRow, armory, ref officerCol, n, ref moneySpend);
                        break;
                    case "left":
                        outOfTheArmory = CommandLeft(ref officerCol, armory, ref officerRow, n, ref moneySpend);
                        break;
                    case "right":
                        outOfTheArmory = CommandRight(n, armory, ref officerRow, ref officerCol, ref moneySpend);
                        break;
                }

                if (moneySpend >= 65) break;
                if (outOfTheArmory) break;
            }

            Console.WriteLine(outOfTheArmory == true
            ? "I do not need more swords!"
            : "Very nice swords, I will come back for more!");

            Console.WriteLine($"The king paid {moneySpend} gold coins.");
            if (outOfTheArmory == false)
            {
                armory[officerRow, officerCol] = 'A';
            }
            List<string> lines = new List<string>();
            for (int row = 0; row < n; row++)
            {
                string line = String.Empty;
                for (int col = 0; col < n; col++)
                {
                    line += armory[row,col].ToString();
                }   
                lines.Add(line);
            }
            lines.ForEach(Console.WriteLine);
        }

        private static bool CommandRight(int n, char[,] armory, ref int officerRow, ref int officerCol, ref int moneySpend)
        {
            if (officerCol == armory.GetLength(1) - 1)
            {
                return true;
            }
            else
            {
                officerCol++;
                if (armory[officerRow, officerCol] == '-')
                {
                }
                else if (Char.IsDigit(armory[officerRow, officerCol]))
                {
                    moneySpend += int.Parse(armory[officerRow, officerCol]
                        .ToString());
                    armory[officerRow, officerCol] = '-';
                }
                else if (armory[officerRow, officerCol] == 'M')
                {
                    armory[officerRow, officerCol] = '-';
                    for (int row = 0; row < n; row++)
                    {
                        bool end = false;
                        for (int col = 0; col < n; col++)
                        {
                            if (armory[row, col] == 'M')
                            {
                                officerRow = row;
                                officerCol = col;
                                armory[row, col] = '-';
                                end = true;
                                break;
                            }

                            if (end) break;
                        }
                    }
                }
            }

            return false;
        }

        private static bool CommandLeft(ref int officerCol, char[,] armory, ref int officerRow, int n,
            ref int moneySpend)
        {
            if (officerCol == 0)
            {
                return true;
            }
            else
            {
                officerCol--;
                if (armory[officerRow, officerCol] == '-')
                {
                }
                else if (Char.IsDigit(armory[officerRow, officerCol]))
                {
                    moneySpend += int.Parse(armory[officerRow, officerCol]
                        .ToString());
                    armory[officerRow, officerCol] = '-';
                }
                else if (armory[officerRow, officerCol] == 'M')
                {
                    armory[officerRow, officerCol] = '-';
                    for (int row = 0; row < n; row++)
                    {
                        bool end = false;
                        for (int col = 0; col < n; col++)
                        {
                            if (armory[row, col] == 'M')
                            {
                                officerRow = row;
                                officerCol = col;
                                armory[row, col] = '-';
                                end = true;
                                break;
                            }

                            if (end) break;
                        }
                    }
                }
            }

            return false;
        }

        private static bool CommandDown(ref int officerRow, char[,] armory, ref int officerCol, int n,
            ref int moneySpend)
        {
            if (officerRow == armory.GetLength(0) - 1)
            {
                return true;
            }
            else
            {
                officerRow++;
                if (armory[officerRow, officerCol] == '-')
                {
                }
                else if (Char.IsDigit(armory[officerRow, officerCol]))
                {
                    moneySpend += int.Parse(armory[officerRow, officerCol]
                        .ToString());
                    armory[officerRow, officerCol] = '-';
                }
                else if (armory[officerRow, officerCol] == 'M')
                {
                    armory[officerRow, officerCol] = '-';
                    for (int row = 0; row < n; row++)
                    {
                        bool end = false;
                        for (int col = 0; col < n; col++)
                        {
                            if (armory[row, col] == 'M')
                            {
                                officerRow = row;
                                officerCol = col;
                                armory[row, col] = '-';
                                end = true;
                                break;
                            }

                            if (end) break;
                        }
                    }
                }
            }

            return false;
        }

        private static bool CommandUp(ref int officerRow, char[,] armory, ref int officerCol, int n, ref int moneySpend)
        {
            if (officerRow == 0)
            {
                return true;
            }
            else
            {
                officerRow--;
                if (armory[officerRow, officerCol] == '-')
                {
                }
                else if (Char.IsDigit(armory[officerRow, officerCol]))
                {
                    moneySpend += int.Parse(armory[officerRow, officerCol]
                        .ToString());
                    armory[officerRow, officerCol] = '-';
                }
                else if (armory[officerRow, officerCol] == 'M')
                {
                    armory[officerRow, officerCol] = '-';
                    for (int row = 0; row < n; row++)
                    {
                        bool end = false;
                        for (int col = 0; col < n; col++)
                        {
                            if (armory[row, col] == 'M')
                            {
                                officerRow = row;
                                officerCol = col;
                                armory[row, col] = '-';
                                end = true;
                                break;
                            }

                            if (end) break;
                        }
                    }
                }
            }

            return false;
        }
    }
}
