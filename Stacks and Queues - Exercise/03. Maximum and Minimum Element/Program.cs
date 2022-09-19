using System;
using System.Collections.Generic;
using System.Linq;

/*
 You have an empty sequence, and you will be given N queries. Each query is one of these three types:
1 x – Push the element x into the stack.
2 – Delete the element present at the top of the stack.
3 – Print the maximum element in the stack.
4 – Print the minimum element in the stack.
After you go through all of the queries, print the stack in the following format:
"{n}, {n1}, {n2} …, {nn}"
Input
•	The first line of input contains an integer, N
•	The next N lines each contain an above-mentioned query. (It is guaranteed that each query is valid)
Output
•	For each type 3 or 4 queries, print the maximum/minimum element in the stack on a new line
Constraints
•	1 ≤ N ≤ 105
•	1 ≤ x ≤ 109
•	1 ≤ type ≤ 4
•	If there are no elements in the stack, don’t print anything on commands 3 and 4
Examples
Input           	Output
9
1 97
2
1 20
2
1 26
1 20
3
1 91
4
                26
                20
                91, 20, 26

10
2
1 47
1 66
1 32
4
3
1 25
1 16
1 8
4	
                32
                66
                8
                8, 16, 25, 32, 66, 47
 */
namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfLines; i++)
            {
                int[] cmd = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                switch (cmd[0])
                {
                    case 1:
                        stack.Push(cmd[1]);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
