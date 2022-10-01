using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            for (int i = 1; i <= n; i++)
            {
                string[] engineData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = engineData[0];
                int power = int.Parse(engineData[1]);
                Engine engine = new Engine(model, power);
                if (engineData.Length == 4)
                {
                    int displacement = int.Parse(engineData[2]);
                    string efficiency = engineData[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }
                else if (engineData.Length == 3)
                {
                    bool success = int.TryParse(engineData[2], out int result);
                    if (success)
                    {
                        int displacement = int.Parse(engineData[2]);
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        string efficiency = engineData[2];
                        engine.Efficiency = efficiency;
                    }
                }
                engines.Add(model, engine);
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] carData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                string engineModel = carData[1];
                Car car = new Car(model, engines[engineModel]);
                if (carData.Length == 4)
                {
                    int weight = int.Parse(carData[2]);
                    string color = carData[3];
                    car.Weight = weight;
                    car.Color = color;
                }
                else if (carData.Length == 3)
                {
                    bool success = int.TryParse(carData[2], out int result);
                    if (success)
                    {
                        int weight = int.Parse(carData[2]);
                        car.Weight = weight;
                    }
                    else
                    {
                        string color = carData[2];
                        car.Color = color;
                    }
                }
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
