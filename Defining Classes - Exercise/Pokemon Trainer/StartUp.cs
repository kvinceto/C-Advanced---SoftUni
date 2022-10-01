using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Tournament") break;
                string trainerName = command[0];
                string pokemonName = command[1];
                string pokemonElement = command[2];
                int pokemonHealth = int.Parse(command[3]);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer());
                    trainers[trainerName].Name = trainerName;
                }
                trainers[trainerName].Collection.Add(
                    new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End") break;
                switch (cmd)
                {
                    case "Fire":
                        CheckForPokemon(trainers, cmd);
                        break;
                    case "Water":
                        CheckForPokemon(trainers, cmd);
                        break;
                    case "Electricity":
                        CheckForPokemon(trainers, cmd);
                        break;
                }
            }

            trainers = trainers.
                OrderByDescending(t => t.Value.NumberOfBadges)
                .ToDictionary(t => t.Key, t => t.Value);
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumberOfBadges} {trainer.Value.Collection.Count}");
            }
        }

        public static void CheckForPokemon(Dictionary<string, Trainer> trainers, string cmd)
        {
            foreach (var trainer in trainers.Values)
            {
                bool contains = false;
                foreach (var pokemon in trainer.Collection)
                {
                    if (pokemon.Element == cmd)
                    {
                        trainer.NumberOfBadges++;
                        contains = true;
                        break;
                    }
                }

                if (contains)
                {
                    continue;
                }
                foreach (var pokemon in trainer.Collection)
                {
                    pokemon.Health -= 10;
                }

                trainer.Collection = trainer.Collection
                    .Where(p => p.Health > 0).ToList();
            }
        }
    }
}
