using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.Grade;

public class Book
{
    //properties to store grade information
    private float Score { get; set; }
    private float HighestScore { get; set; }
    private float Attendance { get; set; }
    private string Performance { get; set; }

    //Constructor to init a new Book object
    public Book(float Score, float HighestScore, float Attendance, string Performance)
    {
        this.Score = Score;
        this.HighestScore = HighestScore;
        this.Attendance = Attendance;
        this.Performance = Performance;
    }

    //function to get the score
    public float getScore()
    {
        return this.Score;
    }

    //function to get the highest score
    public float getHighestScore()
    {
        return this.HighestScore;
    }

    //function to get the attendance
    public float getAttendance()
    {
        return this.Attendance;
    }

    //funciton to get the performance
    public string getPerformance()
    {
        return this.Performance;
    }
}
