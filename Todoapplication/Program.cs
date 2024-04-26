using System;
using System.Collections.Generic;

namespace Todoapplication
{
    internal class Program
    {
        public static List<string> tasks = new List<string>();


        public static void Main(string[] args)
        {
            char exitKey;

            do
            {
                Console.WriteLine("Click 1. to Add Task");
                Console.WriteLine("Click 2. to Delete Task");
                Console.WriteLine("Click 3. to Show Tasks");
                Console.WriteLine("Click 4. to exit the program");

                exitKey = Console.ReadKey().KeyChar;

                switch (exitKey)
                {
                    case '1':
                        AddTask();
                        break;
                    case '2':
                        DeleteTask();
                        break;
                    case '3':
                        ShowTasks();
                        break;
                }
            } while (exitKey != '4');
        }

        public static void AddTask()
        {
            Console.WriteLine("\n The name of your task");
            string taskName = Console.ReadLine();
            tasks.Add(taskName);
        }

        public static void DeleteTask()
        {
            Console.WriteLine("Which task you want to delete? To delete a task write it's name");
            string deletedTaskName = Console.ReadLine();

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] == deletedTaskName)
                {
                    tasks.RemoveAt(i);
                    Console.WriteLine($"Task '{deletedTaskName}' has been deleted.");
                    return;
                }
            }
        }

        public static void ShowTasks()
        {
            Console.WriteLine($"\nYour Current tasks are:\n");
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task}\n");
            }
        }
    }
}