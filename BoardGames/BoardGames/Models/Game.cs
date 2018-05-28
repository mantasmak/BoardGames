using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGames
{
    public class Game
    {
        public static int id = 0;
        public string RoomName { get; set; }
        public string GameName { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int PlayerCount { get; set; }
        public string PlayerAmount => string.Format("{0}/{1}", PlayerCount, MaxPlayers);
        public string Location { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }

        public Game(string roomName, string gameName, int minPlayers, int maxPlayers, string location, DateTime time, string description = "")
        {
            id++;
            RoomName = roomName;
            GameName = gameName;
            MinPlayers = minPlayers;
            MaxPlayers = maxPlayers;
            PlayerCount = 1;
            Location = location;
            Time = time;
            Description = description;
        }

        public void AddPlayer()
        {
            PlayerCount++;
        }
    }
}
