using System;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double CsiGrade { get; set; }
    public double GenEdGrade { get; set; }

    public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
    {
        FirstName = firstName;
        LastName = lastName;
        CsiGrade = csiGrade;
        GenEdGrade = genEdGrade;
    }

    public double StudentAverage()
    {
        return (CsiGrade + GenEdGrade) / 2;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - CSI Grade {CsiGrade} - GenEd Grade {GenEdGrade}";
    }
}