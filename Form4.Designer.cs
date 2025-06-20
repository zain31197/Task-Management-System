namespace Myapp
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button buttonSortPriority;
        private System.Windows.Forms.ComboBox comboBoxSortPriority;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            listBoxResults = new ListBox();
            labelTitle = new Label();
            labelSearch = new Label();
            buttonSortPriority = new Button();
            comboBoxSortPriority = new ComboBox();
            buttonBack = new Button();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            labelFromDate = new Label();
            labelToDate = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.AliceBlue;
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Segoe UI", 12F);
            textBoxSearch.Location = new Point(170, 115);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Enter search keyword...";
            textBoxSearch.Size = new Size(701, 32);
            textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.RoyalBlue;
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(204, 299);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(180, 50);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += ButtonSearch_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = Color.AliceBlue;
            listBoxResults.BorderStyle = BorderStyle.None;
            listBoxResults.Font = new Font("Segoe UI", 12F);
            listBoxResults.ForeColor = Color.RoyalBlue;
            listBoxResults.ItemHeight = 32;
            listBoxResults.Location = new Point(170, 382);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(701, 192);
            listBoxResults.TabIndex = 10;
            listBoxResults.SelectedIndexChanged += listBoxResults_SelectedIndexChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.RoyalBlue;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(335, 74);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Task Search";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F);
            labelSearch.ForeColor = Color.RoyalBlue;
            labelSearch.Location = new Point(12, 115);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(111, 32);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Keyword:";
            labelSearch.Click += labelSearch_Click;
            // 
            // buttonSortPriority
            // 
            buttonSortPriority.BackColor = Color.CornflowerBlue;
            buttonSortPriority.Cursor = Cursors.Hand;
            buttonSortPriority.FlatAppearance.BorderSize = 0;
            buttonSortPriority.FlatStyle = FlatStyle.Flat;
            buttonSortPriority.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSortPriority.ForeColor = Color.White;
            buttonSortPriority.Location = new Point(472, 299);
            buttonSortPriority.Name = "buttonSortPriority";
            buttonSortPriority.Size = new Size(179, 50);
            buttonSortPriority.TabIndex = 9;
            buttonSortPriority.Text = "Sort by Priority";
            buttonSortPriority.UseVisualStyleBackColor = false;
            buttonSortPriority.Click += ButtonSortPriority_Click;
            // 
            // comboBoxSortPriority
            // 
            comboBoxSortPriority.BackColor = Color.AliceBlue;
            comboBoxSortPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortPriority.FlatStyle = FlatStyle.Flat;
            comboBoxSortPriority.Font = new Font("Segoe UI", 12F);
            comboBoxSortPriority.Items.AddRange(new object[] { "All Priorities", "High", "Normal", "Low" });
            comboBoxSortPriority.Location = new Point(170, 235);
            comboBoxSortPriority.Name = "comboBoxSortPriority";
            comboBoxSortPriority.Size = new Size(701, 40);
            comboBoxSortPriority.TabIndex = 7;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.SteelBlue;
            buttonBack.Cursor = Cursors.Hand;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(385, 589);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(191, 48);
            buttonBack.TabIndex = 11;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += ButtonBack_Click;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.CalendarForeColor = Color.RoyalBlue;
            dateTimePickerFrom.CalendarMonthBackground = Color.White;
            dateTimePickerFrom.CalendarTitleBackColor = Color.RoyalBlue;
            dateTimePickerFrom.CalendarTitleForeColor = Color.White;
            dateTimePickerFrom.Font = new Font("Segoe UI", 10F);
            dateTimePickerFrom.Location = new Point(170, 175);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(289, 34);
            dateTimePickerFrom.TabIndex = 4;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.CalendarForeColor = Color.RoyalBlue;
            dateTimePickerTo.CalendarMonthBackground = Color.White;
            dateTimePickerTo.CalendarTitleBackColor = Color.RoyalBlue;
            dateTimePickerTo.CalendarTitleForeColor = Color.White;
            dateTimePickerTo.Font = new Font("Segoe UI", 10F);
            dateTimePickerTo.Location = new Point(556, 175);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(315, 34);
            dateTimePickerTo.TabIndex = 6;
            // 
            // labelFromDate
            // 
            labelFromDate.AutoSize = true;
            labelFromDate.Font = new Font("Segoe UI", 12F);
            labelFromDate.ForeColor = Color.RoyalBlue;
            labelFromDate.Location = new Point(12, 175);
            labelFromDate.Name = "labelFromDate";
            labelFromDate.Size = new Size(74, 32);
            labelFromDate.TabIndex = 3;
            labelFromDate.Text = "From:";
            // 
            // labelToDate
            // 
            labelToDate.AutoSize = true;
            labelToDate.Font = new Font("Segoe UI", 12F);
            labelToDate.ForeColor = Color.RoyalBlue;
            labelToDate.Location = new Point(472, 175);
            labelToDate.Name = "labelToDate";
            labelToDate.Size = new Size(44, 32);
            labelToDate.TabIndex = 5;
            labelToDate.Text = "To:";
            labelToDate.Click += labelToDate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(12, 371);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 12;
            label1.Text = "Results:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(12, 235);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 13;
            label2.Text = "Priority:";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.ErrorImage = (Image)resources.GetObject("pictureBoxLogo.ErrorImage");
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.InitialImage = (Image)resources.GetObject("pictureBoxLogo.InitialImage");
            pictureBoxLogo.Location = new Point(906, 13);
            pictureBoxLogo.Margin = new Padding(4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(82, 80);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 14;
            pictureBoxLogo.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1001, 663);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelFromDate);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(labelToDate);
            Controls.Add(dateTimePickerTo);
            Controls.Add(comboBoxSortPriority);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSortPriority);
            Controls.Add(listBoxResults);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form4";
            Text = "Task Search";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ApplyRoundedCorners()
        {
            // Apply rounded corners to buttons
            ApplyRoundCornerToButton(buttonSearch, 10);
            ApplyRoundCornerToButton(buttonSortPriority, 10);
            ApplyRoundCornerToButton(buttonBack, 10);

            // Apply rounded corners to text boxes and list boxes
            ApplyRoundedBorderToControl(textBoxSearch, 8);
            ApplyRoundedBorderToControl(comboBoxSortPriority, 8);
            ApplyRoundedBorderToControl(listBoxResults, 12);
            ApplyRoundedBorderToControl(dateTimePickerFrom, 8);
            ApplyRoundedBorderToControl(dateTimePickerTo, 8);
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
        private PictureBox pictureBoxLogo;
    }
}