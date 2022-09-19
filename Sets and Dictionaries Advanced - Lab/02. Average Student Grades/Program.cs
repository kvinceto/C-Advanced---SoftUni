using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            int numberOfRecords = int.Parse(Console.ReadLine());

            for (int records = 0; records < numberOfRecords; records++)
            {
                string[] currentRecord = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string studentName = currentRecord[0];
                decimal studentGrade = decimal.Parse(currentRecord[1]);

                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students.Add(studentName, new List<decimal>() { studentGrade });
                }
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (decimal grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
