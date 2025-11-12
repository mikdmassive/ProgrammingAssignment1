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
            StaffMenuButton = new Button();
            BetHistoryButton = new Button();
            Balance = new Label();
            UsedGroupBox = new GroupBox();
            PlaceBets = new Button();
            ViewMatchesButton = new Button();
            ViewBetsButton = new Button();
            LogoutButton = new Button();
            MainMenuGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuGroupBox
            // 
            MainMenuGroupBox.Controls.Add(LogoutButton);
            MainMenuGroupBox.Controls.Add(StaffMenuButton);
            MainMenuGroupBox.Controls.Add(BetHistoryButton);
            MainMenuGroupBox.Controls.Add(Balance);
            MainMenuGroupBox.Controls.Add(UsedGroupBox);
            MainMenuGroupBox.Controls.Add(PlaceBets);
            MainMenuGroupBox.Controls.Add(ViewMatchesButton);
            MainMenuGroupBox.Controls.Add(ViewBetsButton);
            MainMenuGroupBox.Location = new Point(27, 16);
            MainMenuGroupBox.Margin = new Padding(2);
            MainMenuGroupBox.Name = "MainMenuGroupBox";
            MainMenuGroupBox.Padding = new Padding(2);
            MainMenuGroupBox.Size = new Size(707, 538);
            MainMenuGroupBox.TabIndex = 0;
            MainMenuGroupBox.TabStop = false;
            MainMenuGroupBox.Text = "groupBox1";
            // 
            // StaffMenuButton
            // 
            StaffMenuButton.Location = new Point(19, 214);
            StaffMenuButton.Margin = new Padding(2);
            StaffMenuButton.Name = "StaffMenuButton";
            StaffMenuButton.Size = new Size(95, 35);
            StaffMenuButton.TabIndex = 8;
            StaffMenuButton.Text = "Staff Menu";
            StaffMenuButton.UseVisualStyleBackColor = true;
            StaffMenuButton.Click += StaffMenuButton_Click;
            // 
            // BetHistoryButton
            // 
            BetHistoryButton.Location = new Point(19, 149);
            BetHistoryButton.Margin = new Padding(2);
            BetHistoryButton.Name = "BetHistoryButton";
            BetHistoryButton.Size = new Size(95, 45);
            BetHistoryButton.TabIndex = 7;
            BetHistoryButton.Text = "View Bet History";
            BetHistoryButton.UseVisualStyleBackColor = true;
            BetHistoryButton.Click += BetHistoryButton_Click;
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.BorderStyle = BorderStyle.FixedSingle;
            Balance.Location = new Point(19, 27);
            Balance.Margin = new Padding(2, 0, 2, 0);
            Balance.Name = "Balance";
            Balance.Size = new Size(40, 17);
            Balance.TabIndex = 6;
            Balance.Text = "label1";
            // 
            // UsedGroupBox
            // 
            UsedGroupBox.Location = new Point(179, 11);
            UsedGroupBox.Margin = new Padding(2);
            UsedGroupBox.Name = "UsedGroupBox";
            UsedGroupBox.Padding = new Padding(2);
            UsedGroupBox.Size = new Size(519, 503);
            UsedGroupBox.TabIndex = 5;
            UsedGroupBox.TabStop = false;
            UsedGroupBox.Enter += groupBox1_Enter;
            // 
            // PlaceBets
            // 
            PlaceBets.Location = new Point(19, 118);
            PlaceBets.Margin = new Padding(2);
            PlaceBets.Name = "PlaceBets";
            PlaceBets.Size = new Size(95, 20);
            PlaceBets.TabIndex = 2;
            PlaceBets.Text = "Place Bets";
            PlaceBets.UseVisualStyleBackColor = true;
            PlaceBets.Click += PlaceBets_Click;
            // 
            // ViewMatchesButton
            // 
            ViewMatchesButton.Location = new Point(19, 84);
            ViewMatchesButton.Margin = new Padding(2);
            ViewMatchesButton.Name = "ViewMatchesButton";
            ViewMatchesButton.Size = new Size(95, 20);
            ViewMatchesButton.TabIndex = 1;
            ViewMatchesButton.Text = "View Matches";
            ViewMatchesButton.UseVisualStyleBackColor = true;
            ViewMatchesButton.Click += ViewMatchesButton_Click;
            // 
            // ViewBetsButton
            // 
            ViewBetsButton.Location = new Point(19, 51);
            ViewBetsButton.Margin = new Padding(2);
            ViewBetsButton.Name = "ViewBetsButton";
            ViewBetsButton.Size = new Size(95, 20);
            ViewBetsButton.TabIndex = 0;
            ViewBetsButton.Text = "View Bets";
            ViewBetsButton.UseVisualStyleBackColor = true;
            ViewBetsButton.Click += ViewBetsButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(19, 262);
            LogoutButton.Margin = new Padding(2);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(95, 35);
            LogoutButton.TabIndex = 9;
            LogoutButton.Text = "Log Out";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 565);
            Controls.Add(MainMenuGroupBox);
            Margin = new Padding(2);
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
        private Button BetHistoryButton;
        private Button StaffMenuButton;
        private Button LogoutButton;
    }
}