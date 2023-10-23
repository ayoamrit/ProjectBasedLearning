using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSelect.Player
{
    public class Character
    {
        public static Random random = new Random();
        public void startGame()
        {
            Console.WriteLine("Start Fighting Now:");
        }

        public static int getDamage(int minDamage, int maxDamage)
        {
            return random.Next(minDamage, maxDamage);
        }
    }
}
