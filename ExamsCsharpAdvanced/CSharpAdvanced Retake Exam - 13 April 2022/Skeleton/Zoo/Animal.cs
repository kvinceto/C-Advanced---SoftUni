﻿namespace Zoo
{
    public class Animal
    {
        public Animal(string species, string diet, double weight, double length)
        {
            Species = species;
            Diet = diet;
            Weight = weight;
            Length = length;
        }
        private string species;
        private string diet;
        private double weight;
        private double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Diet
        {
            get { return diet; }
            set { diet = value; }
        }


        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public override string ToString()
        {
            return $"The {Species} is a {Diet} and weighs {Weight} kg.";
        }
    }
}
