using System;
using System.Collections.Generic;
using System.Linq;
/*
 Create a program that:
•	Reads an input of integer numbers and adds them to a stack
•	Reads command until "end" is received
•	Prints the sum of the remaining elements of the stack
Input
•	On the first line, you will receive an array of integers
•	On the next lines, until the "end" command is given, you will receive commands – a single command and one or two numbers after the command, depending on what command you are given
•	If the command is "add", you will always receive exactly two numbers after the command which you need to add to the stack
•	If the command is "remove", you will always receive exactly one number after the command which represents the count of the numbers you need to remove from the stack. If there are not enough elements skip the command.
Output
•	When the command "end" is received, you need to print the sum of the remaining elements in the stack
Examples
Input	        Output

1 2 3 4
adD 5 6
REmove 3
eNd
                Sum: 6
3 5 8 4 1 9
add 19 32
remove 10
add 89 22
remove 4
remove 3
end	
                Sum: 16
 */
namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();
            foreach (int number in input)
            {
                stack.Push(number);
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "end")
                {
                    break;
                }

                string[] cmd = command.Split(" ");
                if (cmd[0] == "add")
                {
                    int firstNum = int.Parse(cmd[1]);
                    int secondNum = int.Parse(cmd[2]);
                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (cmd[0] == "remove")
                {
                    int count = int.Parse(cmd[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 1; i <= count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            int sum = 0;
            int iterations = stack.Count;
            for (int i = 0; i < iterations; i++)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
