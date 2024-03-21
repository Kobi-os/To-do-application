using System;
using System.Collections.Generic;

namespace Todoapplication
{
    internal class Program
    {
        public static List<Task> AllTasks = new List<Task>();

        public static void Main(string[] args)
        {
            AddTask(1, "Posprzątać pokój", "poodkurzać");
            ShowAllTasks();
        }

        public static void AddTask(int id, string taskName, string taskDescription)
        {
            Console.WriteLine("The name of your task");
            taskName = Console.ReadLine();
            Console.WriteLine("Description of your task");
            taskDescription = Console.ReadLine();
            Task newTask = new Task(id, taskName, taskDescription);
            AllTasks.Add(newTask);
        }

        public static void ShowAllTasks()
        {
            foreach (var task in AllTasks)
            {
                Console.WriteLine($"Id {task.Id} Nazwa {task.TaskName} Opis {task.TaskDescription}");
            }
        }
    }
}