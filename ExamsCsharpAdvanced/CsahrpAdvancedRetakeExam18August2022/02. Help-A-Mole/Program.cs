using System;

namespace _02._Help_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSide = int.Parse(Console.ReadLine());
            char[,] field = new char[fieldSide, fieldSide];
            int moleRow = 0;
            int moleCol = 0;

            for (int row = 0; row < fieldSide; row++)
            {
                char[] charsInARow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < fieldSide; col++)
                {
                    field[row, col] = charsInARow[col];
                    if (field[row, col] == 'M')
                    {
                        moleRow = row;
                        moleCol = col;
                    }
                }
            }

            int points = 0;
            while (points < 25)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else if (command == "up")
                {
                    if (moleRow == 0)
                    {
                        OutOfTheField();
                        continue;
                    }
                    field[moleRow, moleCol] = '-';
                    moleRow -= 1;
                    if (field[moleRow, moleCol] == 'S')
                    {
                        field[moleRow, moleCol] = '-';
                        MoveMoleToSPosition(fieldSide, field, ref moleRow, ref moleCol, ref points);
                    }
                    else if (char.IsDigit(field[moleRow, moleCol]))
                    {
                        points = AddPoints(field, moleRow, moleCol, points);
                    }
                }
                else if (command == "down")
                {
                    if (moleRow == fieldSide - 1)
                    {
                        OutOfTheField();
                        continue;
                    }
                    field[moleRow, moleCol] = '-';
                    moleRow += 1;
                    if (field[moleRow, moleCol] == 'S')
                    {
                        field[moleRow, moleCol] = '-';
                        MoveMoleToSPosition(fieldSide, field, ref moleRow, ref moleCol, ref points);
                    }
                    else if (char.IsDigit(field[moleRow, moleCol]))
                    {
                        points = AddPoints(field, moleRow, moleCol, points);
                    }
                }
                else if (command == "left")
                {
                    if (moleCol == 0)
                    {
                        OutOfTheField();
                        continue;
                    }
                    field[moleRow, moleCol] = '-';
                    moleCol -= 1;
                    if (field[moleRow, moleCol] == 'S')
                    {
                        field[moleRow, moleCol] = '-';
                        MoveMoleToSPosition(fieldSide, field, ref moleRow, ref moleCol, ref points);
                    }
                    else if (char.IsDigit(field[moleRow, moleCol]))
                    {
                        points = AddPoints(field, moleRow, moleCol, points);
                    }
                }
                else if (command == "right")
                {
                    if (moleCol == fieldSide - 1)
                    {
                        OutOfTheField();
                        continue;
                    }
                    field[moleRow, moleCol] = '-';
                    moleCol += 1;
                    if (field[moleRow, moleCol] == 'S')
                    {
                        field[moleRow, moleCol] = '-';
                        MoveMoleToSPosition(fieldSide, field, ref moleRow, ref moleCol, ref points);
                    }
                    else if (char.IsDigit(field[moleRow, moleCol]))
                    {
                        points = AddPoints(field, moleRow, moleCol, points);
                    }
                }

                field[moleRow, moleCol] = 'M';
            }

            if (points >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }

            for (int row = 0; row < fieldSide; row++)
            {
                for (int col = 0; col < fieldSide; col++)
                {
                    Console.Write(field[row, col]);
                }

                Console.WriteLine();
            }
        }

        static void OutOfTheField()
        {
            Console.WriteLine("Don't try to escape the playing field!");
        }

        private static void MoveMoleToSPosition(int fieldSide, char[,] field, ref int moleRow, ref int moleCol, ref int points)
        {
            for (int row = 0; row < fieldSide; row++)
            {
                for (int col = 0; col < fieldSide; col++)
                {
                    if (field[row, col] == 'S')
                    {
                        moleRow = row;
                        moleCol = col;
                        points -= 3;
                        return;
                    }
                }
            }
        }

        private static int AddPoints(char[,] field, int moleRow, int moleCol, int points)
        {
            int fieldPoints = int.Parse(field[moleRow, moleCol].ToString());
            points += fieldPoints;
            return points;
        }
    }
}
