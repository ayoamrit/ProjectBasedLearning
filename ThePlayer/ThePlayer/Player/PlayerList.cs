using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlayer.Player
{
    public static class PlayerList
    {
        public static IList<PlayerHandler> Players { get; private set; }

        public static void InitializePLayers()
        {
            Players = new List<PlayerHandler>();
            ProcessPlayerData();
        }

        private static void ProcessPlayerData()
        {

            Players.Add(new PlayerHandler("Executioner", "5ft 6inch", 71.89, new PlayerAttack(5, 11, 13, 21)));
            Players.Add(new PlayerHandler("Dark Knight", "5ft 9inch", 68.12, new PlayerAttack(12, 3, 15, 19)));
        }

        public static void ListPlayer()
        {
            for (int x = 0; x < Players.Count; x++)
            {
                Console.WriteLine($"*******Player {x}");
                Console.WriteLine($"Player Name: {Players[x].PlayerName}");
                Console.WriteLine($"Player Height: {Players[x].PlayerHeight}");
                Console.WriteLine($"Player Weight: {Players[x].PlayerWeight}");

                Console.WriteLine("**Attack Details");
                Console.WriteLine($"Punch: {Players[x].PlayerAttackList.Punch}");
                Console.WriteLine($"Kick: {Players[x].PlayerAttackList.Kick}");
                Console.WriteLine($"Punch: {Players[x].PlayerAttackList.Punch}");
                Console.WriteLine($"Defend: {Players[x].PlayerAttackList.Defend}");

                //Leave a line for better formatting
                Console.WriteLine();
            }
        }
    }
}
