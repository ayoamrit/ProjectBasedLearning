using ThePlayer.Action;
using ThePlayer.Opponent;
using ThePlayer.Player;

namespace ThePlayer
{
    //The sole purpose of creating this project is to understand OOP approach to programming in a better way.
    //Project overview
    /*
     * There are going to be different players and opponents that those players can fight against. Moreover, they will have 
     * same or different abilities and powers, depending on the selection.
     * The player would be able to perform basic action like hitting, kicking, and punching the opponent to defeat it.
     * The game will end when either the player or opponent has been defeated.
     */
    public class Program
    {
        //Declare a variable to store selected number of player and opponent
        private static int selectedPlayerNumber = 0;
        private static int selectedOpponentNumber = 0;

        private static ActionHandler? actionHandler;

        //Main function
        public static void Main(string[] args)
        {
            //Initialize player and opponent
            PlayerList.InitializePLayers();
            OpponentList.InitializeOpponents();

            //List each player from the list
            PlayerList.ListPlayers();
            selectedPlayerNumber = SelectionLoop("Select Player: ");  //get selected player
            selectedPlayerNumber--;
            DisplayMessage("You have selected player", PlayerList.Players[selectedPlayerNumber].PlayerName);
            
            //List each opponent from the list
            OpponentList.ListOpponents();
            selectedOpponentNumber = SelectionLoop("Select Opponent: ");  //get selected opponent
            selectedOpponentNumber--;
            DisplayMessage("You have selected opponent", OpponentList.Opponents[selectedOpponentNumber].OpponentName);


            //Init actionHandler object
            actionHandler = new ActionHandler(selectedPlayerNumber, selectedOpponentNumber);
            //Begin the game loop
            GameLoop();
            
        }

        //Function to display the selected player and opponent
        private static void DisplayMessage(string message, string name)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine($"\n{message}: {name}\n");
            Console.WriteLine("*************************************");
        }

        //Function to check if the selected player exist in the list or not 
        private static bool ValidateIndex(int selectedIndex, int min, int max)
        {
            if(selectedIndex > min && selectedIndex < max)
            {
                return true;
            }

            //return false if the number is in range outside the list
            return false;
        }


        //Function to loop through the selection process
        private static int SelectionLoop(string message)
        {
            while (true)
            {
                Console.Write(message);
                int selectedNumber = Convert.ToInt32(Console.ReadLine());

                if (ValidateIndex(selectedNumber, 0, 5))
                {
                    return selectedNumber;
                }
                else
                {
                    //Keep repeating the loop until the right selection has been made by the user 
                    Console.WriteLine("Your selection is not valid");
                }
            }
        }

        private static void GameLoop()
        {
            //Continuously loop the game until explicitly broken out of
            while (true)
            {
                //Display player and opponent information
                Console.WriteLine($"Player: {PlayerList.Players[selectedPlayerNumber].PlayerName} \t\t\t\t Opponent: {OpponentList.Opponents[selectedOpponentNumber].OpponentName}");
                Console.WriteLine($"Health: {PlayerList.Players[selectedPlayerNumber].PlayerAttackList.Power} \t\t\t\t\t Health: {OpponentList.Opponents[selectedOpponentNumber].OpponentAttackList.Power}");

                //Display attack options for the player
                Console.WriteLine("Choose your attack: \n1. Punch \n2. Kick \n3. Throw");
                Console.Write("Player choice: ");

                //Read the player's attack choice
                int attackChoiceNumber = Convert.ToInt32(Console.ReadLine());

                //Check if the choice of an attack is right 
                if(!ValidateIndex(attackChoiceNumber, 0, 4))
                {
                    //If the attack choice is not valid, continue the loop
                    continue;
                }

                //Perform player's attack based on the chosen option
                Console.WriteLine("*********Player Attack*********");
                actionHandler.PlayerAttack(attackChoiceNumber);
                Console.WriteLine("*******************************");

                //Check if the opponent's health is greater than 0
                if (!actionHandler.CheckHealth())
                {
                    Console.WriteLine("You have successfully defeated the opponent \n GAME OVER");
                    break;
                }

                //Perform opponent's attack
                Console.WriteLine("*********Opponent Attack*********");
                actionHandler.OpponentAttack();
                Console.WriteLine("*******************************");

                //Check if player's health is greater than 0
                if (!actionHandler.CheckHealth())
                {
                    Console.WriteLine("Your opponent have successfully defeated the player \n GAME OVER");
                }
            }
        }
    }
}