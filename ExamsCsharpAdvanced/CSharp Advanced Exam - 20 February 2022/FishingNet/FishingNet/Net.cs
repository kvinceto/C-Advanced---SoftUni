using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>();
        }

        private List<Fish> fish;
        private string material;
        private int capacity;
        private int count;

        public int Count
        {
            get { return Fish.Count; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public List<Fish> Fish
        {
            get { return fish; }
            set { fish = value; }
        }

        public string AddFish(Fish fish)
        {
            if (fish.FishType == null || fish.FishType == " " || fish.Length <= 0
                || fish.Weight <= 0)
            {
                return "Invalid fish.";
            }

            if (Fish.Count == Capacity)
            {
                return "Fishing net is full.";
            }
            else
            {
                Fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
        }

        public bool ReleaseFish(double weight)
        {
            List<Fish> removed = new List<Fish>();
            List<Fish> notRemoved = new List<Fish>();
            foreach (Fish fish in Fish)
            {
                if (fish.Weight == weight)
                {
                    removed.Add(fish);
                }
                else
                {
                    notRemoved.Add(fish);
                }
            }

            Fish = notRemoved;
            if (removed.Count > 0) return true;
            else return false;
        }

        public Fish GetFish(string fishType)
        {
            Fish fish = null;
            if (Fish.Any(f => f.FishType == fishType))
            {
                fish = Fish.FirstOrDefault(f => f.FishType == fishType);
            }

            return fish;
        }

        public Fish GetBiggestFish()
        {
            List<Fish> list = Fish.OrderByDescending(f => f.Length).ToList();
            Fish fish = list.First();
            return fish;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            List<Fish> fishList = Fish
                .OrderByDescending(f => f.Length)
                .ToList();
            sb.AppendLine($"Into the {Material}:");
            List<string> lines = new List<string>();
            foreach (var fish in fishList)
            {
                string line = fish.ToString();
                lines.Add(line);
            }

            string allLines = string.Join(Environment.NewLine, lines);
            sb.Append(allLines);
            return sb.ToString();
        }
    }
}
