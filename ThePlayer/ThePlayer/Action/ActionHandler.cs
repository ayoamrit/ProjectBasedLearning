using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePlayer.Opponent;
using ThePlayer.Player;

namespace ThePlayer.Action
{
    public class ActionHandler
    {
        private Random random = new Random();
        private int selectedOpponent { get; set; }
        private int selectedPlayer { get; set; }
        private int OpponentMaxAttack { get; set; }

        public ActionHandler(int opponentMaxAttack, int selectedPlayer, int selectedOpponent)
        {
            this.OpponentMaxAttack = opponentMaxAttack;
            this.selectedPlayer = selectedPlayer;
            this.selectedOpponent = selectedOpponent;
        }

        public void PlayerAttack(int attackNumber)
        {
            int attackDamage = 0;
            string attackType = String.Empty;
            switch (attackNumber)
            {
                case 1:
                    {
                        int playerRandomAttackNumber = random.Next(0, PlayerList.Players[selectedPlayer].PlayerAttackList.Punch);
                        attackDamage = playerRandomAttackNumber;
                        attackType = "Punch";
                        DecreaseOpponentPower(playerRandomAttackNumber);

                        break;
                    }
                case 2:
                    {
                        int playerRandomAttackNumber = random.Next(0, PlayerList.Players[selectedPlayer].PlayerAttackList.Kick);
                        attackDamage = playerRandomAttackNumber;
                        attackType = "Kick";
                        DecreaseOpponentPower(playerRandomAttackNumber);
                        break;
                    }
                case 3:
                    {
                        int playerRandomAttackNumber = random.Next(0, PlayerList.Players[selectedPlayer].PlayerAttackList.Throw);
                        attackDamage = playerRandomAttackNumber;
                        attackType = "Throw";
                        DecreaseOpponentPower(playerRandomAttackNumber);
                        break;
                    }

            }

            AttackMessage($"Player Name: {PlayerList.Players[selectedPlayer].PlayerName} \t\t\t Attack Type: {attackType} \n Damage Dealt: {attackDamage}");
            
        }

        private void DecreaseOpponentPower(int amount)
        {
            OpponentList.Opponents[selectedOpponent].OpponentAttackList.Power -= amount;
        }

        private void DecreasePlayerPower(int amount)
        {
            PlayerList.Players[selectedPlayer].PlayerAttackList.Power -= amount;
        }

        private void AttackMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void OpponentAttack()
        {
            int attackRandomNumber = random.Next(0, OpponentMaxAttack);

            DecreasePlayerPower(attackRandomNumber);
            AttackMessage($"{OpponentList.Opponents[selectedOpponent].OpponentName} gave {attackRandomNumber} damage to the player");
        }
    }
}
