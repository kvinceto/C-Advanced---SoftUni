using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var userSideDict = new Dictionary<string, List<string>>();
        string input;
        while ((input = Console.ReadLine()) != "Lumpawaroo")
        {
            if (input.Contains(" | "))
                AddUserToSide(input, userSideDict);
            else if (input.Contains(" -> "))
                ChangeUserSide(input, userSideDict);
        }
        PrintResult(userSideDict);
    }

    static void AddUserToSide(string input, Dictionary<string, List<string>> userSideDict)
    {
        string side = input.Split(" | ").First();
        string user = input.Split(" | ").Last();
        if (!userSideDict.Any(x => x.Value.Contains(user)))
        {
            if (!userSideDict.ContainsKey(side))
                userSideDict.Add(side, new List<string>());
            userSideDict[side].Add(user);
        }
    }

    static void ChangeUserSide(string input, Dictionary<string, List<string>> userSideDict)
    {
        string user = input.Split(" -> ").First();
        string side = input.Split(" -> ").Last();
        if (userSideDict.Any(x => x.Value.Contains(user)))
        {
            string sideToRemoveFrom = userSideDict.Where(x => x.Value.Contains(user)).First().Key;
            userSideDict[sideToRemoveFrom].Remove(user);
        }
        string modifiedInput = side + " | " + user;
        AddUserToSide(modifiedInput, userSideDict);
        Console.WriteLine($"{user} joins the {side} side!");
    }

    static void PrintResult(Dictionary<string, List<string>> userSideDict)
    {
        var filteredDict = userSideDict
            .Where(x => x.Value.Count > 0)
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => x.Key);

        foreach (var side in filteredDict)
        {
            Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
            foreach (var user in side.Value.OrderBy(x => x))
            {
                Console.WriteLine($"! {user}");
            }
        }
    }
}