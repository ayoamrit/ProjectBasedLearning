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
        private static int selectedPlayerNumber = 0;
        private static int selectedOpponentNumber = 0;

        //Main function
        public static void Main(string[] args)
        {
            PlayerList.InitializePLayers();
            OpponentList.InitializeOpponents();

            PlayerList.ListPlayers();
            selectedPlayerNumber = SelectionLoop("Select Player: ");
            DisplayMessage("You have selected player", PlayerList.Players[selectedPlayerNumber - 1].PlayerName);
            

            OpponentList.ListOpponents();
            selectedOpponentNumber = SelectionLoop("Select Opponent: ");
            DisplayMessage("You have selected opponent", OpponentList.Opponents[selectedOpponentNumber - 1].OpponentName);
            
        }

        private static void DisplayMessage(string message, string name)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine($"\n{message}: {name}\n");
            Console.WriteLine("*************************************");
        }

        private static bool ValidateIndex(int selectedIndex)
        {
            if(selectedIndex > 0 && selectedIndex < 5)
            {
                return true;
            }

            return false;
        }

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
                    Console.WriteLine("Your selection is not valid");
                }
            }
        }
    }
}