using System;
using System.Collections.Generic;

namespace Todoapplication
{
    internal class Program
    {
        public static List<string> tasks = new List<string>();


        public static void Main(string[] args)
        {
            Console.WriteLine("Click 1. to Add Task");
            Console.WriteLine("Click 2. to Delete Task");
            Console.WriteLine("Click 3. to Show Tasks");
            Console.WriteLine("Click 4. to exit the program");
            char exitKey = Console.ReadKey().KeyChar;
            while (exitKey != '4')  { 
                switch(exitKey)
                {
                    case '1':
                        AddTask();
                        break;
                    case '2':
                        ShowTasks();
                     
                        break;
                    case '3':
/*                        ShowTasks();*/
                        break;
                }
            }
        }

        public static void AddTask()
        {
            Console.WriteLine("The name of your task");
            string taskName = Console.ReadLine();
            tasks.Add(taskName);
        }

        public static void DeleteTask()
        {

        }

        public static void ShowTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Your tasks are {task}");
            }
        }
    }
}