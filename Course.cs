using System;
using System.Collections.Generic;

public class Course
{
    public string CourseName { get; set; }
    public string Teacher { get; set; }
    public List<Student> ClassRoster { get; } = new List<Student>();

    public Course(string courseName, string teacher)
    {
        CourseName = courseName;
        Teacher = teacher;
    }

    public void EnrollStudent(Student student)
    {
        ClassRoster.Add(student);
    }

    public double RosterAverage()
    {
        double sum = 0;
        foreach (var student in ClassRoster)
        {
            sum += student.StudentAverage();
        }
        return sum / ClassRoster.Count;
    }
}