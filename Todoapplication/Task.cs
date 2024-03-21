using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todoapplication
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public Task(int id, string taskName, string taskDescription)
        {
            Id = id;
            TaskName = taskName;
            TaskDescription = taskDescription;
        }
    }
}
