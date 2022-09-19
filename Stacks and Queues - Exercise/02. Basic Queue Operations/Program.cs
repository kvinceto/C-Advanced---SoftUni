using System;
using System.Collections.Generic;
using System.Linq;

/*
 Play around with a queue. You will be given an integer N representing the number of elements to enqueue (add), an integer S representing the number of elements to dequeue (remove) from the queue, and finally an integer X, an element that you should look for in the queue. If it is, print true on the console. If it’s not printed the smallest element is currently present in the queue. If there are no elements in the sequence, print 0 on the console.
Examples
Input	            Output
5 2 32
1 13 45 32 4	    true 

4 1 666
666 69 13 420	    13

3 3 90
90 0 90	            0

 */
namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int add = nums[0];
            int remove = nums[1];
            int chech = nums[2];
            Queue<int> queue = new Queue<int>();
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < add; i++)
            {
                queue.Enqueue(list[0]);
                list.RemoveAt(0);
            }

            for (int i = 0; i < remove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            bool output = queue.Contains(chech);
            if (output)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
