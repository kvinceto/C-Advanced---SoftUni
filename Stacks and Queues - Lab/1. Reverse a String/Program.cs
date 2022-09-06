using System;
using System.Collections.Generic;
/*
 Create a program that:
•	Reads an input string
•	Reverses it using a Stack<T>
•	Prints the result back at the terminal
Examples
Input	I Love C# / Stacks and Queues
Output  #C evoL I / seueuQ dna skcatS
 */
namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            Stack<char> stack = new Stack<char>();

            foreach (char ch in arr)
            {
               stack.Push(ch); 
            }

            int iterations = arr.Length;

            for (int i = 0; i < iterations; i++)
            {
                char currentChar = stack.Pop();
                Console.Write(currentChar);
            }
        }
    }
}
