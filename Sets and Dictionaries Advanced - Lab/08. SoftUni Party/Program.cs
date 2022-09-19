using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            HashSet<string> vipNames = new HashSet<string>();
            bool partyEnded = false;

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "PARTY")
                {
                    partyEnded = CommandParty(names, vipNames);
                }
                else
                {
                    if (char.IsDigit(name[0]))
                    {
                        vipNames.Add(name);
                    }
                    else
                    {
                        names.Add(name);
                    }
                }

                if (partyEnded) break;
            }

            Console.WriteLine($"{names.Count + vipNames.Count}");
            if (vipNames.Count > 0) vipNames.ToList().ForEach(Console.WriteLine);
            if (names.Count > 0) names.ToList().ForEach(Console.WriteLine);
        }

        private static bool CommandParty(HashSet<string> names, HashSet<string> vipNames)
        {
            while (true)
            {
                string name = Console.ReadLine();
                if (name != "END")
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else if (vipNames.Contains(name))
                    {
                        vipNames.Remove(name);
                    }
                    continue;
                }

                bool partyEnded = true;
                return partyEnded;
            }
        }
    }
}
