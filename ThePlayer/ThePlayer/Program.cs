using System.Reflection.Metadata.Ecma335;
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

        //Main function
        public static void Main(string[] args)
        {
            //Initialize player and opponent
            PlayerList.InitializePLayers();
            OpponentList.InitializeOpponents();

            //List each player from the list
            PlayerList.ListPlayers();
            selectedPlayerNumber = SelectionLoop("Select Player: ");  //get selected player
            DisplayMessage("You have selected player", PlayerList.Players[selectedPlayerNumber - 1].PlayerName);
            
            //List each opponent from the list
            OpponentList.ListOpponents();
            selectedOpponentNumber = SelectionLoop("Select Opponent: ");  //get selected opponent
            DisplayMessage("You have selected opponent", OpponentList.Opponents[selectedOpponentNumber - 1].OpponentName);
            
        }

        //Function to display the selected player and opponent
        private static void DisplayMessage(string message, string name)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine($"\n{message}: {name}\n");
            Console.WriteLine("*************************************");
        }

        //Function to check if the selected player exist in the list or not 
        private static bool ValidateIndex(int selectedIndex)
        {
            if(selectedIndex > 0 && selectedIndex < 5)
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

                if (ValidateIndex(selectedNumber))
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
    }
}