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
            NameMessageLabel = new Label();
            LNameLabel = new Label();
            LNameTextBox = new TextBox();
            FnameLabel = new Label();
            FNameTextBox = new TextBox();
            PasswordMessageLabel = new Label();
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
            CreateAccountGroup.Controls.Add(NameMessageLabel);
            CreateAccountGroup.Controls.Add(LNameLabel);
            CreateAccountGroup.Controls.Add(LNameTextBox);
            CreateAccountGroup.Controls.Add(FnameLabel);
            CreateAccountGroup.Controls.Add(FNameTextBox);
            CreateAccountGroup.Controls.Add(PasswordMessageLabel);
            CreateAccountGroup.Controls.Add(UsernameMessageLabel);
            CreateAccountGroup.Controls.Add(PasswordLabel);
            CreateAccountGroup.Controls.Add(UsernameLabel);
            CreateAccountGroup.Controls.Add(passwordTextBox);
            CreateAccountGroup.Controls.Add(usernameTextBox);
            CreateAccountGroup.Controls.Add(CreateAccountButton);
            CreateAccountGroup.Location = new Point(21, 11);
            CreateAccountGroup.Margin = new Padding(2);
            CreateAccountGroup.Name = "CreateAccountGroup";
            CreateAccountGroup.Padding = new Padding(2);
            CreateAccountGroup.Size = new Size(207, 300);
            CreateAccountGroup.TabIndex = 0;
            CreateAccountGroup.TabStop = false;
            CreateAccountGroup.Text = "Create Account";
            CreateAccountGroup.Enter += CreateAccountGroup_Enter;
            // 
            // NameMessageLabel
            // 
            NameMessageLabel.Anchor = AnchorStyles.Top;
            NameMessageLabel.AutoSize = true;
            NameMessageLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameMessageLabel.Location = new Point(-2, 58);
            NameMessageLabel.Margin = new Padding(2, 0, 2, 0);
            NameMessageLabel.Name = "NameMessageLabel";
            NameMessageLabel.Size = new Size(56, 13);
            NameMessageLabel.TabIndex = 11;
            NameMessageLabel.Text = "MESSAGE";
            // 
            // LNameLabel
            // 
            LNameLabel.AutoSize = true;
            LNameLabel.Location = new Point(114, 16);
            LNameLabel.Margin = new Padding(2, 0, 2, 0);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(63, 15);
            LNameLabel.TabIndex = 10;
            LNameLabel.Text = "Last Name";
            // 
            // LNameTextBox
            // 
            LNameTextBox.Location = new Point(114, 33);
            LNameTextBox.Margin = new Padding(2);
            LNameTextBox.Name = "LNameTextBox";
            LNameTextBox.Size = new Size(89, 23);
            LNameTextBox.TabIndex = 9;
            LNameTextBox.TextChanged += ValidateBothNameTextBoxes;
            // 
            // FnameLabel
            // 
            FnameLabel.AutoSize = true;
            FnameLabel.Location = new Point(4, 16);
            FnameLabel.Margin = new Padding(2, 0, 2, 0);
            FnameLabel.Name = "FnameLabel";
            FnameLabel.Size = new Size(64, 15);
            FnameLabel.TabIndex = 8;
            FnameLabel.Text = "First Name";
            FnameLabel.Click += FnameLabel_Click;
            // 
            // FNameTextBox
            // 
            FNameTextBox.Location = new Point(4, 33);
            FNameTextBox.Margin = new Padding(2);
            FNameTextBox.Name = "FNameTextBox";
            FNameTextBox.Size = new Size(89, 23);
            FNameTextBox.TabIndex = 7;
            FNameTextBox.TextChanged += ValidateBothNameTextBoxes;
            // 
            // PasswordMessageLabel
            // 
            PasswordMessageLabel.Anchor = AnchorStyles.Top;
            PasswordMessageLabel.AutoSize = true;
            PasswordMessageLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordMessageLabel.Location = new Point(0, 215);
            PasswordMessageLabel.Margin = new Padding(2, 0, 2, 0);
            PasswordMessageLabel.Name = "PasswordMessageLabel";
            PasswordMessageLabel.Size = new Size(56, 13);
            PasswordMessageLabel.TabIndex = 6;
            PasswordMessageLabel.Text = "MESSAGE";
            // 
            // UsernameMessageLabel
            // 
            UsernameMessageLabel.Anchor = AnchorStyles.Top;
            UsernameMessageLabel.AutoSize = true;
            UsernameMessageLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameMessageLabel.Location = new Point(-2, 127);
            UsernameMessageLabel.Margin = new Padding(2, 0, 2, 0);
            UsernameMessageLabel.Name = "UsernameMessageLabel";
            UsernameMessageLabel.Size = new Size(56, 13);
            UsernameMessageLabel.TabIndex = 5;
            UsernameMessageLabel.Text = "MESSAGE";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(32, 169);
            PasswordLabel.Margin = new Padding(2, 0, 2, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(30, 90);
            UsernameLabel.Margin = new Padding(2, 0, 2, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 3;
            UsernameLabel.Text = "Username";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(32, 185);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(145, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextChanged += PasswordTextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(30, 107);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(147, 23);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += UsernameTextChange;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Location = new Point(64, 267);
            CreateAccountButton.Margin = new Padding(2);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(78, 20);
            CreateAccountButton.TabIndex = 0;
            CreateAccountButton.Text = "Submit";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += CreateAccountButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LoginPasswordLabel);
            groupBox1.Controls.Add(LoginUsernameLabel);
            groupBox1.Controls.Add(LoginPasswordTextBox);
            groupBox1.Controls.Add(LoginUsernameTextBox);
            groupBox1.Controls.Add(LoginButton);
            groupBox1.Location = new Point(315, 22);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(207, 208);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // LoginPasswordLabel
            // 
            LoginPasswordLabel.AutoSize = true;
            LoginPasswordLabel.Location = new Point(32, 91);
            LoginPasswordLabel.Margin = new Padding(2, 0, 2, 0);
            LoginPasswordLabel.Name = "LoginPasswordLabel";
            LoginPasswordLabel.Size = new Size(57, 15);
            LoginPasswordLabel.TabIndex = 4;
            LoginPasswordLabel.Text = "Password";
            // 
            // LoginUsernameLabel
            // 
            LoginUsernameLabel.AutoSize = true;
            LoginUsernameLabel.Location = new Point(32, 16);
            LoginUsernameLabel.Margin = new Padding(2, 0, 2, 0);
            LoginUsernameLabel.Name = "LoginUsernameLabel";
            LoginUsernameLabel.Size = new Size(60, 15);
            LoginUsernameLabel.TabIndex = 3;
            LoginUsernameLabel.Text = "Username";
            // 
            // LoginPasswordTextBox
            // 
            LoginPasswordTextBox.Location = new Point(32, 107);
            LoginPasswordTextBox.Margin = new Padding(2);
            LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            LoginPasswordTextBox.Size = new Size(145, 23);
            LoginPasswordTextBox.TabIndex = 2;
            LoginPasswordTextBox.TextChanged += LoginPasswordTextBox_TextChanged;
            // 
            // LoginUsernameTextBox
            // 
            LoginUsernameTextBox.Location = new Point(32, 33);
            LoginUsernameTextBox.Margin = new Padding(2);
            LoginUsernameTextBox.Name = "LoginUsernameTextBox";
            LoginUsernameTextBox.Size = new Size(147, 23);
            LoginUsernameTextBox.TabIndex = 1;
            LoginUsernameTextBox.TextChanged += LoginUsernameTextBox_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(65, 169);
            LoginButton.Margin = new Padding(2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(78, 20);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Submit";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 337);
            Controls.Add(groupBox1);
            Controls.Add(CreateAccountGroup);
            Margin = new Padding(2);
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
        private GroupBox groupBox1;
        private Label LoginPasswordLabel;
        private Label LoginUsernameLabel;
        private TextBox LoginPasswordTextBox;
        private TextBox LoginUsernameTextBox;
        private Button LoginButton;
        private Label UsernameMessageLabel;
        private Label PasswordMessageLabel;
        private Label FnameLabel;
        private TextBox FNameTextBox;
        private Label LNameLabel;
        private TextBox LNameTextBox;
        private Label NameMessageLabel;
    }
}
