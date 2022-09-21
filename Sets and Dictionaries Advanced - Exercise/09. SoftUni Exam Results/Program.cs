using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> languages = new Dictionary<string, int>();
            Dictionary<string, int> students = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "exam finished")
                {
                    break;
                }
                else if (input[1] == "banned")
                {
                    string studentName = input[0];
                    if (students.ContainsKey(studentName))
                    {
                        students.Remove(studentName);
                    }
                }
                else
                {
                    string studentName = input[0];
                    string examName = input[1];
                    int points = int.Parse(input[2]);
                    if (!students.ContainsKey(studentName))
                    {
                        students.Add(studentName, points);
                    }

                    if (students[studentName] < points)
                    {
                        students[studentName] = points;
                    }

                    if (!languages.ContainsKey(examName))
                    {
                        languages.Add(examName, 0);
                    }

                    languages[examName]++;
                }
            }

            students = students
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Results:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            languages = languages
                .OrderByDescending(e => e.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");
            foreach (var language in languages)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
