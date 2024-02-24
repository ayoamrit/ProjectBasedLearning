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
        //Init object of random class
        private Random random = new Random();

        //Selected player and opponent properties
        private int selectedOpponent { get; set; }
        private int selectedPlayer { get; set; }

        //Constructor
        public ActionHandler(int selectedPlayer, int selectedOpponent)
        {
            //Set properties
            this.selectedPlayer = selectedPlayer;
            this.selectedOpponent = selectedOpponent;
        }

        /// <summary>
        /// This function executes player attack
        /// </summary>
        /// <param name="attackType">Type of attack the player want to execute</param>
        public void PlayerAttack(int attackType)
        {
            //Declare variables
            int attackDamage = 0;
            string attackTypeString = String.Empty;


            switch (attackType)
            {
                //Punch attack
                case 1:
                    {
                        //Generate a random number between 0 and the max punch power
                        int playerRandomAttackNumber = random.Next(0, PlayerList.Players[selectedPlayer].PlayerAttackList.Punch);

                        //Set variables
                        attackDamage = playerRandomAttackNumber;
                        attackTypeString = "Punch";

                        //Decrease health of the opponent equals to playerRandomAttackNumber
                        DecreaseOpponentPower(playerRandomAttackNumber);

                        //break
                        break;
                    }

                //Kick attack
                case 2:
                    {
                        //Generate a random number between 0 and the max kick power
                        int playerRandomAttackNumber = random.Next(0, PlayerList.Players[selectedPlayer].PlayerAttackList.Kick);
                        
                        //Set variables
                        attackDamage = playerRandomAttackNumber;
                        attackTypeString = "Kick";

                        //Decrease health of the opponent equals to playerRandomAttackNumber
                        DecreaseOpponentPower(playerRandomAttackNumber);

                        //break
                        break;
                    }

                //Throw attack
                case 3:
                    {
                        //Generate a random number between 0 and the max throw power
                        int playerRandomAttackNumber = random.Next(0, PlayerList.Players[selectedPlayer].PlayerAttackList.Throw);

                        //Set variables
                        attackDamage = playerRandomAttackNumber;
                        attackTypeString = "Throw";

                        //Decrease health of the opponent equals to playerRandomAttackNumber
                        DecreaseOpponentPower(playerRandomAttackNumber);

                        //break
                        break;
                    }

            }

            //Write message to show playerName, damageDealt, and attackType
            AttackMessage($"\nPlayer Name: {PlayerList.Players[selectedPlayer].PlayerName} \t\t\t Attack Type: {attackTypeString} \nDamage Dealt: {attackDamage}");
            
        }

        //Method to decrease the opponent's health
        private void DecreaseOpponentPower(int amount)
        {
            OpponentList.Opponents[selectedOpponent].OpponentAttackList.Power -= amount;
        }

        //method to decrease the player's health
        private void DecreasePlayerPower(int amount)
        {
            PlayerList.Players[selectedPlayer].PlayerAttackList.Power -= amount;
        }

        //Method to write attackMessage on the console
        private void AttackMessage(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// This method executes opponent's attack
        /// </summary>
        public void OpponentAttack()
        {
            //Generate a random number between 0 and the max attack power 
            int attackRandomNumber = random.Next(0, OpponentList.Opponents[selectedOpponent].OpponentAttackList.Attack);

            //Decrease the player's health equals to attackRandomNumber
            DecreasePlayerPower(attackRandomNumber);

            //Write message showing opponentName and damageDealt
            AttackMessage($"\nOpponent Name: {OpponentList.Opponents[selectedOpponent].OpponentName} \t\t\t Damage Dealt: {attackRandomNumber}");
        }

        //Method to check if health of both the player and the opponent is greater than 0
        public bool CheckHealth()
        {
            if (PlayerList.Players[selectedPlayer].PlayerAttackList.Power >= 0 || OpponentList.Opponents[selectedOpponent].OpponentAttackList.Power >= 0)
            {
                return true;
            }

            //if the health is 0 or less than 0, return false, means that either the player or the opponent has been defeated
            return false;
        }
    }
}
