using System;
using System.Collections.Generic;
using System.Linq;
/*
 Create a program that:
•	Reads an array of integers and adds them to a queue
•	Prints the even numbers separated by ", "
Examples
Input	                        Output
1 2 3 4 5 6                 	2, 4, 6
11 13 18 95 2 112 81 46	        18, 2, 112, 46
 */
namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>(input);
            List<int> evenNumbers = new List<int>();
            while (numbers.Count > 0)
            {
                int currNum = numbers.Dequeue();
                if (currNum % 2 == 0)
                {
                    evenNumbers.Add(currNum);
                }
            }

            Console.WriteLine(string.Join(", ", evenNumbers));

        }
    }
}
