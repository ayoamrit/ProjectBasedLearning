using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlayer.Opponent
{
    public class OpponentHandler
    {
        public string OpponentName { get; set; }
        public string OpponentHeight { get; set; }
        public double OpponentWeight { get; set; }
        public OpponentAttack OpponentAttackList { get; set; }

        public OpponentHandler(string aOpponentName, string aOpponentHeight, double aOpponentWeight, OpponentAttack aOpponentAttackList)
        {
            this.OpponentName = aOpponentName;
            this.OpponentHeight = aOpponentHeight;
            this.OpponentWeight = aOpponentWeight;
            this.OpponentAttackList = aOpponentAttackList;
        } 
    }
}
