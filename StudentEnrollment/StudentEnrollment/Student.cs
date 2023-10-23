using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollment
{
    internal class Student
    {
        public int studentNumber { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string school { get; set; }

        public Student(int studentNumber, string name, int age, string school)
        {
            this.studentNumber = studentNumber;
            this.name = name;
            this.age = age;
            this.school = school;
        }

        public override string ToString()
        {
            return $" Student Number: {studentNumber}\n Student Name: {name}\n Student Age: {age}\n School: {school}";
        }
    }
}
