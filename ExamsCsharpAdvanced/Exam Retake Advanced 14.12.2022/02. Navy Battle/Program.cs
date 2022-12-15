using System;
using System.Text;

namespace _02._Navy_Battle
{
    public class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            int submarineRow = 0;
            int submarineCol = 0;
            int mineCounter = 0;
            int cruiserCounter = 0;

            submarineRow = CreateField(n, field, submarineRow, ref submarineCol);

            while (true)
            {
                string command = Console.ReadLine();
                field[submarineRow, submarineCol] = '-';

                if (Move(command, n, ref submarineRow, ref submarineCol)) continue;

                switch (field[submarineRow, submarineCol])
                {
                    case '-': break;
                    case '*': mineCounter++; break;
                    case 'C': cruiserCounter++; break;
                }

                field[submarineRow, submarineCol] = 'S';

                if (mineCounter == 3)
                {
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarineRow}, {submarineCol}]!");
                    break;
                }

                if (cruiserCounter == 3)
                {
                    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    break;
                }
            }

            PrintField(field);
        }

        private static int CreateField(int n, char[,] field, int submarineRow, ref int submarineCol)
        {
            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = rowData[col];
                    if (rowData[col] == 'S')
                    {
                        submarineRow = row;
                        submarineCol = col;
                    }
                }
            }

            return submarineRow;
        }

        private static bool Move(string command, int n, ref int submarineRow, ref int submarineCol)
        {
            if (command == "up")
            {
                if (submarineRow == 0)
                    return true;
                submarineRow -= 1;
            }
            else if (command == "down")
            {
                if (submarineRow == n - 1)
                    return true;
                submarineRow += 1;
            }
            else if (command == "left")
            {
                if (submarineCol == 0)
                    return true;
                submarineCol -= 1;
            }
            else if (command == "right")
            {
                if (submarineCol == n - 1)
                    return true;
                submarineCol += 1;
            }

            return false;
        }

        private static void PrintField(char[,] field)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < field.GetLength(1); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    sb.Append(field[row, col]);
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
