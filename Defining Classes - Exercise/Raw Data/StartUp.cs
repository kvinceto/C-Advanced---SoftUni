using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                double tireOnePressure = double.Parse(input[5]);
                int tireOneAge = int.Parse(input[6]);
                double tireTwoPressure = double.Parse(input[7]);
                int tireTwoAge = int.Parse(input[8]);
                double tireThreePressure = double.Parse(input[9]);
                int tireThreeAge = int.Parse(input[10]);
                double tireFourPressure = double.Parse(input[11]);
                int tireFourAge = int.Parse(input[12]);
                Car car = new Car(model, speed, power, type, weight,
                    tireOneAge, tireOnePressure,
                    tireTwoAge, tireTwoPressure,
                    tireThreeAge, tireThreePressure,
                    tireFourAge, tireFourPressure);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            Func<Car, double> filterPressure = c =>
            {
                double minPressure = double.MaxValue;
                foreach (Tire tire in c.Tires)
                {
                    if (tire.Pressure < minPressure)
                    {
                        minPressure = tire.Pressure;
                    }
                }
                return minPressure;
            };
            List<Car> sortedCars = new List<Car>();
            if (command == "fragile")
            {
                sortedCars = cars.Where(c => c.Cargo.Type == "fragile").Where(p => filterPressure(p) < 1).ToList();
            }
            else if (command == "flammable")
            {
                sortedCars = cars.Where(c => c.Cargo.Type == "flammable")
                    .Where(c=> c.Engine.Power > 250).ToList();
            }

            sortedCars.ForEach(c => Console.WriteLine(c.Model));
        }
    }
}
