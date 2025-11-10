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
            LoginButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(textBox2);
            gbLogin.Controls.Add(textBox1);
            gbLogin.Controls.Add(LoginButton);
            gbLogin.Location = new Point(30, 37);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(296, 347);
            gbLogin.TabIndex = 0;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
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
            // textBox1
            // 
            textBox1.Location = new Point(45, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 31);
            textBox1.TabIndex = 1;
            //textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 31);
            textBox2.TabIndex = 2;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbLogin);
            Name = "LoginScreen";
            Text = "Login";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button LoginButton;
    }
}
