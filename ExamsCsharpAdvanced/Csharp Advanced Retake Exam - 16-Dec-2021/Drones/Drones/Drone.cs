using System.Text;

namespace Drones
{
    public class Drone
    {
        public Drone(string name, string brand, int range)
        {
            this.name = name;
            this.brand = brand;
            this.range = range;
            this.available = true;
        }
        private string name;
        private string brand;
        private int range;
        private bool available;

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drone: {this.name}");
            sb.AppendLine($"Manufactured by: {this.brand}");
            sb.Append($"Range: {this.range} kilometers");
            return sb.ToString();
        }
    }
}
