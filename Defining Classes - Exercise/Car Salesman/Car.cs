using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public override string ToString()
        {
            string displacement = this.Engine.Displacement != 0
                ? this.Engine.Displacement.ToString()
                : "n/a";
            string efficiency = this.Engine.Efficiency != null
                    ? this.Engine.Efficiency.ToString()
                    : "n/a";
            string weight = this.Weight != 0
                ? this.Weight.ToString()
                : "n/a";
            string color = this.Color != null
                ? this.Color.ToString()
                : "n/a";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            sb.AppendLine($"    Displacement: {displacement}");
            sb.AppendLine($"    Efficiency: {efficiency}");
            sb.AppendLine($"  Weight: {weight}");
            sb.Append($"  Color: {color}");

            return sb.ToString();
        }
    }
}
