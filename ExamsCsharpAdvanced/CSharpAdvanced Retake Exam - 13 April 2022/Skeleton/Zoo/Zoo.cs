using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Animals = new List<Animal>();
        }
        private List<Animal> animals;
        private string name;
        private int capacity;

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

        public List<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }
        public string AddAnimal(Animal animal)
        {
            string specie = animal.Species;
            if (specie == null || specie == " ")
            {
                return "Invalid animal species.";
            }

            string diet = animal.Diet;
            if (diet != "herbivore")
                if (diet != "carnivore")
                    return "Invalid animal diet.";
            if (Animals.Count == Capacity)
            {
                return "The zoo is full.";
            }

            Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            List<Animal> removedAnimals = new List<Animal>();
            List<Animal> notRemovedAnimals = new List<Animal>();
            foreach (var animal in Animals)
            {
                if (animal.Species == species)
                {
                    removedAnimals.Add(animal);
                }
                else
                {
                    notRemovedAnimals.Add(animal);
                }
            }

            Animals = notRemovedAnimals;
            return removedAnimals.Count;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animals = new List<Animal>();
            animals = Animals.Where(a => a.Diet == diet).ToList();
            return animals;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            Animal animal = Animals.FirstOrDefault(a => a.Weight == weight);
            return animal;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            List<Animal> animals = new List<Animal>();
            animals = Animals.Where(a => a.Length >= minimumLength && a.Length <= maximumLength).ToList();
            return $"There are {animals.Count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
