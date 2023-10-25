namespace StudentEnrollment;

public class Program
{
    //Declare an array of students to store student information
    static Student[] student = new Student[2];
    public static void Main(string[] args)
    {
        //Create a new student object and store it in the first element of the student array
        student[0] = new Student(1, "Jerry Seinfeld", 33, "Comedy");

        //Create a new student object and store it in the second element of the student array
        student[1] = new Student(2, "George Costanza", 35, "Art & Culture");

        //Iterate through the student array
        foreach(Student stud in student)
        {
            //Print the string representation of the current student object
            Console.WriteLine(stud.ToString());

            //Print a separator line to distinguish between students.
            Console.WriteLine("**********************");
        }
    }
}
