using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsList = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> students =
                new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] contest = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                if (contest[0] == "end of contests") break;
                string contestName = contest[0];
                string contestPassword = contest[1];
                if (!contestsList.ContainsKey(contestName))
                {
                    contestsList.Add(contestName, contestPassword);
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "end of submissions") break;
                string currentContestName = command[0];
                string currentContestPassword = command[1];
                string studentName = command[2];
                int studentPoints = int.Parse(command[3]);

                if (contestsList.ContainsKey(currentContestName))
                {
                    if (contestsList[currentContestName] == currentContestPassword)
                    {
                        if (!students.ContainsKey(studentName))
                        {
                            students.Add(studentName, new Dictionary<string, int>());
                            students[studentName].Add(currentContestName, studentPoints);
                            continue;
                        }

                        if (!students[studentName].ContainsKey(currentContestName))
                        {
                            students[studentName].Add(currentContestName, studentPoints);
                            continue;
                        }

                        if (students[studentName][currentContestName] < studentPoints)
                        {
                            students[studentName][currentContestName] = studentPoints;
                        }
                    }
                }
            }

            foreach (var student in students.OrderByDescending(s => s.Value.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {student.Key} with total {student.Value.Values.Sum()} points.");
                break;
            }

            Console.WriteLine("Ranking:");
            foreach (var student in students.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{student.Key}");
                foreach (var contest in student.Value.OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
