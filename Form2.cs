using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Myapp
{
    public partial class Form2 : Form
    {
        private List<TaskItem> _tasks = new();         // Stores all active (pending) tasks
        private List<TaskItem> _completedTasks = new(); // Stores completed tasks

        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTask.Text))
            {
                var newTask = new TaskItem(
                    textBoxTask.Text,
                    comboBoxPriority.SelectedItem?.ToString() ?? "Normal",
                    dateTimePickerDueDate.Value, // This includes both date and time
                    textBoxCategory.Text
                );

                _tasks.Add(newTask);
                UpdateTaskList();
                ShowReminderAlert();
                textBoxTask.Clear();
                textBoxCategory.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a task!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Pass the actual tasks list to Form4

            Form4 form4 = new Form4(_tasks, this);
            form4.Show();
            this.Hide(); // optional
        }









        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                _tasks.RemoveAt(listBoxTasks.SelectedIndex);
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Select a task to remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                TaskItem completedTask = _tasks[listBoxTasks.SelectedIndex];
                completedTask.IsCompleted = true;

                _tasks.RemoveAt(listBoxTasks.SelectedIndex);  // Remove from active task list
                _completedTasks.Add(completedTask);           // Move to completed task list

                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Select a task to mark as completed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonViewCompleted_Click(object sender, EventArgs e)
        {
            if (_completedTasks.Count == 0)
            {
                MessageBox.Show("No completed tasks available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form3 completedTasksForm = new Form3(_completedTasks, this);  // Pass reference of Form2
            completedTasksForm.Show();
        }

        private void UpdateTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in _tasks)
            {
                // Use "f" format specifier to display both date and time.
                var taskText = $"{task.Name} - {task.Priority} - {task.Deadline?.ToString("f")} - {task.Category}";
                if (task.Deadline.HasValue && task.Deadline.Value <= DateTime.Now.AddHours(24) && !task.IsCompleted)
                {
                    taskText += " [DUE SOON]";
                }
                listBoxTasks.Items.Add(taskText);
            }
        }

        // Function to restore a completed task back to pending list
        public void RestoreTask(TaskItem task)
        {
            task.IsCompleted = false;  // Mark task as pending again
            _completedTasks.Remove(task); // Remove from completed task list
            _tasks.Add(task);  // Add it back to the main task list
            UpdateTaskList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Configure the DateTimePicker for both date and time
            dateTimePickerDueDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDueDate.CustomFormat = "MM/dd/yyyy hh:mm tt"; // Format for both date and time
            dateTimePickerDueDate.ShowUpDown = false; // Ensure both date and time are shown

            UpdateTaskList();
            ShowReminderAlert();
        }

        private void ShowReminderAlert()
        {
            var urgentTasks = _tasks
                .Where(t => !t.IsCompleted && t.Deadline.HasValue && t.Deadline.Value <= DateTime.Now.AddHours(24))
                .ToList();

            if (urgentTasks.Any())
            {
                string message = "You have tasks due soon:\n" +
                                 string.Join("\n", urgentTasks.Select(t => $"- {t.Name} (Due: {t.Deadline?.ToString("f")})"));
                MessageBox.Show(message, "Task Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public record TaskItem(string Name, string Priority, DateTime? Deadline, string Category)
    {
        public bool IsCompleted { get; set; } = false;
    }
}
