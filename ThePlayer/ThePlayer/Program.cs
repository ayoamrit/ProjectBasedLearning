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
        //Main function
        public static void Main(string[] args)
        {
            PlayerList.InitializePLayers();
            OpponentList.InitializeOpponents();

            PlayerList.ListPlayer();
        }
    }
}