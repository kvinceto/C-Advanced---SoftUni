using System;
using System.Linq;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSide = int.Parse(Console.ReadLine());
            char[,] field = new char[fieldSide, fieldSide];
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int minerRow = 0;
            int minerCol = 0;
            int coalCounter = 0;
            for (int row = 0; row < fieldSide; row++)
            {
                char[] chars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < fieldSide; col++)
                {
                    field[row, col] = chars[col];
                    switch (chars[col])
                    {
                        case 's':
                            minerCol = col;
                            minerRow = row;
                            break;
                        case 'c':
                            coalCounter++;
                            break;
                    }
                }
            }

            int coalCollected = 0;
            foreach (string command in commands)
            {
                switch (command)
                {
                    case "up":
                        if (minerRow == 0) continue;
                        else minerRow -= 1;
                        break;
                    case "right":
                        if (minerCol == fieldSide - 1) continue;
                        else minerCol += 1;
                        break;
                    case "left":
                        if (minerCol == 0) continue;
                        else minerCol -= 1;
                        break;
                    case "down":
                        if (minerRow == fieldSide - 1) continue;
                        else minerRow += 1;
                        break;
                }

                if (field[minerRow, minerCol] == '*' || field[minerRow, minerCol] == 's') continue;
                else if (field[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    return;
                }
                else if (field[minerRow, minerCol] == 'c')
                {
                    field[minerRow, minerCol] = '*';
                    coalCollected++;
                    if (coalCollected == coalCounter)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{coalCounter - coalCollected} coals left. ({minerRow}, {minerCol})");
        }
    }
}
