using PeopleDictionary;
using PeopleDictionary.Interface;
using PeopleDictionary.Person;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, IUser> activeUser = new Dictionary<int, IUser>();

        activeUser.Add(1, new User("Amrit", "Amrit@gmail.com", null));
        activeUser.Add(2, new AdminUser("BestUser", "BestUser@gmail.com", new List<string> {"Root", "Authorities", "Security"}));

        Console.Write("Enter 1 to change your email: ");

        if(int.TryParse(Console.ReadLine(), out int command))
        {
            Console.WriteLine();  //leaving a line for better formatting

            Console.Write("Enter your employee number: ");
            int employeeNumber = Convert.ToInt32(Console.ReadLine());

            if(command == 1)
            {
                Console.WriteLine(); //leaving a line for better formatting
                Console.WriteLine($"Welcome {activeUser[employeeNumber].Name}: Your current Email is {activeUser[employeeNumber].Email}");
                Console.Write("Enter your new email: ");
                string updatedEmail = Console.ReadLine();

                activeUser[employeeNumber].Email = updatedEmail;

                Console.WriteLine($"Name: {activeUser[employeeNumber].Name}, and your email is {activeUser[employeeNumber].Email}");
            }
        }
    }
}