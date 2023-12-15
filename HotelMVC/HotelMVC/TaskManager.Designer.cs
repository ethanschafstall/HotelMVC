namespace HotelMVC
{
    partial class TaskManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateTask = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.TaskNameInput = new System.Windows.Forms.TextBox();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.TaskDescriptionLabel = new System.Windows.Forms.Label();
            this.CreateNewTask = new System.Windows.Forms.Button();
            this.TaskDescriptionInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CreateTask
            // 
            this.CreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTask.Location = new System.Drawing.Point(51, 88);
            this.CreateTask.Name = "CreateTask";
            this.CreateTask.Size = new System.Drawing.Size(397, 66);
            this.CreateTask.TabIndex = 1;
            this.CreateTask.Text = "Create Task";
            this.CreateTask.UseVisualStyleBackColor = true;
            this.CreateTask.Click += new System.EventHandler(this.CreateTask_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(125, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(284, 47);
            this.Title.TabIndex = 2;
            this.Title.Text = "Task Manager";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // TaskNameInput
            // 
            this.TaskNameInput.Location = new System.Drawing.Point(141, 196);
            this.TaskNameInput.Name = "TaskNameInput";
            this.TaskNameInput.Size = new System.Drawing.Size(268, 20);
            this.TaskNameInput.TabIndex = 3;
            this.TaskNameInput.Visible = false;
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(12, 199);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(68, 13);
            this.TaskNameLabel.TabIndex = 4;
            this.TaskNameLabel.Text = "Task Name :";
            this.TaskNameLabel.Visible = false;
            this.TaskNameLabel.Click += new System.EventHandler(this.TaskNameLabel_Click);
            // 
            // TaskDescriptionLabel
            // 
            this.TaskDescriptionLabel.AutoSize = true;
            this.TaskDescriptionLabel.Location = new System.Drawing.Point(12, 233);
            this.TaskDescriptionLabel.Name = "TaskDescriptionLabel";
            this.TaskDescriptionLabel.Size = new System.Drawing.Size(96, 13);
            this.TaskDescriptionLabel.TabIndex = 5;
            this.TaskDescriptionLabel.Text = "Task Description : ";
            this.TaskDescriptionLabel.Visible = false;
            // 
            // CreateNewTask
            // 
            this.CreateNewTask.Location = new System.Drawing.Point(12, 490);
            this.CreateNewTask.Name = "CreateNewTask";
            this.CreateNewTask.Size = new System.Drawing.Size(162, 23);
            this.CreateNewTask.TabIndex = 7;
            this.CreateNewTask.Text = "Create New Task";
            this.CreateNewTask.UseVisualStyleBackColor = true;
            this.CreateNewTask.Visible = false;
            this.CreateNewTask.Click += new System.EventHandler(this.CreateNewTask_Click);
            // 
            // TaskDescriptionInput
            // 
            this.TaskDescriptionInput.Location = new System.Drawing.Point(141, 256);
            this.TaskDescriptionInput.Name = "TaskDescriptionInput";
            this.TaskDescriptionInput.Size = new System.Drawing.Size(268, 197);
            this.TaskDescriptionInput.TabIndex = 6;
            this.TaskDescriptionInput.Text = "";
            this.TaskDescriptionInput.Visible = false;
            this.TaskDescriptionInput.TextChanged += new System.EventHandler(this.TaskDescriptionInput_TextChanged);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 550);
            this.Controls.Add(this.CreateNewTask);
            this.Controls.Add(this.TaskDescriptionInput);
            this.Controls.Add(this.TaskDescriptionLabel);
            this.Controls.Add(this.TaskNameLabel);
            this.Controls.Add(this.TaskNameInput);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CreateTask);
            this.Name = "TaskManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateTasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateTask;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TaskNameInput;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.Label TaskDescriptionLabel;
        private System.Windows.Forms.Button CreateNewTask;
        private System.Windows.Forms.RichTextBox TaskDescriptionInput;
    }
}

