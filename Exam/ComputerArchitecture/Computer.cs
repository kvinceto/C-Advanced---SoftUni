using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor { get; set; }

        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Count < Capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            CPU cpu = Multiprocessor.FirstOrDefault(c => c.Brand == brand);
            if (cpu != null)
            {
                Multiprocessor.Remove(cpu);
                return true;
            }
            return false;
        }

        public CPU MostPowerful()
        {
            var n = Multiprocessor.OrderByDescending(c => c.Frequency).ToList();
            CPU cpu = n[0];
            return cpu;
        }

        public CPU GetCPU(string brand)
        {
            CPU cpu = Multiprocessor.FirstOrDefault(c => c.Brand == brand);
            if (cpu != null)
            {
                return cpu;
            }

            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {Model}:");
            List<string> lines = new List<string>();
            foreach (CPU cpu in Multiprocessor)
            {
                lines.Add(cpu.ToString());
            }

            string l = string.Join(Environment.NewLine, lines);
            sb.Append(l);
            return sb.ToString();
        }
    }
}
