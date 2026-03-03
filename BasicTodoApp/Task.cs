using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTodoApp
{
    public class TaskToDo
    {
        // what describes a task
        public string Task { get; set; }
        public string Due { get; set; }

        // construct a new task
        public TaskToDo()
        {

        }
    }
}
