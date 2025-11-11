namespace ProgrammingAssignment1Windform
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainMenuGroupBox = new GroupBox();
            UsedGroupBox = new GroupBox();
            PlaceBets = new Button();
            ViewMatchesButton = new Button();
            ViewBetsButton = new Button();
            Balance = new Label();
            MainMenuGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuGroupBox
            // 
            MainMenuGroupBox.Controls.Add(Balance);
            MainMenuGroupBox.Controls.Add(UsedGroupBox);
            MainMenuGroupBox.Controls.Add(PlaceBets);
            MainMenuGroupBox.Controls.Add(ViewMatchesButton);
            MainMenuGroupBox.Controls.Add(ViewBetsButton);
            MainMenuGroupBox.Location = new Point(39, 26);
            MainMenuGroupBox.Name = "MainMenuGroupBox";
            MainMenuGroupBox.Size = new Size(749, 432);
            MainMenuGroupBox.TabIndex = 0;
            MainMenuGroupBox.TabStop = false;
            MainMenuGroupBox.Text = "groupBox1";
            // 
            // UsedGroupBox
            // 
            UsedGroupBox.Location = new Point(443, 18);
            UsedGroupBox.Name = "UsedGroupBox";
            UsedGroupBox.Size = new Size(300, 414);
            UsedGroupBox.TabIndex = 5;
            UsedGroupBox.TabStop = false;
            UsedGroupBox.Enter += groupBox1_Enter;
            // 
            // PlaceBets
            // 
            PlaceBets.Location = new Point(27, 196);
            PlaceBets.Name = "PlaceBets";
            PlaceBets.Size = new Size(136, 34);
            PlaceBets.TabIndex = 2;
            PlaceBets.Text = "Place Bets";
            PlaceBets.UseVisualStyleBackColor = true;
            PlaceBets.Click += PlaceBets_Click;
            // 
            // ViewMatchesButton
            // 
            ViewMatchesButton.Location = new Point(27, 140);
            ViewMatchesButton.Name = "ViewMatchesButton";
            ViewMatchesButton.Size = new Size(136, 34);
            ViewMatchesButton.TabIndex = 1;
            ViewMatchesButton.Text = "View Matches";
            ViewMatchesButton.UseVisualStyleBackColor = true;
            ViewMatchesButton.Click += ViewMatchesButton_Click;
            // 
            // ViewBetsButton
            // 
            ViewBetsButton.Location = new Point(27, 85);
            ViewBetsButton.Name = "ViewBetsButton";
            ViewBetsButton.Size = new Size(136, 34);
            ViewBetsButton.TabIndex = 0;
            ViewBetsButton.Text = "View Bets";
            ViewBetsButton.UseVisualStyleBackColor = true;
            ViewBetsButton.Click += ViewBetsButton_Click;
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.BorderStyle = BorderStyle.FixedSingle;
            Balance.Location = new Point(27, 45);
            Balance.Name = "Balance";
            Balance.Size = new Size(61, 27);
            Balance.TabIndex = 6;
            Balance.Text = "label1";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(MainMenuGroupBox);
            Name = "MainMenu";
            Text = "Main Menu";
            Load += MainMenu_Load;
            MainMenuGroupBox.ResumeLayout(false);
            MainMenuGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MainMenuGroupBox;
        private Button PlaceBets;
        private Button ViewMatchesButton;
        private Button ViewBetsButton;
        private GroupBox UsedGroupBox;
        private Label Balance;
    }
}