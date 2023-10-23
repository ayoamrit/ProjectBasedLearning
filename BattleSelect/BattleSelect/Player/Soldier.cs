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
        const int minPunchDamage = 2;
        const int maxPunchDamage = 5;

        const int minKickDamage = 4;
        const int maxKickDamage = 7;

        public void printCharacterName()
        {
            Console.WriteLine($"You have selected {characterName}");
        }

        public override string ToString()
        {
            return characterName;
        }
    }
}
