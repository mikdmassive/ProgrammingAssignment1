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
            gbLogin = new GroupBox();
            UsernameMessageLabel = new Label();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            LoginButton = new Button();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(UsernameMessageLabel);
            gbLogin.Controls.Add(PasswordLabel);
            gbLogin.Controls.Add(UsernameLabel);
            gbLogin.Controls.Add(passwordTextBox);
            gbLogin.Controls.Add(usernameTextBox);
            gbLogin.Controls.Add(LoginButton);
            gbLogin.Location = new Point(30, 37);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(296, 347);
            gbLogin.TabIndex = 0;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
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
            // LoginButton
            // 
            LoginButton.Location = new Point(93, 282);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(112, 34);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Submit";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbLogin);
            Name = "LoginScreen";
            Text = "Login";
            Load += LoginScreen_Load;
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbLogin;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button LoginButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label UsernameMessageLabel;
    }
}
