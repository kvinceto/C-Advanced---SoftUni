using System;
using System.Collections.Generic;
/*
 Reads an input consisting of a name and adds it to a queue until "End" is received. If you receive "Paid", print every customer name and empty the queue, otherwise, we receive a client and we have to add him to the queue. When we receive "End" we have to print the count of the remaining people in the queue in the format: "{count} people remaining.".
Examples
Input	Output
Liam
Noah
James
Paid
Oliver
Lucas
Logan
Tiana
End
        Liam
        Noah
        James
        4 people remaining.

Amelia
Thomas
Elias
End
        3 people remaining.
 */
namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                {
                    break;
                }
                else if (name == "Paid")
                {
                    foreach (string currName in names)
                    {
                        Console.WriteLine(currName);
                    }
                    names.Clear();
                }
                else
                {
                    names.Enqueue(name);
                }
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
