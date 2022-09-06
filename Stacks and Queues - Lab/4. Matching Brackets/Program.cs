using System;
using System.Collections.Generic;
/*
 We are given an arithmetic expression with brackets. Scan through the string and extract each sub-expression.
Print the result back at the terminal.

Examples
Input	 

1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5	
Output

(2 + 3)
(3 + 1)
(2 - (2 + 3) * 4 / (3 + 1))
 */
namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string str = input;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar == '(')
                {
                    stack.Push(i);
                }

                if (currChar == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string substring = str.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
