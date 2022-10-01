using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = inputData[0];
                double fuel = double.Parse(inputData[1]);
                double consumption = double.Parse(inputData[2]);
                Car car = new Car()
                {
                    Model = model,
                    FuelAmount = fuel,
                    FuelConsumptionPerKilometer = consumption
                };

                cars.Add(model, car);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (cmd[0] == "Drive")
                {
                    string carModel = cmd[1];
                    double km = double.Parse(cmd[2]);
                    cars[carModel].Drive(km);
                }
            }

            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
