namespace Myapp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonViewCompleted;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBoxFilterPriority;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilterDueDate;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonSearch;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBoxTask = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonComplete = new Button();
            buttonViewCompleted = new Button();
            listBoxTasks = new ListBox();
            comboBoxPriority = new ComboBox();
            textBoxCategory = new TextBox();
            dateTimePickerDueDate = new DateTimePicker();
            buttonSort = new Button();
            comboBoxFilterPriority = new ComboBox();
            dateTimePickerFilterDueDate = new DateTimePicker();
            buttonFilter = new Button();
            buttonSearch = new Button();
            panelSideDecoration = new Panel();
            pictureBoxLogo = new PictureBox();
            panel1 = new Panel();
            panelSideDecoration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = Color.LightSkyBlue;
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Font = new Font("Segoe UI", 10F);
            textBoxTask.Location = new Point(206, 16);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.PlaceholderText = "Enter task description...";
            textBoxTask.Size = new Size(369, 27);
            textBoxTask.TabIndex = 0;
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.RoyalBlue;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(616, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(193, 39);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add Task";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.RoyalBlue;
            buttonRemove.Cursor = Cursors.Hand;
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(616, 68);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(193, 34);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Remove Task";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonComplete
            // 
            buttonComplete.BackColor = Color.RoyalBlue;
            buttonComplete.Cursor = Cursors.Hand;
            buttonComplete.FlatAppearance.BorderSize = 0;
            buttonComplete.FlatStyle = FlatStyle.Flat;
            buttonComplete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonComplete.ForeColor = Color.White;
            buttonComplete.Location = new Point(616, 122);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(193, 36);
            buttonComplete.TabIndex = 3;
            buttonComplete.Text = "Complete Task";
            buttonComplete.UseVisualStyleBackColor = false;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // buttonViewCompleted
            // 
            buttonViewCompleted.BackColor = Color.RoyalBlue;
            buttonViewCompleted.Cursor = Cursors.Hand;
            buttonViewCompleted.FlatAppearance.BorderSize = 0;
            buttonViewCompleted.FlatStyle = FlatStyle.Flat;
            buttonViewCompleted.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonViewCompleted.ForeColor = Color.White;
            buttonViewCompleted.Location = new Point(616, 182);
            buttonViewCompleted.Name = "buttonViewCompleted";
            buttonViewCompleted.Size = new Size(193, 37);
            buttonViewCompleted.TabIndex = 8;
            buttonViewCompleted.Text = "View Completed";
            buttonViewCompleted.UseVisualStyleBackColor = false;
            buttonViewCompleted.Click += buttonViewCompleted_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.BackColor = Color.AliceBlue;
            listBoxTasks.BorderStyle = BorderStyle.None;
            listBoxTasks.Font = new Font("Segoe UI", 10F);
            listBoxTasks.ForeColor = Color.RoyalBlue;
            listBoxTasks.ItemHeight = 28;
            listBoxTasks.Location = new Point(206, 299);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(763, 280);
            listBoxTasks.TabIndex = 4;
            listBoxTasks.SelectedIndexChanged += listBoxTasks_SelectedIndexChanged;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.BackColor = Color.LightSkyBlue;
            comboBoxPriority.FlatStyle = FlatStyle.Flat;
            comboBoxPriority.Font = new Font("Segoe UI", 10F);
            comboBoxPriority.Items.AddRange(new object[] { "Low", "Normal", "High" });
            comboBoxPriority.Location = new Point(206, 66);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(369, 36);
            comboBoxPriority.TabIndex = 5;
            // 
            // textBoxCategory
            // 
            textBoxCategory.BackColor = Color.LightSkyBlue;
            textBoxCategory.BorderStyle = BorderStyle.None;
            textBoxCategory.Font = new Font("Segoe UI", 10F);
            textBoxCategory.Location = new Point(206, 125);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.PlaceholderText = "Enter category...";
            textBoxCategory.Size = new Size(369, 27);
            textBoxCategory.TabIndex = 6;
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.CalendarForeColor = Color.RoyalBlue;
            dateTimePickerDueDate.CalendarMonthBackground = Color.LightSkyBlue;
            dateTimePickerDueDate.CalendarTitleBackColor = Color.RoyalBlue;
            dateTimePickerDueDate.CalendarTitleForeColor = Color.LightSkyBlue;
            dateTimePickerDueDate.Font = new Font("Segoe UI", 10F);
            dateTimePickerDueDate.Location = new Point(206, 185);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(369, 34);
            dateTimePickerDueDate.TabIndex = 7;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(0, 0);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(75, 23);
            buttonSort.TabIndex = 0;
            buttonSort.Visible = false;
            // 
            // comboBoxFilterPriority
            // 
            comboBoxFilterPriority.Location = new Point(0, 0);
            comboBoxFilterPriority.Name = "comboBoxFilterPriority";
            comboBoxFilterPriority.Size = new Size(121, 33);
            comboBoxFilterPriority.TabIndex = 0;
            comboBoxFilterPriority.Visible = false;
            // 
            // dateTimePickerFilterDueDate
            // 
            dateTimePickerFilterDueDate.Location = new Point(0, 0);
            dateTimePickerFilterDueDate.Name = "dateTimePickerFilterDueDate";
            dateTimePickerFilterDueDate.Size = new Size(200, 31);
            dateTimePickerFilterDueDate.TabIndex = 0;
            dateTimePickerFilterDueDate.Visible = false;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(0, 0);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(75, 23);
            buttonFilter.TabIndex = 0;
            buttonFilter.Visible = false;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.RoyalBlue;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(616, 236);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(193, 37);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Search Task";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // panelSideDecoration
            // 
            panelSideDecoration.BackColor = Color.FromArgb(25, 60, 140);
            panelSideDecoration.BackgroundImage = (Image)resources.GetObject("panelSideDecoration.BackgroundImage");
            panelSideDecoration.BackgroundImageLayout = ImageLayout.Stretch;
            panelSideDecoration.Controls.Add(panel1);
            panelSideDecoration.Dock = DockStyle.Left;
            panelSideDecoration.Location = new Point(0, 0);
            panelSideDecoration.Margin = new Padding(4);
            panelSideDecoration.Name = "panelSideDecoration";
            panelSideDecoration.Size = new Size(184, 619);
            panelSideDecoration.TabIndex = 10;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.ErrorImage = (Image)resources.GetObject("pictureBoxLogo.ErrorImage");
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.InitialImage = (Image)resources.GetObject("pictureBoxLogo.InitialImage");
            pictureBoxLogo.Location = new Point(915, 12);
            pictureBoxLogo.Margin = new Padding(4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(105, 103);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 11;
            pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 60, 140);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 619);
            panel1.TabIndex = 11;
            // 
            // Form2
            // 
            AcceptButton = buttonComplete;
            BackColor = Color.White;
            ClientSize = new Size(1066, 619);
            Controls.Add(pictureBoxLogo);
            Controls.Add(panelSideDecoration);
            Controls.Add(textBoxTask);
            Controls.Add(buttonAdd);
            Controls.Add(buttonRemove);
            Controls.Add(buttonComplete);
            Controls.Add(buttonViewCompleted);
            Controls.Add(buttonSearch);
            Controls.Add(listBoxTasks);
            Controls.Add(comboBoxPriority);
            Controls.Add(textBoxCategory);
            Controls.Add(dateTimePickerDueDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Task Manager";
            Load += Form2_Load;
            panelSideDecoration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Method to apply rounded corners to controls
        private void ApplyRoundedCorners()
        {
            // Apply rounded corners to buttons
            ApplyRoundCornerToButton(buttonAdd, 10);
            ApplyRoundCornerToButton(buttonRemove, 10);
            ApplyRoundCornerToButton(buttonComplete, 10);
            ApplyRoundCornerToButton(buttonViewCompleted, 10);
            ApplyRoundCornerToButton(buttonSearch, 10);

            // Apply rounded corners to text boxes and list boxes using GraphicsPath
            ApplyRoundedBorderToControl(textBoxTask, 8);
            ApplyRoundedBorderToControl(textBoxCategory, 8);
            ApplyRoundedBorderToControl(comboBoxPriority, 8);
            ApplyRoundedBorderToControl(listBoxTasks, 12);
            ApplyRoundedBorderToControl(dateTimePickerDueDate, 8);
        }

        private void ApplyRoundCornerToButton(Button btn, int radius)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            btn.Region = new Region(path);

            // Add paint event to maintain rounded corners after resizing
            btn.Paint += (sender, e) =>
            {
                Button button = (Button)sender;
                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                buttonPath.AddArc(0, 0, radius, radius, 180, 90);
                buttonPath.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
                buttonPath.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
                buttonPath.AddArc(0, button.Height - radius, radius, radius, 90, 90);
                button.Region = new Region(buttonPath);
            };
        }

        private void ApplyRoundedBorderToControl(Control control, int radius)
        {
            // Create a graphics path for the rounded rectangle
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(control.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(control.Width - (radius * 2), control.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddArc(0, control.Height - (radius * 2), radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();

            // Apply region to control
            control.Region = new Region(path);

            // Handle resize to maintain rounded corners
            control.Resize += (sender, e) =>
            {
                Control ctrl = (Control)sender;
                if (ctrl.Width > 0 && ctrl.Height > 0)
                {
                    System.Drawing.Drawing2D.GraphicsPath resizedPath = new System.Drawing.Drawing2D.GraphicsPath();
                    resizedPath.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                    resizedPath.AddArc(ctrl.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90);
                    resizedPath.AddArc(ctrl.Width - (radius * 2), ctrl.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
                    resizedPath.AddArc(0, ctrl.Height - (radius * 2), radius * 2, radius * 2, 90, 90);
                    resizedPath.CloseAllFigures();
                    ctrl.Region = new Region(resizedPath);
                }
            };

            // For certain controls that need border painting (like TextBox)
            if (control is TextBox || control is ComboBox || control is DateTimePicker)
            {
                // Add border painting
                control.Paint += (sender, e) =>
                {
                    Control ctrl = (Control)sender;
                    Rectangle rect = new Rectangle(0, 0, ctrl.Width - 1, ctrl.Height - 1);
                    using (Pen pen = new Pen(Color.LightSteelBlue, 1))
                    {
                        System.Drawing.Drawing2D.GraphicsPath borderPath = new System.Drawing.Drawing2D.GraphicsPath();
                        borderPath.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                        borderPath.AddArc(rect.Right - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90);
                        borderPath.AddArc(rect.Right - (radius * 2), rect.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90);
                        borderPath.AddArc(rect.X, rect.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90);
                        borderPath.CloseAllFigures();

                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        e.Graphics.DrawPath(pen, borderPath);
                    }
                };
            }
        }
        private Panel panelSideDecoration;
        private PictureBox pictureBoxLogo;
        private Panel panel1;
    }
}