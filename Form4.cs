using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Myapp
{
    public partial class Form4 : Form
    {
        private List<TaskItem> _tasks;
        private Form _form2; // Declare _form2 as a private field of type Form  

        public Form4(List<TaskItem> tasks, Form form2) // Add Form form2 as a parameter to the constructor  
        {
            InitializeComponent();
            _tasks = tasks;
            _form2 = form2; // Assign the passed form2 to the _form2 field  
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBoxSortPriority.Items.AddRange(new string[] { "Low", "Normal", "High" });
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text.Trim();
            DateTime fromDate = dateTimePickerFrom.Value.Date;
            DateTime toDate = dateTimePickerTo.Value.Date;

            var filtered = _tasks.Where(task =>
                task.Deadline.HasValue &&
                task.Deadline.Value.Date >= DateTime.Today && // Skip expired tasks  
                task.Deadline.Value.Date >= fromDate &&
                task.Deadline.Value.Date <= toDate &&
                (string.IsNullOrEmpty(keyword) ||
                 task.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                 task.Category.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                 task.Priority.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            UpdateListBox(filtered);
        }

        private void ButtonSortPriority_Click(object sender, EventArgs e)
        {
            var priorityOrder = new Dictionary<string, int>
               {
                   { "High", 1 },
                   { "Normal", 2 },
                   { "Low", 3 }
               };

            var sorted = _tasks
                .Where(t => t.Deadline == null || t.Deadline.Value.Date >= DateTime.Today) // Exclude expired  
                .OrderBy(t => priorityOrder.ContainsKey(t.Priority) ? priorityOrder[t.Priority] : int.MaxValue)
                .ToList();

            UpdateListBox(sorted);
        }

        private void UpdateListBox(List<TaskItem> taskList)
        {
            listBoxResults.DataSource = null;
            listBoxResults.DataSource = taskList.Select(t =>
                $"{t.Name} | {t.Category} | {t.Priority} | {(t.Deadline.HasValue ? t.Deadline.Value.ToString("g") : "No Deadline")}"
            ).ToList();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            _form2.Show(); // Bring Form2 back  
            this.Close(); // Close Form4  
        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void labelToDate_Click(object sender, EventArgs e)
        {

        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }
    }
}