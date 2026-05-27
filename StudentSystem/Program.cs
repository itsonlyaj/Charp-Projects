using System.Collections.Generic;

namespace StudentSystem;

class Program
{
    static List<Student> students = new List<Student>();

    static void Main(string[] args)
    {
        string input;
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Create a student");
            Console.WriteLine("2. Display students.");
            Console.WriteLine("3. Convert GPA to grade letter.");
            Console.WriteLine("4. Edit Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateStudent();
                    break;
                case "2":
                    DisplayStudent();
                    break;
                case "3":
                    ConvertGPA();
                    break;
                case "4":
                    EditStudent();
                    break;
                case "5":
                    DeleteStudent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input, try again!");
                    break;
            }
        }
    }

    static void CreateStudent()
    {
        Console.Write("Enter the students name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the students age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("What grade is the student in: ");
        string gradeYear = Console.ReadLine();

        Console.Write("Enter the students gpa: ");
        double gpa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the students phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Enter the students address: ");
        string address = Console.ReadLine();

        Student student = new Student(name, age, gradeYear, gpa, phoneNumber, address);
        students.Add(student);
        
        Console.WriteLine();
    }

    static void DisplayStudent()
    {
        Console.Write("=============================");
        foreach (var s in students)
        {
            s.PrintStudent();
        }
        Console.Write("=============================");
        Console.WriteLine();
    }

    static void ConvertGPA()
    {
        bool convertRunning = true;
        string nameInput;
        string name;

        while (convertRunning)
        {
            Console.Write("\nEnter the students name: ");
            nameInput = Console.ReadLine();

            foreach(var findStudent in students)
            {
                name = findStudent.Name;

                if (nameInput == name)
                {
                    findStudent.GPAToLetterGrade();
                    convertRunning = false;
                    break;
                }

                if (nameInput != name)
                {
                    Console.WriteLine($"{nameInput} does not exist in this list!");
                    break;
                }
            }   
        }  
    }

    static void EditStudent()
    {
        
    }

    static void DeleteStudent()
    {
        
    }
}
