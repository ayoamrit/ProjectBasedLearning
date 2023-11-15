using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook.Grade;

namespace GradeBook.School
{
    public class Student
    {
        //Properties to store student information
        private string? Name { get; set; }
        private int Id { get; set; }
        private Book? StudentBook { get; set; }

        //Constructor to init a new student object
        public Student(string Name, int Id, Book? StudentBook)
        {
            this.Name = Name;
            this.Id = Id;
            this.StudentBook = StudentBook;
        }

        //Override toString function 
        public override string ToString()
        {
            //Formatted string
            string str = $"Student Name: {Name}\n" +
                $"Student Id: {Id}\n" +
                $"Student Information Stored In The Book\n" +
                $"Student Average Score: {StudentBook.getScore()}\n" +
                $"Student Highest Score: {StudentBook.getHighestScore()}\n" +
                $"Student Average Attendance: {StudentBook.getAttendance()} \n" +
                $"Student Overall Performance: {StudentBook.getPerformance()}";

            return str;
        }
    }
}
