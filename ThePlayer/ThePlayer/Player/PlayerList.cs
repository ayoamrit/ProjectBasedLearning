using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlayer.Player
{
    public static class PlayerList
    {
        //A list to store player handlers
        public static IList<PlayerHandler> Players { get; private set; }

        //Method to init players
        public static void InitializePLayers()
        {
            //Init the players list
            Players = new List<PlayerHandler>();

            //Process player data to populate the list
            ProcessPlayerData();
        }

        //Method to add players to the list
        private static void ProcessPlayerData()
        {
            Players.Add(new PlayerHandler("Executioner", "5ft 6inch", 71.89, new PlayerAttack(5, 11, 13)));
            Players.Add(new PlayerHandler("Dark Knight", "5ft 9inch", 68.12, new PlayerAttack(12, 3, 15)));
            Players.Add(new PlayerHandler("Defaulter", "4ft 8inch", 41.12, new PlayerAttack(3, 4, 21)));
            Players.Add(new PlayerHandler("Blender", "6ft 10inch", 120.31, new PlayerAttack(31, 5, 31)));
        }

        //Method to list players
        public static void ListPlayers()
        {
            //Iterate through the players list
            for (int x = 0; x < Players.Count; x++)
            {
                Console.WriteLine($"*******Player {x+1}");
                Console.WriteLine($"Player Name: {Players[x].PlayerName}");
                Console.WriteLine($"Player Height: {Players[x].PlayerHeight}");
                Console.WriteLine($"Player Weight: {Players[x].PlayerWeight}");

                Console.WriteLine("**Attack Details");
                //Display player attack details
                Console.WriteLine($"Punch: {Players[x].PlayerAttackList.Punch}");
                Console.WriteLine($"Kick: {Players[x].PlayerAttackList.Kick}");
                Console.WriteLine($"Punch: {Players[x].PlayerAttackList.Punch}");

                //Leave a line for better formatting
                Console.WriteLine();
            }
        }
    }
}
