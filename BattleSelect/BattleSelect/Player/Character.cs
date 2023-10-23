using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSelect.Player
{
    public class Character
    {
        private Random random = new Random();

        public int getDamage(int minDamage, int maxDamage)
        {
            return random.Next(minDamage, maxDamage);
        }
    }
}
