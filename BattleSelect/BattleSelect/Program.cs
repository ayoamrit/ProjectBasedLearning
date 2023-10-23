using BattleSelect.Player;
using System.Reflection.Metadata;

namespace BattleSelect;

class Program
{
    static int playerRemainingHealth;
    static int opponentRemainingHealth;
    static bool isDead = false;

    static Random random = new Random();
    static Soldier soldier = new Soldier();
    static Warrior warrior = new Warrior();

    public static void Main(string[] args)
    {
        //Initialize player and opponent health
        setHealth();

        while (!isDead)
        {
            //print player and opponent health
            printHealth();

            try
            {
                //Get the user's action choice (punch or kick)
                int userChoice = getAction();

                if (userChoice == 1)
                {
                    //player chose to punch
                    int punchDamage = soldier.getPunch();
                    opponentRemainingHealth -= punchDamage;
                    Console.WriteLine("Soldier Punched: Damage Dealt - " + punchDamage);
                }
                else
                {
                    //player chose to kick
                    int kickDamage = soldier.getKick();
                    opponentRemainingHealth -= kickDamage;
                    Console.WriteLine("Soldier Kicked: Damage Dealt - " + kickDamage);
                }

                // Check if the game is over (one of the participants' health is depleted)
                checkHealth();
                if (isDead)
                {
                    break;
                }

                //Get the opponent's action choice (punch or kick)
                int opponentAction = getOpponentAction();
                if (opponentAction == 1)
                {
                    //opponent chose to punch
                    int punchDamage = warrior.getPunch();
                    playerRemainingHealth -= punchDamage;
                    Console.WriteLine("Warrior Punched: Damage Dealt - " + punchDamage);
                }
                else
                {
                    //opponent chose to kick
                    int kickDamage = warrior.getKick();
                    playerRemainingHealth -= kickDamage;
                    Console.WriteLine("Warrior Kicked: Damage Dealt - " + kickDamage);
                }

                checkHealth();

                Console.WriteLine();  //Leave a line for better formatting
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Select A Valid Option");
            }
            catch(FormatException){
                Console.WriteLine("Enter A Valid Input");
            }
        }
    }

    private static void setHealth()
    {
        //Initialize player and opponent health based on their starting health values
        playerRemainingHealth = soldier.getHealth;
        opponentRemainingHealth = warrior.getHealth;
    }

    private static void printHealth()
    {
        //Display the current health of the player and opponent
        Console.WriteLine("Soldier Health (Player): " + playerRemainingHealth + "\t\t Warrior Health (Computer): "+opponentRemainingHealth);

    }

    private static int getAction()
    {
        int userChoice;
        Console.WriteLine("Select an action: \n" +
            "1. Punch\n" +
            "2. Kick");
        Console.Write("Your Choice: ");
        try
        {
            //Get the validate the user's action choice 
            userChoice = Convert.ToInt32(Console.ReadLine());
            
            if(userChoice >= 1 && userChoice <= 2)
            {
                return userChoice;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        catch (FormatException)
        {
            //Handle invalid input format
            throw new FormatException();
        }
    }

    private static int getOpponentAction()
    {
        //Generate a random number action choice for the opponent 
        return random.Next(1, 3);
    }

    private static void checkHealth()
    {
        //check if the game is over (one of the characters' health is depleted
        if(playerRemainingHealth <= 0)
        {
            Console.WriteLine("Warrior (Computer) Killed Soldier (Player)");
            isDead = true;
        }
        else if(opponentRemainingHealth <= 0)
        {
            Console.WriteLine("Soldier (Player) Killed Warrior (Computer)");
            isDead = true;
        }
    }
}
