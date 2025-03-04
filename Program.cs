using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== TO-DO LIST =====");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        Console.WriteLine("Exiting... Have a great day!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void ViewTasks()
        {
            Console.Clear();
            Console.WriteLine("===== Your Tasks =====");

            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void AddTask()
        {
            Console.Clear();
            Console.Write("Enter a new task: ");
            string task = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
                Console.WriteLine("Task added successfully!");
            }
            else
            {
                Console.WriteLine("Task cannot be empty!");
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void RemoveTask()
        {
            Console.Clear();
            Console.WriteLine("===== Remove a Task =====");
            ViewTasks();

            if (tasks.Count == 0)
                return;

            Console.Write("Enter task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number!");
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
