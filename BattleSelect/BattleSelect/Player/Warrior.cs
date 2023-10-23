using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSelect.Player
{
    public class Warrior : Character
    {
        const string characterName = "Warrior";
        const int hitPoint = 20;

        const int minPunchDamage = 4;
        const int maxPunchDamage = 7;

        const int minKickDamage = 6;
        const int maxKickDamage = 8;

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
