using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        public Parking(int capacity)
        {
            this.capacity = capacity;
            Cars = new List<Car>();
        }
        private List<Car> cars;
        public List<Car> Cars { get { return cars; } set { cars = value; } }
        private int capacity;
        public int Count { get { return cars.Count; } }


        public string AddCar(Car car)
        {
            if (this.Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
                return "Car with that registration number, already exists!";
            else if (this.capacity <= this.Cars.Count)
                return "Parking is full!";
            else
            {
                this.Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!this.Cars.Any(c => c.RegistrationNumber == registrationNumber))
                return $"Car with that registration number, doesn't exist!";
            else
            {
                this.Cars
                    .Remove(Cars
                        .Find(c => c.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
            => this.Cars.Find(c => c.RegistrationNumber == registrationNumber);

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (string number in RegistrationNumbers)
            {
                RemoveCar(number);
            }
        }
    }
}