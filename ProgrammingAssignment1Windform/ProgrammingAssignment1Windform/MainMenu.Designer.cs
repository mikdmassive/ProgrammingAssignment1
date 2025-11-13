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
            LogoutButton = new Button();
            StaffMenuButton = new Button();
            BetHistoryButton = new Button();
            Balance = new Label();
            UsedGroupBox = new GroupBox();
            PlaceBets = new Button();
            ViewMatchesButton = new Button();
            ViewBetsButton = new Button();
            DepositButton = new Button();
            MainMenuGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuGroupBox
            // 
            MainMenuGroupBox.Controls.Add(DepositButton);
            MainMenuGroupBox.Controls.Add(LogoutButton);
            MainMenuGroupBox.Controls.Add(StaffMenuButton);
            MainMenuGroupBox.Controls.Add(BetHistoryButton);
            MainMenuGroupBox.Controls.Add(Balance);
            MainMenuGroupBox.Controls.Add(UsedGroupBox);
            MainMenuGroupBox.Controls.Add(PlaceBets);
            MainMenuGroupBox.Controls.Add(ViewMatchesButton);
            MainMenuGroupBox.Controls.Add(ViewBetsButton);
            MainMenuGroupBox.Location = new Point(39, 27);
            MainMenuGroupBox.Name = "MainMenuGroupBox";
            MainMenuGroupBox.Size = new Size(1010, 897);
            MainMenuGroupBox.TabIndex = 0;
            MainMenuGroupBox.TabStop = false;
            MainMenuGroupBox.Text = "groupBox1";
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(27, 512);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(136, 58);
            LogoutButton.TabIndex = 9;
            LogoutButton.Text = "Log Out";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // StaffMenuButton
            // 
            StaffMenuButton.Location = new Point(27, 357);
            StaffMenuButton.Name = "StaffMenuButton";
            StaffMenuButton.Size = new Size(136, 58);
            StaffMenuButton.TabIndex = 8;
            StaffMenuButton.Text = "Staff Menu";
            StaffMenuButton.UseVisualStyleBackColor = true;
            StaffMenuButton.Click += StaffMenuButton_Click;
            // 
            // BetHistoryButton
            // 
            BetHistoryButton.Location = new Point(27, 248);
            BetHistoryButton.Name = "BetHistoryButton";
            BetHistoryButton.Size = new Size(136, 75);
            BetHistoryButton.TabIndex = 7;
            BetHistoryButton.Text = "View Bet History";
            BetHistoryButton.UseVisualStyleBackColor = true;
            BetHistoryButton.Click += BetHistoryButton_Click;
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
            // UsedGroupBox
            // 
            UsedGroupBox.Location = new Point(256, 18);
            UsedGroupBox.Name = "UsedGroupBox";
            UsedGroupBox.Size = new Size(741, 838);
            UsedGroupBox.TabIndex = 5;
            UsedGroupBox.TabStop = false;
            UsedGroupBox.Enter += groupBox1_Enter;
            // 
            // PlaceBets
            // 
            PlaceBets.Location = new Point(27, 197);
            PlaceBets.Name = "PlaceBets";
            PlaceBets.Size = new Size(136, 33);
            PlaceBets.TabIndex = 2;
            PlaceBets.Text = "Place Bets";
            PlaceBets.UseVisualStyleBackColor = true;
            PlaceBets.Click += PlaceBets_Click;
            // 
            // ViewMatchesButton
            // 
            ViewMatchesButton.Location = new Point(27, 140);
            ViewMatchesButton.Name = "ViewMatchesButton";
            ViewMatchesButton.Size = new Size(136, 33);
            ViewMatchesButton.TabIndex = 1;
            ViewMatchesButton.Text = "View Matches";
            ViewMatchesButton.UseVisualStyleBackColor = true;
            ViewMatchesButton.Click += ViewMatchesButton_Click;
            // 
            // ViewBetsButton
            // 
            ViewBetsButton.Location = new Point(27, 85);
            ViewBetsButton.Name = "ViewBetsButton";
            ViewBetsButton.Size = new Size(136, 33);
            ViewBetsButton.TabIndex = 0;
            ViewBetsButton.Text = "View Bets";
            ViewBetsButton.UseVisualStyleBackColor = true;
            ViewBetsButton.Click += ViewBetsButton_Click;
            // 
            // DepositButton
            // 
            DepositButton.Location = new Point(27, 434);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(136, 58);
            DepositButton.TabIndex = 10;
            DepositButton.Text = "Deposit";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 942);
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
        private Button BetHistoryButton;
        private Button StaffMenuButton;
        private Button LogoutButton;
        private Button DepositButton;
    }
}