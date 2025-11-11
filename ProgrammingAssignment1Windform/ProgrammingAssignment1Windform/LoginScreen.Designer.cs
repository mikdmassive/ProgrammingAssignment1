namespace ProgrammingAssignment1Windform
{
    partial class LoginScreen
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
            CreateAccountGroup = new GroupBox();
            UsernameMessageLabel = new Label();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            CreateAccountButton = new Button();
            groupBox1 = new GroupBox();
            LoginPasswordLabel = new Label();
            LoginUsernameLabel = new Label();
            LoginPasswordTextBox = new TextBox();
            LoginUsernameTextBox = new TextBox();
            LoginButton = new Button();
            CreateAccountGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CreateAccountGroup
            // 
            CreateAccountGroup.Controls.Add(UsernameMessageLabel);
            CreateAccountGroup.Controls.Add(PasswordLabel);
            CreateAccountGroup.Controls.Add(UsernameLabel);
            CreateAccountGroup.Controls.Add(passwordTextBox);
            CreateAccountGroup.Controls.Add(usernameTextBox);
            CreateAccountGroup.Controls.Add(CreateAccountButton);
            CreateAccountGroup.Location = new Point(30, 37);
            CreateAccountGroup.Name = "CreateAccountGroup";
            CreateAccountGroup.Size = new Size(296, 347);
            CreateAccountGroup.TabIndex = 0;
            CreateAccountGroup.TabStop = false;
            CreateAccountGroup.Text = "Create Account";
            // 
            // UsernameMessageLabel
            // 
            UsernameMessageLabel.Anchor = AnchorStyles.Top;
            UsernameMessageLabel.AutoSize = true;
            UsernameMessageLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameMessageLabel.Location = new Point(0, 89);
            UsernameMessageLabel.Name = "UsernameMessageLabel";
            UsernameMessageLabel.Size = new Size(79, 21);
            UsernameMessageLabel.TabIndex = 5;
            UsernameMessageLabel.Text = "MESSAGE";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(45, 151);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 25);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(45, 27);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(91, 25);
            UsernameLabel.TabIndex = 3;
            UsernameLabel.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(45, 179);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(205, 31);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextChanged += PasswordTextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(45, 55);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(208, 31);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += UsernameTextChange;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Location = new Point(93, 282);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(112, 34);
            CreateAccountButton.TabIndex = 0;
            CreateAccountButton.Text = "Submit";
            CreateAccountButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LoginPasswordLabel);
            groupBox1.Controls.Add(LoginUsernameLabel);
            groupBox1.Controls.Add(LoginPasswordTextBox);
            groupBox1.Controls.Add(LoginUsernameTextBox);
            groupBox1.Controls.Add(LoginButton);
            groupBox1.Location = new Point(450, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 347);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // LoginPasswordLabel
            // 
            LoginPasswordLabel.AutoSize = true;
            LoginPasswordLabel.Location = new Point(45, 151);
            LoginPasswordLabel.Name = "LoginPasswordLabel";
            LoginPasswordLabel.Size = new Size(87, 25);
            LoginPasswordLabel.TabIndex = 4;
            LoginPasswordLabel.Text = "Password";
            // 
            // LoginUsernameLabel
            // 
            LoginUsernameLabel.AutoSize = true;
            LoginUsernameLabel.Location = new Point(45, 27);
            LoginUsernameLabel.Name = "LoginUsernameLabel";
            LoginUsernameLabel.Size = new Size(91, 25);
            LoginUsernameLabel.TabIndex = 3;
            LoginUsernameLabel.Text = "Username";
            // 
            // LoginPasswordTextBox
            // 
            LoginPasswordTextBox.Location = new Point(45, 179);
            LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            LoginPasswordTextBox.Size = new Size(205, 31);
            LoginPasswordTextBox.TabIndex = 2;
            // 
            // LoginUsernameTextBox
            // 
            LoginUsernameTextBox.Location = new Point(45, 55);
            LoginUsernameTextBox.Name = "LoginUsernameTextBox";
            LoginUsernameTextBox.Size = new Size(208, 31);
            LoginUsernameTextBox.TabIndex = 1;
            LoginUsernameTextBox.TextChanged += LoginUsernameTextBox_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(93, 282);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 34);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Submit";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(CreateAccountGroup);
            Name = "LoginScreen";
            Text = "Login";
            CreateAccountGroup.ResumeLayout(false);
            CreateAccountGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CreateAccountGroup;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button CreateAccountButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label UsernameMessageLabel;
        private GroupBox groupBox1;
        private Label LoginPasswordLabel;
        private Label LoginUsernameLabel;
        private TextBox LoginPasswordTextBox;
        private TextBox LoginUsernameTextBox;
        private Button LoginButton;
    }
}
