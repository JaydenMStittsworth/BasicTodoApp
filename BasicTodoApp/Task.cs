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
        public string ListNumber { get; set; }
        public bool IsCompleted { get; set; } = false;

        // construct a new task
        public TaskToDo()
        {
        }

        // print new contact
        public override string ToString()
        {
            return $"{ListNumber} - {Due} - {Task}";
        }
    }
}
