using System;
using System.Collections.Generic;
using System.Linq;
/*
 Play around with a stack. You will be given an integer N representing the number of elements to push into the stack, an integer S representing the number of elements to pop from the stack, and finally an integer X, an element that you should look for in the stack. If it’s found, print "true" on the console. If it isn't, print the smallest element currently present in the stack. If there are no elements in the sequence, print 0 on the console.
Input
•	On the first line, you will be given N, S, and X, separated by a single space
•	On the next line, you will be given N number of integers
Output
•	On a single line print either true if X is present in the stack, otherwise print the smallest element in the stack. If the stack is empty, print 0
Input	                 Output
5 2 13
1 13 45 32 4	         true

4 1 666
420 69 13 666	         13
 */
namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
           int push = nums[0];
           int pop = nums[1];
           int check = nums[2];

           List<int> numbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));
           Stack<int> stack = new Stack<int>();
           for (int i = 0; i < push; i++)
           {
               stack.Push(numbers[0]);
               numbers.RemoveAt(0);
           }

           for (int i = 0; i < pop; i++)
           {
               stack.Pop();
           }

           if (stack.Count == 0)
           {
               Console.WriteLine(0);
               return;
           }
           bool output = stack.Contains(check);
           if (output)
           {
               Console.WriteLine("true");
           }
           else
           {
               Console.WriteLine(stack.Min());
           }
        }
    }
}
