using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePlayer.Opponent
{
    public class OpponentAttack
    {
        public int Attack { get; set; }
        public int Power { get; set; }

        public OpponentAttack(int aAttack)
        {
            this.Attack = aAttack;
            Power = 100;
        }
    }
}
