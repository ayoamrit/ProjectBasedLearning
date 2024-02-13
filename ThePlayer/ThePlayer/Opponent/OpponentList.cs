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
        }
    }
}
