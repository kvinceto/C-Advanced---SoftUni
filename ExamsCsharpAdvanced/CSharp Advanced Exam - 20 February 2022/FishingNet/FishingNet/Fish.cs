﻿namespace FishingNet
{
    public class Fish
    {
        public Fish(string fishType, double length, double weight)
        {
            FishType = fishType;
            Length = length;
            Weight = weight;
        }
        private string fishType;
        private double length;
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public string FishType
        {
            get { return fishType; }
            set { fishType = value; }
        }

        public override string ToString()
        {
            return $"There is a {FishType}, {Length} cm. long, and {Weight} gr. in weight.";
        }
    }
}
