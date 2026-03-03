namespace BasicTodoApp
{
    partial class frmTodoApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbCreate = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            txtDue = new TextBox();
            lblDue = new Label();
            txtTask = new TextBox();
            lblTask = new Label();
            gbTodo = new GroupBox();
            lblClickTo = new Label();
            lbTasks = new ListBox();
            gbCreate.SuspendLayout();
            gbTodo.SuspendLayout();
            SuspendLayout();
            // 
            // gbCreate
            // 
            gbCreate.Anchor = AnchorStyles.Top;
            gbCreate.Controls.Add(btnClear);
            gbCreate.Controls.Add(btnAdd);
            gbCreate.Controls.Add(txtDue);
            gbCreate.Controls.Add(lblDue);
            gbCreate.Controls.Add(txtTask);
            gbCreate.Controls.Add(lblTask);
            gbCreate.Location = new Point(14, 12);
            gbCreate.Name = "gbCreate";
            gbCreate.Size = new Size(406, 148);
            gbCreate.TabIndex = 0;
            gbCreate.TabStop = false;
            gbCreate.Text = "Create Task";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(244, 103);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(325, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDue
            // 
            txtDue.Location = new Point(67, 62);
            txtDue.Name = "txtDue";
            txtDue.Size = new Size(333, 23);
            txtDue.TabIndex = 3;
            // 
            // lblDue
            // 
            lblDue.AutoSize = true;
            lblDue.Location = new Point(6, 65);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(55, 15);
            lblDue.TabIndex = 2;
            lblDue.Text = "Due Date";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(67, 22);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(333, 23);
            txtTask.TabIndex = 1;
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Location = new Point(31, 25);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(29, 15);
            lblTask.TabIndex = 0;
            lblTask.Text = "Task";
            // 
            // gbTodo
            // 
            gbTodo.Anchor = AnchorStyles.Bottom;
            gbTodo.Controls.Add(lblClickTo);
            gbTodo.Controls.Add(lbTasks);
            gbTodo.Location = new Point(14, 171);
            gbTodo.Name = "gbTodo";
            gbTodo.Size = new Size(406, 348);
            gbTodo.TabIndex = 1;
            gbTodo.TabStop = false;
            gbTodo.Text = "Tasks to do";
            // 
            // lblClickTo
            // 
            lblClickTo.AutoSize = true;
            lblClickTo.Location = new Point(141, 19);
            lblClickTo.Name = "lblClickTo";
            lblClickTo.Size = new Size(132, 15);
            lblClickTo.TabIndex = 1;
            lblClickTo.Text = "Click to Complete Tasks";
            // 
            // lbTasks
            // 
            lbTasks.FormattingEnabled = true;
            lbTasks.ItemHeight = 15;
            lbTasks.Location = new Point(6, 45);
            lbTasks.Name = "lbTasks";
            lbTasks.Size = new Size(394, 289);
            lbTasks.TabIndex = 0;
            lbTasks.Click += lbTasks_Click;
            // 
            // frmTodoApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 531);
            Controls.Add(gbTodo);
            Controls.Add(gbCreate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmTodoApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do List";
            Load += frmTodoApp_Load;
            gbCreate.ResumeLayout(false);
            gbCreate.PerformLayout();
            gbTodo.ResumeLayout(false);
            gbTodo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCreate;
        private TextBox txtDue;
        private Label lblDue;
        private TextBox txtTask;
        private Label lblTask;
        private GroupBox gbTodo;
        private Button btnClear;
        private Button btnAdd;
        private Label lblClickTo;
        private ListBox lbTasks;
    }
}
