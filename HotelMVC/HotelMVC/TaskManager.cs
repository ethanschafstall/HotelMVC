using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMVC
{
    public partial class TaskManager : Form
    {

        private int _taskID = 1;
        private Controller _controller;

        public Controller Controller { get => _controller; set => _controller = value; }

        public TaskManager()
        {
            InitializeComponent();
        }

        private void CreateTasks_Load(object sender, EventArgs e)
        {

        }

        private void CreateTask_Click(object sender, EventArgs e)
        {
            CreateTask.Visible = false;
            TaskNameInput.Visible = true;
            TaskNameLabel.Visible = true;
            TaskDescriptionLabel.Visible = true;
            TaskDescriptionInput.Visible = true;
            CreateNewTask.Visible = true;
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void TaskNameLabel_Click(object sender, EventArgs e)
        {

        }


        private void CreateNewTask_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Name = TaskNameInput.Text;
            task.Description = TaskDescriptionInput.Text;
            task.Id = this._taskID;
            _taskID++;
            _controller.CreateTask(task);
        }
        public void DisplaySuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ResetInputBoxes() 
        {
            TaskDescriptionInput.Text = "";
            TaskNameInput.Text = "";
        }

        private void TaskDescriptionInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
