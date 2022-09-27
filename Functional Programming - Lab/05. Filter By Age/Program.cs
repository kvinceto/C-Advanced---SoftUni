using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(input[0], int.Parse(input[1])));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            people = condition == "older"
                ? people.Where(p => p.Age >= age).ToList()
                : people.Where(p => p.Age < age).ToList();

            Func<Person, string, string> func = (p, f) =>
            {
                if (f == "name")
                {
                    return $"{p.Name}";
                }
                else if (f == "age")
                {
                    return $"{p.Age}";
                }
                else if (f == "name age")
                {
                    return $"{p.Name} - {p.Age}";
                }

                return null;
            };
            List<string> ppl = people.Select(person => func(person, format)).ToList();

            ppl.ForEach(Console.WriteLine);
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
