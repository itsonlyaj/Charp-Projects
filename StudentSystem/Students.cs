using System.ComponentModel.DataAnnotations;

namespace StudentSystem;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string GradeYear { get; set; }
    public double Gpa { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    /// <summary>
    /// Creates an insatnce of the student class.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <param name="gradeYear"></param>
    /// <param name="gpa"></param>
    /// <param name="phoneNumber"></param>
    /// <param name="address"></param>

    public Student(string name, int age, string gradeYear, double gpa, string phoneNumber, string address)
    {
        Name = name;
        Age = age;
        GradeYear = gradeYear;
        Gpa = gpa;
        PhoneNumber = phoneNumber;
        Address = address;
    }

    public void PrintStudent()
    {
        Console.WriteLine();
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade: {GradeYear}");
        Console.WriteLine($"GPA: {Gpa}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine("----------------------------");
    }

    public void GPAToLetterGrade()
    {
        if (Gpa >= 4.3)
        {
            Console.WriteLine($"{Name} grade is a A+");
        }
        else if (Gpa >= 4.0)
        {
           Console.WriteLine($"{Name} grade is a A"); 
        }
        else if (Gpa >= 3.7)
        {
           Console.WriteLine($"{Name} grade is a A-"); 
        }
        else if (Gpa >= 3.3)
        {
           Console.WriteLine($"{Name} grade is a B+"); 
        }
        else if (Gpa >= 3.0)
        {
           Console.WriteLine($"{Name} grade is a B"); 
        }
        else if (Gpa >= 2.7)
        {
           Console.WriteLine($"{Name} grade is a B-"); 
        }
        else if (Gpa >= 2.3)
        {
           Console.WriteLine($"{Name} grade is a C+"); 
        }
        else if (Gpa >= 2.0)
        {
           Console.WriteLine($"{Name} grade is a C"); 
        }
        else if (Gpa >= 1.7)
        {
           Console.WriteLine($"{Name} grade is a C-"); 
        }
        else if (Gpa >= 1.3)
        {
           Console.WriteLine($"{Name} grade is a D+"); 
        }
        else if (Gpa >= 1.0)
        {
           Console.WriteLine($"{Name} grade is a D"); 
        }
        else if (Gpa >= 0.7)
        {
           Console.WriteLine($"{Name} grade is a D-"); 
        }
        else
        {
            Console.WriteLine($"{Name} grade is a F");
        }
    }
}