using System;
namespace DefiningClasses
{
    public class Car
    {
        public Car()
        {
            
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private double fuelAmount;

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }
        private double fuelConsumption;
        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        private double travelledDictannce = 0;
        public double TravelledDistance
        {
            get { return travelledDictannce; }
            set { travelledDictannce = value; }
        }

        public void Drive(double km)
        {
            double result = FuelAmount - (km * FuelConsumptionPerKilometer);
            if (result >= 0)
            {
                FuelAmount -= (km * FuelConsumptionPerKilometer);
                TravelledDistance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
