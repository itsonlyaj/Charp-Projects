using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ToDoList;

class Program
{
    static void Main(string[] args)
    {
        string input;
        string endInput = "end";
        string editList;
        string deleteTask;
        int deleteList;
        int editPrompt;
        int editIndex;
        string newTask;
        bool loop = true;
        bool _EditList;
        bool _DeleteList;

        List<string> tasks = new List<string>();

        Console.WriteLine("Enter your tasks in your list. (Once you entered everything in your list, type 'end' to continue.)");

        while (loop)
        {
            input = Console.ReadLine();
            tasks.Add(input);
            
            if (input == endInput)
            {
                tasks.Remove("end");
                break;
            }
            else
            {
                continue;
            }
        }

        Console.WriteLine("Here is your to do list: ");

        Console.WriteLine("--------------------------------");
        foreach (var t in tasks)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine("--------------------------------");

        Console.WriteLine("Would you like to edit your list?\n(Y for yes, or N for no.): ");

        editList = Console.ReadLine();

        if (editList == "y")
        {
            _EditList = true;

            while (_EditList)
            {
                Console.WriteLine("Would you like to add more to your list, or edit a specific task in your list?");
                Console.WriteLine("(Enter 1 to add more, or press 2 to edit a task, or 3 to move on)");
                editPrompt = Convert.ToInt32(Console.ReadLine());

                if (editPrompt == 1)
                {
                    Console.WriteLine("Enter your tasks in your list. (Once you entered everything in your list, type 'end' to continue.)");

                    while (true)
                    {
                        input = Console.ReadLine();

                        if (input == "end")
                        {
                            break;
                        }

                        tasks.Add(input);
                    }
                }

                else if (editPrompt == 2)
                {
                    Console.Write("At what index would like to edit: ");
                    editIndex = Convert.ToInt32(Console.ReadLine());

                    if (editIndex < 0 || editIndex >= tasks.Count)
                    {
                        Console.WriteLine("That index does not exist in your list.");
                        continue;
                    }

                    Console.Write("\nEnter the name of new task: ");
                    newTask = Console.ReadLine();

                    tasks[editIndex] = newTask;
                }
                else if (editPrompt == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid number!");
                }
            }
        }
        else if (editList == "n")
        {
            _EditList = false;
        }

        _DeleteList = true;

        while (_DeleteList)
        {
            Console.WriteLine("Would you like to delete a task in your list, or the entire list?");
            Console.WriteLine("(Press 1 to delete a task, 2 to clear the list, or 3 to continue.)");
            deleteList = Convert.ToInt32(Console.ReadLine());

            if (deleteList == 1)
            {
                Console.Write("Enter the name of the item you would like to delete: ");
                deleteTask = Console.ReadLine();

                if (tasks.Contains(deleteTask))
                {
                    Console.WriteLine("Item has been removed from your list!");
                    tasks.Remove(deleteTask);
                }
                else
                {
                    Console.WriteLine("Item does not exist in your list");
                }

                break;
            }
            else if (deleteList == 2)
            {
                tasks.Clear();

                Console.WriteLine("List has been removed!");

                break;
            }
            else if (deleteList == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Number is not valid!");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Here is your final list.");
        Console.WriteLine("--------------------------------");
        foreach (var t in tasks)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine("--------------------------------");
    }
}
