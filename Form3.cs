using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Myapp  // Ensure the namespace matches your project
{
    public partial class Form3 : Form
    {
        private List<TaskItem> _completedTasks;
        private Form2 _parentForm;  // Reference to Form2

        public Form3(List<TaskItem> completedTasks, Form2 parentForm)
        {
            InitializeComponent();
            _completedTasks = completedTasks;
            _parentForm = parentForm;
            LoadCompletedTasks();
        }

        private void LoadCompletedTasks()
        {
            listBoxCompletedTasks.Items.Clear();
            foreach (var task in _completedTasks)
            {
                listBoxCompletedTasks.Items.Add($"{task.Name} - {task.Deadline?.ToString("dd/MM/yyyy")} - {task.Category}");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            if (listBoxCompletedTasks.SelectedIndex != -1)
            {
                // Retrieve selected task
                TaskItem restoredTask = _completedTasks[listBoxCompletedTasks.SelectedIndex];
                restoredTask.IsCompleted = false;  // Mark task as pending

                // Remove from completed list and send it back to Form2
                _completedTasks.RemoveAt(listBoxCompletedTasks.SelectedIndex);
                _parentForm.RestoreTask(restoredTask);

                LoadCompletedTasks();  // Refresh completed tasks list
            }
            else
            {
                MessageBox.Show("Please select a task to restore!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxCompletedTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This event can be used if additional behavior is needed upon selection
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
