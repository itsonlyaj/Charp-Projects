using System.Collections.Generic;

namespace StudentSystem;

class Program
{
    static List<Student> students = new List<Student>();    // Creates a list from the student class.

    
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

    /// <summary>
    /// Method that will ask the user to create a student 
    /// </summary>
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

        /*
        After all information about the student has been entered, the program will create an object from the student class
        and store all of the information the user entered into that object and create a new list based off the information
        that the user entered.
        */
        Student student = new Student(name, age, gradeYear, gpa, phoneNumber, address);
        students.Add(student);
        
        Console.WriteLine();
    }

    /// <summary>
    /// Method that will display the students information.
    /// </summary>
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

    /// <summary>
    /// Will convert the students information if their name exists in the list.
    /// </summary>
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

    /// <summary>
    /// Will edit the students information in the list.
    /// </summary>
    static void EditStudent()
    {
       bool edit = true;
       string nameInput;
       bool found = false;

       while (edit)
        {
            Console.Write("Enter the name of the student you would like to edit: ");
            nameInput = Console.ReadLine();

            // Loops through to see if the student exists in the list.
            foreach (var editStudent in students)
            {
                if (editStudent.Name == nameInput)
                {
                    found = true;

                    Console.Write("Enter the new name of the student: ");
                    string newName = Console.ReadLine();

                    Console.Write("Enter the new age of the student: ");
                    int newAge = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the new student's grade year: ");
                    string newGradeYear = Console.ReadLine();

                    Console.Write("Enter the new student's GPA: ");
                    double newGpa = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the new student's phone number: ");
                    string newPhoneNumber = Console.ReadLine();

                    Console.Write("Enter the new student's address: ");
                    string newAddress = Console.ReadLine();

                    /*
                    Once the student has been found, and all information has been entered. It will override all of the
                    previous information with the new information that the user entered.
                    */
                    editStudent.Name = newName;
                    editStudent.Age = newAge;
                    editStudent.GradeYear = newGradeYear;
                    editStudent.Gpa = newGpa;
                    editStudent.PhoneNumber = newPhoneNumber;
                    editStudent.Address = newAddress;

                    Console.WriteLine("Student has been updated.");
                    break;
                }
            }

            if (!found)
            {
                found = false;  // Will return false if a certain name doesn't exist in the list.
                Console.WriteLine($"{nameInput} does not exists in the list!");
            }

            edit = false;
        }      
    }

    /// <summary>
    /// Deletes the student.
    /// </summary>
    static void DeleteStudent()
    {
        bool delete = true;
        string nameInput;
        bool found = false;

        while (delete)
        {
            Console.Write("Enter the name of the student you would like to delete: ");
            nameInput = Console.ReadLine();

            // Loops through to find the student in the list.
            foreach (var deleteStudent in students)
            {
                if (deleteStudent.Name == nameInput)
                {
                    found = true;

                    students.Remove(deleteStudent); // If the student is found, they will be deleted from the list.

                    Console.WriteLine("Student has been deleted!");
                    
                    break;
                }
            }

            if (!found)
            {
                found = false;

                Console.WriteLine("Student does not exist!");
            }

            delete = false;
        }
    }
}
