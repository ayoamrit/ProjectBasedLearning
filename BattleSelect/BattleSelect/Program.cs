using BattleSelect.Player;
namespace BattleSelect;

class Program
{
    public static void Main(string[] args)
    {
        Character[] character = new Character[2];
        character[0] = new Soldier();
        character[1] = new Warrior();

        foreach(Character c in character)
        {
            if(c is Warrior)
            {
                Console.WriteLine("My name is warrior");
            }
            else
            {
                Console.WriteLine("Cool");
            }
        }
    }
}
