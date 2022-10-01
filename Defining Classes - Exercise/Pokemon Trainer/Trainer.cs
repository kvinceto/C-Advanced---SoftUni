
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer()
        {
            Collection = new List<Pokemon>();
        }
        private string name;
        private int numberOfBadges;
        private List<Pokemon> collection;

        public List<Pokemon> Collection
        {
            get { return collection; }
            set { collection = value; }
        }

        public int NumberOfBadges
        {
            get { return numberOfBadges; }
            set { numberOfBadges = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
