namespace StudentEnrollment;

public class Program
{
    static Student[] student = new Student[2];
    public static void Main(string[] args)
    {
        student[0] = new Student(1, "Jerry Seinfeld", 33, "Comedy");
        student[1] = new Student(2, "George Costanza", 35, "Art & Culture");

        foreach(Student stud in student)
        {
            Console.WriteLine(stud.ToString());
            Console.WriteLine("**********************");
        }
    }
}
