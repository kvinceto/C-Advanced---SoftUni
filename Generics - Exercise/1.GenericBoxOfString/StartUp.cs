using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Box<string>> boxList = new List<Box<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<string> s = new Box<string>(Console.ReadLine());
                boxList.Add(s);
            }

            boxList.ForEach(Console.WriteLine);
        }
    }
}
