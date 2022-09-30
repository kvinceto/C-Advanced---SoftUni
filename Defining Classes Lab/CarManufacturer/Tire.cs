﻿
namespace CarManufacturer
{
    public class Tire
    {
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        private int year;
        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

    }
}
