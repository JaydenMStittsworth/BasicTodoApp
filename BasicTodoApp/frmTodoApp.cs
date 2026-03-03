using System.Security.Cryptography.X509Certificates;

namespace BasicTodoApp
{
    public partial class frmTodoApp : Form
    {
        public List<TaskToDo> NewTask { get; set; }
        public frmTodoApp()
        {
            InitializeComponent();
            NewTask = new List<TaskToDo>();
        }

        public void AddTaskToDo(
            string num, 
            string due, 
            string task)
        {
            NewTask.Add(new TaskToDo
            {
                Task = task,
                Due = due,
                ListNumber = num
            });
        }

        public void AddTaskToDo(TaskToDo newtask)
        {
            NewTask.Add(newtask);
        }

        private void frmTodoApp_Load(object sender, EventArgs e)
        {

        }
    }
}
