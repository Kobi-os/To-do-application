using System;
using System.Collections.Generic;

namespace Todoapplication
{
    internal class Program
    {
        public static List<Task> AllTasks = new List<Task>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Click 1. to Create Task");
            Console.WriteLine("Click 2. to Add Task");
            Console.WriteLine("Click 3. to Delete Task");
            Console.WriteLine("Click 4. to exit the program");
            List<string> tasks = new List<string>();
            char exitKey = Console.ReadKey().KeyChar;
            while (exitKey != '4')  { 
                switch(exitKey)
                {
                    case '1':
                        AddTask();
                        break;
                    case '2':
/*                        AddTask();*/
                        break;
                }
            }
        }

        public static void AddTask()
        {
            Console.WriteLine("The name of your task");
            string taskName = Console.ReadLine();
            Console.WriteLine("Description of your task");
            string taskDescription = Console.ReadLine();
        }

        public static void DeleteTask()
        {

        }

    }
}