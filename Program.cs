using System;
using System.Collections.Generic;

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
                Console.WriteLine("4. Edit Task");
                Console.WriteLine("5. Mark Task as Done");
                Console.WriteLine("6. Clear All Tasks");
                Console.WriteLine("7. Exit");
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
                        EditTask();
                        break;
                    case "5":
                        MarkTaskAsDone();
                        break;
                    case "6":
                        ClearAllTasks();
                        break;
                    case "7":
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
                tasks.Add("[ ] " + task);
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

        static void EditTask()
        {
            Console.Clear();
            Console.WriteLine("===== Edit a Task =====");
            ViewTasks();

            if (tasks.Count == 0)
                return;

            Console.Write("Enter task number to edit: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            {
                Console.Write("Enter the new task description: ");
                string newTask = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newTask))
                {
                    tasks[index - 1] = "[ ] " + newTask;
                    Console.WriteLine("Task updated successfully!");
                }
                else
                {
                    Console.WriteLine("Task cannot be empty!");
                }
            }
            else
            {
                Console.WriteLine("Invalid task number!");
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void MarkTaskAsDone()
        {
            Console.Clear();
            Console.WriteLine("===== Mark Task as Done =====");
            ViewTasks();

            if (tasks.Count == 0)
                return;

            Console.Write("Enter task number to mark as done: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            {
                if (!tasks[index - 1].StartsWith("[X]"))
                {
                    tasks[index - 1] = "[X] " + tasks[index - 1].Substring(4);
                    Console.WriteLine("Task marked as done!");
                }
                else
                {
                    Console.WriteLine("Task is already marked as done.");
                }
            }
            else
            {
                Console.WriteLine("Invalid task number!");
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void ClearAllTasks()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to delete all tasks? (yes/no)");
            string confirmation = Console.ReadLine()?.ToLower();

            if (confirmation == "yes")
            {
                tasks.Clear();
                Console.WriteLine("All tasks cleared!");
            }
            else
            {
                Console.WriteLine("Operation canceled.");
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
