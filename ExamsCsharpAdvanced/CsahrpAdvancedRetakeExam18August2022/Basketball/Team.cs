using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            Players = new List<Player>();
        }
        private List<Player> players;
        private string name;
        private int openPositions;
        private char group;
        private int count;

        public int Count { get { return Players.Count; } }
        public char Group
        {
            get { return group; }
            set { group = value; }
        }

        public int OpenPositions
        {
            get { return openPositions; }
            set { openPositions = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public string AddPlayer(Player player)
        {
            string name = player.Name;
            string position = player.Position;
            if (name == null || position == null)
            {
                return "Invalid player's information.";
            }

            if (this.OpenPositions == 0)
            {
                return "There are no more open positions.";
            }

            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            Players.Add(player);
            OpenPositions--;
            return $"Successfully added {name} to the team. Remaining open positions: {OpenPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            if (Players.Any(p => p.Name == name))
            {
                foreach (var player in Players)
                {
                    if (player.Name == name)
                    {
                        Players.Remove(player);
                        OpenPositions++;
                        return true;
                    }
                }
            }
            return false;
        }

        public int RemovePlayerByPosition(string position)
        {
            int count = 0;
            List<Player> removed = new List<Player>();
            List<Player> notRemoved = new List<Player>();

            foreach (Player player in Players)
            {
                if (player.Position == position)
                {
                    removed.Add(player);
                }
                else
                {
                    notRemoved.Add(player);
                }
            }

            count = removed.Count;
            if (count > 0)
            {
                OpenPositions += count;
                Players = notRemoved;
                return count;
            }
            return 0;
        }

        public Player RetirePlayer(string name)
        {
            foreach (var player in Players)
            {
                if (player.Name == name)
                {
                    player.Retired = true;
                    return player;
                }
            }

            return null;
        }

        public List<Player> AwardPlayers(int games)
        {
            List<Player> players = new List<Player>();
            foreach (var player in Players)
            {
                if (player.Games >= games)
                {
                    players.Add(player);
                }
            }

            return players;
        }

        public string Report()
        {
           List<Player> notRetired = Players.Where(p => p.Retired == false).ToList();
           StringBuilder sb = new StringBuilder();
           sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
           List<string> lines = new List<string>();
           foreach (var player in notRetired)
           {
               string l = player.ToString();
               lines.Add(l);
           }

           string line = string.Join(Environment.NewLine, lines);
           sb.Append(line);
           return sb.ToString();
        }
    }
}
