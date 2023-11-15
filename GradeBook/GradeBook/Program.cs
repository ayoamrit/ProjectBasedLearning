using System.Xml.Serialization;
using GradeBook.Grade;
using GradeBook.School;

namespace GradeBook;

class Program
{
    //List to store student objects
    static List<Student> studentList = new List<Student>();

    //Arrays for names and performance levels
    private static string[] namesArray = { "Amrit", "Subaig", "Kudrett", "Rinku" };
    private static string[] performanceArray = { "Out Standing", "Very Good", "Awesome", "Nailed It" };

    //Random number generator
    static Random random = new Random();

    public static void Main(string[] args)
    {

        //Loop to create and add students to the list
        for(int x = 0; x < 4; x++)
        {
            //generate random values for student attributes
            string studentName = namesArray[x];
            int id = randomNumber();

            float score = floatRandomNumber(40, 100);
            float highestScore = floatRandomNumber(60, 100);
            float attendance = floatRandomNumber(50, 100);
            string performance = performanceArray[x];

            //Create a book object for each student
            Book studentBook = new Book(score, highestScore, attendance, performance);

            //Creating a student object and adding it to the list
            Student student = new Student(studentName, id, studentBook);
            studentList.Add(student);
        }

        //Display information for each student in the list
        foreach(Student student in studentList)
        {
            Console.WriteLine(student.ToString());
            Console.WriteLine();
        }

    }

    //Function to generate a random integer
    public static int randomNumber()
    {
        return random.Next(0, 2000);
    }

    //function to generate a random float with a specified range
    public static float floatRandomNumber(float min, float max)
    {
        return min + (float)(random.NextDouble() * (max - min));
    }
}