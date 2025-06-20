namespace Myapp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelSideDecoration;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelCompanySlogan;
        private System.Windows.Forms.CheckBox checkBoxRemember;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelLogin = new Panel();
            checkBoxRemember = new CheckBox();
            labelCompanySlogan = new Label();
            labelWelcome = new Label();
            pictureBoxLogo = new PictureBox();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            panelSideDecoration = new Panel();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Transparent;
            panelLogin.Controls.Add(checkBoxRemember);
            panelLogin.Controls.Add(labelCompanySlogan);
            panelLogin.Controls.Add(labelWelcome);
            panelLogin.Controls.Add(pictureBoxLogo);
            panelLogin.Controls.Add(labelUsername);
            panelLogin.Controls.Add(textBoxUsername);
            panelLogin.Controls.Add(labelPassword);
            panelLogin.Controls.Add(textBoxPassword);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Dock = DockStyle.Right;
            panelLogin.Location = new Point(437, 0);
            panelLogin.Margin = new Padding(4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(625, 812);
            panelLogin.TabIndex = 0;
            // 
            // checkBoxRemember
            // 
            checkBoxRemember.AutoSize = true;
            checkBoxRemember.Font = new Font("Segoe UI", 9F);
            checkBoxRemember.ForeColor = Color.FromArgb(50, 80, 150);
            checkBoxRemember.Location = new Point(112, 526);
            checkBoxRemember.Margin = new Padding(4);
            checkBoxRemember.Name = "checkBoxRemember";
            checkBoxRemember.Size = new Size(154, 29);
            checkBoxRemember.TabIndex = 6;
            checkBoxRemember.Text = "Remember me";
            checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // labelCompanySlogan
            // 
            labelCompanySlogan.AutoSize = true;
            labelCompanySlogan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompanySlogan.ForeColor = Color.FromArgb(25, 60, 140);
            labelCompanySlogan.Location = new Point(231, 290);
            labelCompanySlogan.Margin = new Padding(4, 0, 4, 0);
            labelCompanySlogan.Name = "labelCompanySlogan";
            labelCompanySlogan.Size = new Size(167, 25);
            labelCompanySlogan.TabIndex = 1;
            labelCompanySlogan.Text = "Focus Finish Repeat";
            labelCompanySlogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = Color.FromArgb(25, 60, 140);
            labelWelcome.Location = new Point(199, 324);
            labelWelcome.Margin = new Padding(4, 0, 4, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(231, 45);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Welcome Back";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.ErrorImage = (Image)resources.GetObject("pictureBoxLogo.ErrorImage");
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.InitialImage = (Image)resources.GetObject("pictureBoxLogo.InitialImage");
            pictureBoxLogo.Location = new Point(222, 66);
            pictureBoxLogo.Margin = new Padding(4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(188, 185);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.FromArgb(50, 80, 150);
            labelUsername.Location = new Point(112, 369);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(104, 28);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.LightSkyBlue;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Segoe UI", 11F);
            textBoxUsername.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxUsername.Location = new Point(112, 400);
            textBoxUsername.Margin = new Padding(4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(400, 30);
            textBoxUsername.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(50, 80, 150);
            labelPassword.Location = new Point(112, 456);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(97, 28);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.LightSkyBlue;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 11F);
            textBoxPassword.ForeColor = Color.FromArgb(60, 60, 60);
            textBoxPassword.Location = new Point(112, 488);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(400, 30);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(25, 60, 140);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(112, 575);
            buttonLogin.Margin = new Padding(4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(400, 56);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Sign In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panelSideDecoration
            // 
            panelSideDecoration.BackColor = Color.FromArgb(25, 60, 140);
            panelSideDecoration.BackgroundImage = (Image)resources.GetObject("panelSideDecoration.BackgroundImage");
            panelSideDecoration.BackgroundImageLayout = ImageLayout.Stretch;
            panelSideDecoration.Dock = DockStyle.Left;
            panelSideDecoration.Location = new Point(0, 0);
            panelSideDecoration.Margin = new Padding(4);
            panelSideDecoration.Name = "panelSideDecoration";
            panelSideDecoration.Size = new Size(438, 812);
            panelSideDecoration.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1062, 812);
            Controls.Add(panelSideDecoration);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load_2;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        private void Form1_Load_2(object sender, EventArgs e)
        {
            // Create custom borders for the textboxes
            CreateTextBoxBorder(textBoxUsername);
            CreateTextBoxBorder(textBoxPassword);
        }

        private void CreateTextBoxBorder(TextBox textBox)
        {
            Panel border = new Panel();
            border.BackColor = Color.FromArgb(240, 240, 240);
            border.Location = new Point(textBox.Location.X, textBox.Location.Y);
            border.Size = new Size(textBox.Width, textBox.Height);
            border.Padding = new Padding(8, 8, 8, 8);
            border.BorderStyle = BorderStyle.FixedSingle;

            // Insert the border panel just before the textbox in the control collection
            panelLogin.Controls.Add(border);

            // Make sure the textbox is on top of the border panel
            textBox.Parent = border;
            textBox.Location = new Point(8, 5);
            textBox.Width = border.Width - 16;
            textBox.Height = border.Height - 10;
        }
    }
}