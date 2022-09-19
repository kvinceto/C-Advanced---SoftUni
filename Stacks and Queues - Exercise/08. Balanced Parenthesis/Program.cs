using System;
using System.Collections.Generic;

/*
 Given a sequence consisting of parentheses, determine whether the expression is balanced. A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with a closing parenthesis that occurs after the former. Also, the interval between them must be balanced. You will be given three types of parentheses: (, {, and [.
{[()]} - This is a balanced parenthesis.
{[(])} - This is not a balanced parenthesis.
Input
•	Each input consists of a single line, the sequence of parentheses.
Output 
•	For each test case, print on a new line "YES" if the parentheses are balanced. 
Otherwise, print "NO". Do not print the quotes.
Constraints
•	1 ≤ lens ≤ 1000, where the lens is the length of the sequence.
•	Each character of the sequence will be one of {, }, (, ), [, ].
Examples

Input	        Output
{[()]}	        YES
{[(])}	        NO
{{[[(())]]}}	YES
 */
namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool areBalanced = false;

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        areBalanced = false;
                        break;
                    }
                    char lastChar = stack.Pop();

                    if (lastChar == '(' && ch == ')')
                    {
                        areBalanced = true;
                    }
                    else if (lastChar == '[' && ch == ']')
                    {
                        areBalanced = true;
                    }
                    else if (lastChar == '{' && ch == '}')
                    {
                        areBalanced = true;
                    }
                    else
                    {
                        areBalanced = false;
                        break;
                    }
                }
            }

            Console.WriteLine(areBalanced ? "YES" : "NO");
        }
    }
}
