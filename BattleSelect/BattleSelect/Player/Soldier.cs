using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSelect.Player
{
    public class Soldier : Character
    {
        private const string characterName = "Soldier";
        public const int hitPoint = 25;
        public const int minPunchDamage = 2;
        public const int maxPunchDamage = 5;

        public const int minKickDamage = 4;
        public const int maxKickDamage = 7;

        public override string ToString()
        {
            return characterName;
        }

        public int getKick()
        {
            return getDamage(minKickDamage, maxKickDamage);
        }

        public int getPunch()
        {
            return getDamage(minPunchDamage, maxPunchDamage);
        }

        public int getHealth { get { return hitPoint; } }
    }
}
