using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 You are given an empty text. Your task is to implement 4 commands related to manipulating the text
•	1 someString - appends someString to the end of the text
•	2 count - erases the last count elements from the text
•	3 index - returns the element at position index from the text
•	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation
Input
•	The first line contains n, the number of operations.
•	Each of the following n lines contains the name of the operation followed by the command argument, if any, separated by space in the following format "CommandName Argument".
Output
•	For each operation of type 3 print a single line with the returned character of that operation.
Constraints
•	1 ≤ N ≤ 105
•	The length of the text will not exceed 1000000
•	All input characters are English letters.
•	It is guaranteed that the sequence of input operations is possible to perform.
 

Examples
Input	Output
8
1 abc
3 3
2 3
1 xy
3 2
4
4 
3 1	         
            c
            y
            a
 */
namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Stack<string> textStack = new Stack<string>();
            textStack.Push(sb.ToString());
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                CommandImplementation(commands, sb, textStack);
            }
        }

        private static void CommandImplementation(string[] commands, StringBuilder sb, Stack<string> textStack)
        {
            switch (commands[0])
            {
                case "1":
                    sb = sb.Clear();
                    sb.Append(textStack.Peek());
                    sb.Append(commands[1]);
                    textStack.Push(sb.ToString());
                    break;
                case "2":
                    int numberOfCharsToRemove = int.Parse(commands[1]);
                    sb.Clear();
                    sb.Append(textStack.Peek());
                    sb = sb.Remove((sb.Length - 1) - (numberOfCharsToRemove - 1), numberOfCharsToRemove);
                    textStack.Push(sb.ToString());
                    break;
                case "3":
                    int positionOfChar = int.Parse(commands[1]);
                    string lastString = textStack.Peek();
                    Console.WriteLine(lastString[positionOfChar - 1]);
                    break;
                case "4":
                    textStack.Pop();
                    break;
            }
        }
    }
}
