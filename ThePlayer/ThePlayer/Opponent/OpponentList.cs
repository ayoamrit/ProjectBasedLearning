using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlayer.Opponent
{
    public static class OpponentList
    {
        public static IList<OpponentHandler> Opponents { get; private set; }

        public static void InitializeOpponents()
        {
            Opponents = new List<OpponentHandler>();
            ProcessOpponentData();
        }

        private static void ProcessOpponentData()
        {
            Opponents.Add(new OpponentHandler("Deadpool", "6ft 9inch", 69.69, new OpponentAttack(19)));
            Opponents.Add(new OpponentHandler("The Rock", "6ft 4inch", 120, new OpponentAttack(21)));
            Opponents.Add(new OpponentHandler("DareDevil", "7ft 9inch", 200.69, new OpponentAttack(41)));
            Opponents.Add(new OpponentHandler("Crypto", "5ft 4inch", 60, new OpponentAttack(34)));
        }

        public static void ListOpponents()
        {
            for(int x = 0; x < Opponents.Count; x++)
            {
                Console.WriteLine($"*******Opponent {x+1}");
                Console.WriteLine($"Opponent Name: {Opponents[x].OpponentName}");
                Console.WriteLine($"Opponent Height: {Opponents[x].OpponentHeight}");
                Console.WriteLine($"Opponent Weight: {Opponents[x].OpponentWeight}");

                Console.WriteLine("**Attack Details");
                Console.WriteLine($"Opponent Attack: {Opponents[x].OpponentAttackList.Attack}");

                Console.WriteLine();
            }
        }
    }
}
