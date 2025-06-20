namespace Myapp
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxCompletedTasks;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRestore; // Added Restore Button
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            listBoxCompletedTasks = new ListBox();
            buttonClose = new Button();
            buttonRestore = new Button();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // listBoxCompletedTasks
            // 
            listBoxCompletedTasks.BackColor = Color.White;
            listBoxCompletedTasks.BorderStyle = BorderStyle.None;
            listBoxCompletedTasks.Dock = DockStyle.Top;
            listBoxCompletedTasks.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxCompletedTasks.ForeColor = Color.RoyalBlue;
            listBoxCompletedTasks.FormattingEnabled = true;
            listBoxCompletedTasks.ItemHeight = 28;
            listBoxCompletedTasks.Location = new Point(15, 15);
            listBoxCompletedTasks.Name = "listBoxCompletedTasks";
            listBoxCompletedTasks.Size = new Size(847, 420);
            listBoxCompletedTasks.TabIndex = 0;
            listBoxCompletedTasks.SelectedIndexChanged += listBoxCompletedTasks_SelectedIndexChanged;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.Dock = DockStyle.Bottom;
            buttonClose.FlatAppearance.BorderColor = Color.RoyalBlue;
            buttonClose.FlatAppearance.BorderSize = 2;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.ForeColor = Color.RoyalBlue;
            buttonClose.Location = new Point(15, 508);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(847, 51);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += ButtonClose_Click;
            // 
            // buttonRestore
            // 
            buttonRestore.BackColor = Color.RoyalBlue;
            buttonRestore.Dock = DockStyle.Bottom;
            buttonRestore.FlatAppearance.BorderSize = 0;
            buttonRestore.FlatStyle = FlatStyle.Flat;
            buttonRestore.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRestore.ForeColor = Color.White;
            buttonRestore.Location = new Point(15, 455);
            buttonRestore.Name = "buttonRestore";
            buttonRestore.Size = new Size(847, 53);
            buttonRestore.TabIndex = 2;
            buttonRestore.Text = "Restore Task";
            buttonRestore.UseVisualStyleBackColor = false;
            buttonRestore.Click += buttonRestore_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.ErrorImage = (Image)resources.GetObject("pictureBoxLogo.ErrorImage");
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.InitialImage = (Image)resources.GetObject("pictureBoxLogo.InitialImage");
            pictureBoxLogo.Location = new Point(757, 15);
            pictureBoxLogo.Margin = new Padding(4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(105, 103);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 12;
            pictureBoxLogo.TabStop = false;
            // 
            // Form3
            // 
            BackColor = Color.White;
            ClientSize = new Size(877, 574);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonRestore);
            Controls.Add(buttonClose);
            Controls.Add(listBoxCompletedTasks);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Completed Tasks";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBoxLogo;
    }
}