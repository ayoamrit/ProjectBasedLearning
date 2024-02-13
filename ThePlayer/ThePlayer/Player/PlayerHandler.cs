using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlayer.Player
{
    public class PlayerHandler
    {
        public string PlayerName { get; set; }
        public string PlayerHeight { get; set; }
        public double PlayerWeight { get; set; }
        public PlayerAttack PlayerAttackList { get; set; }

        public PlayerHandler(string aPlayerName, string aPlayerHeight, double aPlayerWeight, PlayerAttack aPlayerAttackList)
        {
            PlayerName = aPlayerName;
            PlayerHeight = aPlayerHeight;
            PlayerWeight = aPlayerWeight;
            PlayerAttackList = aPlayerAttackList;
        }
    }
}
