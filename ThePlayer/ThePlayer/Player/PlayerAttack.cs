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
        public int Power { get; set; }

        public PlayerAttack(int aPunch, int aKick, int aThrow)
        {
            this.Punch = aPunch;
            this.Kick = aKick;
            this.Throw = aThrow;
            Power = 100;
        }
    }
}
