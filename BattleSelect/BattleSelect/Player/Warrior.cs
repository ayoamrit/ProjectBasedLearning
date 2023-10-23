using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSelect.Player
{
    public class Warrior : Character
    {
        private const string characterName = "Warrior";
        const int hitPoint = 20;

        const int minPunchDamage = 4;
        const int maxPunchDamage = 7;

        const int minKickDamage = 6;
        const int maxKickDamage = 8;

        public override string ToString()
        {
            return characterName;
        }

        public int getPunch()
        {
            return getDamage(minPunchDamage, maxPunchDamage);
        }

        public int getKick()
        {
            return getDamage(minKickDamage, maxKickDamage);
        }

        public int getHealth { get { return hitPoint; } }
    }
}
