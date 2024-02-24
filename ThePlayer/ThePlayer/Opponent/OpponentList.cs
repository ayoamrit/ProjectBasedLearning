using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlayer.Opponent
{
    public static class OpponentList
    {
        //A list to store opponent handlers
        public static IList<OpponentHandler> Opponents { get; private set; }

        //Method to init opponents
        public static void InitializeOpponents()
        {
            //Init the opponents list
            Opponents = new List<OpponentHandler>();

            //Process opponent data to populate the list
            ProcessOpponentData();
        }

        //Method to add opponents to the list
        private static void ProcessOpponentData()
        {
            //Add opponents to the list with their details
            Opponents.Add(new OpponentHandler("Deadpool", "6ft 9inch", 69.69, new OpponentAttack(19)));
            Opponents.Add(new OpponentHandler("The Rock", "6ft 4inch", 120, new OpponentAttack(21)));
            Opponents.Add(new OpponentHandler("DareDevil", "7ft 9inch", 200.69, new OpponentAttack(41)));
            Opponents.Add(new OpponentHandler("Crypto", "5ft 4inch", 60, new OpponentAttack(34)));
        }

        //Method to list opponents
        public static void ListOpponents()
        {
            //Iterate through the opponents list
            for(int x = 0; x < Opponents.Count; x++)
            {
                //Display opponent details
                Console.WriteLine($"*******Opponent {x+1}");
                Console.WriteLine($"Opponent Name: {Opponents[x].OpponentName}");
                Console.WriteLine($"Opponent Height: {Opponents[x].OpponentHeight}");
                Console.WriteLine($"Opponent Weight: {Opponents[x].OpponentWeight}");

                Console.WriteLine("**Attack Details");
                //Display opponent attack details
                Console.WriteLine($"Opponent Attack: {Opponents[x].OpponentAttackList.Attack}");

                Console.WriteLine();
            }
        }
    }
}
