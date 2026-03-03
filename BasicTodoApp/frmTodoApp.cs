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

        public void UpdateTaskListBox()
        {
            // refreshes the list box with the newest contacts
            lbTasks.Items.Clear();
            foreach (TaskToDo newtask in NewTask)
            {
                lbTasks.Items.Add(newtask);
            }
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

        private void frmTodoApp_Load(object sender, EventArgs e)
        {
        }

        private void lbTasks_Click(object sender, EventArgs e)
        {
            TaskToDo selectedObj = (TaskToDo) lbTasks.SelectedItem;
            
            // creates messagebox upon click
            // removes item from list upon click
            // refreshes task list box
            if (selectedObj != null)
            {
                MessageBox.Show($"TASK COMPLETE - {selectedObj.Task}");
                NewTask.Remove(selectedObj);
                UpdateTaskListBox();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // capture the data
            // create a new task
            TaskToDo newTask = new TaskToDo
            {
                Task = txtTask.Text,
                Due = txtDue.Text,
                ListNumber = "#"
            };

            // add it to the list
            NewTask.Add(newTask);

            // pull the lever to update
            UpdateTaskListBox();

            // clear text boxes
            txtTask.Text = "";
            txtDue.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTask.Text = "";
            txtDue.Text = "";
        }
    }
}
