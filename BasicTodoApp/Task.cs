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
        public DateTime Due { get; set; }
        public string ListNumber { get; set; }
        public bool IsCompleted { get; set; } = false;

        // construct a new task
        #pragma warning disable CS8618
        public TaskToDo()
        #pragma warning restore CS8618
        {
        }

        // print new contact
        public override string ToString()
        {
            return $"{ListNumber} - {Due.ToShortDateString()} - {Task}";
        }
    }
}
