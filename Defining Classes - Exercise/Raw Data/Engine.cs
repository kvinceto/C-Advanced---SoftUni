namespace DefiningClasses
{
    public class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
        private int speed;
        private int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

    }
}
