using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drones = new List<Drone>();
        }
        private List<Drone> drones;

        private List<Drone> Drones
        {
            get { return drones; }
            set { drones = value; }
        }
        private string name;
        private int capacity;
        private double landingStrip;

        public int Count
        {
            get { return Drones.Count; }
        }

        public double LandingStrip
        {
            get { return landingStrip; }
            set { landingStrip = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AddDrone(Drone drone)
        {
            if (drone.Name == null || drone.Brand == null || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            if (Drones.Count == this.capacity)
            {
                return "Airfield is full.";
            }

            Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            List<Drone> drones = new List<Drone>();
            bool isPresent = false;
            foreach (var drone in Drones)
            {
                if (drone.Name != name)
                {
                    drones.Add(drone);
                    continue;
                }
                isPresent = true;
            }

            Drones = drones;
            return isPresent;
        }

        public int RemoveDroneByBrand(string brand)
        {
            List<Drone> removed = new List<Drone>();
            List<Drone> notRemoved = new List<Drone>();
            foreach (var drone in Drones)
            {
                if (drone.Brand == brand)
                {
                    removed.Add(drone);
                }
                else
                {
                    notRemoved.Add(drone);
                }
            }

            Drones = notRemoved;
            return removed.Count;
        }

        public Drone FlyDrone(string name)
        {
            foreach (var drone in Drones)
            {
                if (drone.Name == name)
                {
                    drone.Available = false;
                }
            }

            Drone droneToReturn = null;
            droneToReturn = Drones.First(d => d.Name == name);
            return droneToReturn;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> dronesFly = new List<Drone>();
            foreach (var drone in Drones)
            {
                if (drone.Range >= range)
                {
                    Drone d = FlyDrone(drone.Name);
                    dronesFly.Add(d);
                }
            }
            return dronesFly;
        }

        public string Report()
        {
            List<Drone> drones = Drones.Where(d => d.Available == true).ToList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {this.Name}:");
            string line = string.Join(Environment.NewLine, drones);
            sb.Append(line);
            return sb.ToString();
        }
    }
}
