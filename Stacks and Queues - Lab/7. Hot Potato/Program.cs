using System;
using System.Collections.Generic;
using System.Linq;
/*
 Hot potato is a game in which children form a circle and start passing a hot potato. The counting starts with the first kid. Every nth toss the child left with the potato leaves the game. When a kid leaves the game, it passes the potato along. This continues until there is only one kid left.
Create a program that simulates the game of Hot Potato.  Print every kid that is removed from the circle. In the end, print the kid that is left last.

Examples
Input	                Output
Alva James William
2	
                    Removed James
                    Removed Alva
                    Last is William
Lucas Jacob Noah Logan Ethan
10	
                    Removed Ethan
                    Removed Jacob
                    Removed Noah
                    Removed Lucas
                    Last is Logan
Carter Dylan Jack Luke Gabriel
1
                    Removed Carter
                    Removed Dylan
                    Removed Jack
                    Removed Luke
                    Last is Gabriel 
 */
namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> players = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine());

            while (players.Count > 1)
            {
                for (int i = 1; i <= n-1; i++)
                {
                    string player = players.Dequeue();
                    players.Enqueue(player);
                }

                string lostPlayer = players.Dequeue();
                Console.WriteLine($"Removed {lostPlayer}");
            }

            string winner = players.Dequeue();
            Console.WriteLine($"Last is {winner}");

        }
    }
}
