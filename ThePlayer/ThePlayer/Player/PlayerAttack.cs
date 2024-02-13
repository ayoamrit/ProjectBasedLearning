using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlayer.Player
{
    public class PlayerAttack
    {
        public int Punch { get; set; }
        public int Kick { get; set; }
        public int Throw { get; set; }
        public int Defend { get; set; }
        public static int Power { get; set; }

        public PlayerAttack(int aPunch, int aKick, int aThrow, int aDefend)
        {
            this.Punch = aPunch;
            this.Kick = aKick;
            this.Throw = aThrow;
            this.Defend = aDefend;
            Power = 100;
        }
    }
}
