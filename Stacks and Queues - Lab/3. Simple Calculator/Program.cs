using System;
using System.Collections.Generic;
using System.Linq;
/*
 Create a simple calculator that can evaluate simple expressions with only addition and subtraction. There will not be any parentheses.
Solve the problem using a Stack.
Examples
Input               	Output
2 + 5 + 10 - 2 - 1      	14
2 - 2 + 5	                 5
 */
namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Array.Reverse(input);
            
            Stack<string> stack = new Stack<string>();
            foreach (string element in input)
            {
                stack.Push(element);
            }

            int sum = int.Parse(stack.Pop());
            int iterations = stack.Count / 2;
            for (int i = 1; i <= iterations; i++)
            {
                string element = stack.Pop();
                if (element == "+")
                {
                    sum += int.Parse(stack.Pop());
                }
                else if (element == "-")
                {
                    sum -= int.Parse(stack.Pop());
                }
            }

            Console.WriteLine(sum);
        }
    }
}
