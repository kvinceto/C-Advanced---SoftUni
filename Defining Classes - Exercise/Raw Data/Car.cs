namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, int speed, int power, string type, int weight,
            int age1, double pressure1, int age2, double pressure2, int age3, double pressure3, int age4, double pressure4)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(type, weight);
            Tires = new Tire[]
            {
                new Tire(age1, pressure1),
                new Tire(age2, pressure2),
                new Tire(age3, pressure3),
                new Tire(age4, pressure4),
            };
        }
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
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

    }
}
