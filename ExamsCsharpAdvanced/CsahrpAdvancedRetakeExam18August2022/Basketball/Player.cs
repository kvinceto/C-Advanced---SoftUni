using System;
using System.Text;

namespace Basketball
{
    public class Player
    {
        public Player(string name, string position, double rating, int games)
        {
            Name = name;
            Position = position;
            Rating = rating;
            Games = games;
            Retired = false;
        }
        private string name;
        private string position;
        private double rating;
        private int games;
        private bool retired;

        public bool Retired
        {
            get { return retired; }
            set { retired = value; }
        }

        public int Games
        {
            get { return games; }
            set { games = value; }
        }

        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Player: {Name}");
            sb.AppendLine($"--Position: {Position}");
            sb.AppendLine($"--Rating: {Rating}");
            sb.Append($"--Games played: {Games}");

            return sb.ToString();
        }
    }
}
