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
            DateTime due,
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
            #pragma warning disable CS8600
            TaskToDo selectedObj = (TaskToDo)lbTasks.SelectedItem;
            #pragma warning restore CS8600

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
            if (txtTask.Text == "" && txtDue.Text == "")
            {
                MessageBox.Show(
                "Both the Task Textbox and " +
                "the Due Date Textbox cannot be left empty.");
            }
            else if (txtTask.Text == "")
            {
                MessageBox.Show("The Task Textbox cannot be left empty.");
            }
            else if (txtDue.Text == "")
            {
                MessageBox.Show("The Due Date Textbox cannot be left empty.");
            }
            else
            {
                // capture the data
                // create a new task
                TaskToDo newTask = new TaskToDo
                {
                    Task = txtTask.Text,
                    Due = DateTime.Parse(txtDue.Text),
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
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTask.Text = "";
            txtDue.Text = "";
        }
    }
}
