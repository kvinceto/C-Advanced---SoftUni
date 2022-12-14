using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Climb_the_Peaks
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Collections of data:
            Queue<string> peaksToClimb = new Queue<string>();
            peaksToClimb.Enqueue("Vihren");
            peaksToClimb.Enqueue("Kutelo");
            peaksToClimb.Enqueue("Banski Suhodol");
            peaksToClimb.Enqueue("Polezhan");
            peaksToClimb.Enqueue("Kamenitza");

            Dictionary<string, int> peaksDifficulty = new Dictionary<string, int>();
            peaksDifficulty.Add("Vihren", 80);
            peaksDifficulty.Add("Kutelo", 90);
            peaksDifficulty.Add("Banski Suhodol", 100);
            peaksDifficulty.Add("Polezhan", 60);
            peaksDifficulty.Add("Kamenitza", 70);

            Queue<string> conqueredPeaks = new Queue<string>();

            // Input:
            int[] foodPortionsData = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            Stack<int> foodPortions = new Stack<int>(foodPortionsData);

            int[] staminaData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> stamina = new Queue<int>(staminaData);

            //Action:

            bool pirinIsConquered = false;

            while (foodPortions.Count > 0 && stamina.Count > 0)
            {
                string peakToClimb = peaksToClimb.Peek();
                int peakDifficulty = peaksDifficulty[peakToClimb];
                int value = foodPortions.Pop() + stamina.Dequeue();

                if (value >= peakDifficulty)
                {
                    conqueredPeaks.Enqueue(peaksToClimb.Dequeue());
                }

                if (peaksToClimb.Count == 0)
                {
                    pirinIsConquered = true;
                    break;
                }
            }

            if (pirinIsConquered)
            {
                Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }
            else
            {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }

            if (conqueredPeaks.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Conquered peaks:");
                foreach (var peak in conqueredPeaks)
                {
                    sb.AppendLine(peak);
                }
                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}
