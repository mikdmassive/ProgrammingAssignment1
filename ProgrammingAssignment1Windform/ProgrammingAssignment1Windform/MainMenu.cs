using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgrammingAssignment1Windform
{
    public partial class MainMenu : Form
    {
        static List<Match> Matches = new List<Match>();
        static User user = null;
        static string staffpassword = "passwordthosewhoknow";
        public MainMenu(User loginuser, List<Match> matches)
        {
            user = loginuser;
            Matches = matches;
            InitializeComponent();

        }
        public void UpdateStats(User userr, List<Match> matches)
        {
            user = userr;
            Matches = matches;
            updateWelcome();
        }
        private void updateWelcome()
        {
            MainMenuGroupBox.Text = $"Welcome, {user.fname} {user.lname}!";
            Balance.Text = "Balance: £" + user.balance.ToString("0.00");
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                updateWelcome();
            }

        }
        Label CreateMessageLabel(string name, string txt, bool border)
        {

            Label label = new Label();
            label.Location = new Point(0, 34 * (UsedGroupBox.Controls.Count + 1));
            label.Name = name;
            label.Size = new Size(UsedGroupBox.Width, 34);
            label.TabIndex = 1;
            System.Drawing.Font f = new System.Drawing.Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold);
            label.Font = f;
            label.Text = txt;
            if (border)
            {
                label.BorderStyle = BorderStyle.FixedSingle;
            }
            label.TextAlign = ContentAlignment.MiddleCenter;

            UsedGroupBox.Controls.Add(label);
            return label;
        }
        Button CreateButton(string name, string txt)
        {

            Button button = new Button();
            button.Location = new Point(0, 34 * (UsedGroupBox.Controls.Count + 1));
            button.Name = name;
            button.Size = new Size(UsedGroupBox.Width, 34);
            button.TabIndex = 1;
            System.Drawing.Font f = new System.Drawing.Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold);
            button.Font = f;
            button.Text = txt;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.UseVisualStyleBackColor = true;
            UsedGroupBox.Controls.Add(button);
            return button;
        }
        TextBox CreateTextbox(string name)
        {
            TextBox textbox = new TextBox();
            textbox.Location = new Point(0, 34 * (UsedGroupBox.Controls.Count + 1));
            textbox.Name = name;
            textbox.Size = new Size(UsedGroupBox.Width, 34);
            textbox.TabIndex = 1;
            System.Drawing.Font f = new System.Drawing.Font(FontFamily.GenericSansSerif, 7, FontStyle.Bold);
            textbox.Font = f;
            textbox.Text = "";
            textbox.TextAlign = HorizontalAlignment.Center;
            UsedGroupBox.Controls.Add(textbox);
            return textbox;
        }
        private void PrepareGB(string txt)
        {
            UsedGroupBox.Controls.Clear();
            UsedGroupBox.Text = txt;
        }
        private void StaffMenuLogin()
        {
            PrepareGB("Staff Menu");
            CreateMessageLabel("WelcomeMessage", "Welcome To The Staff Menu", false);
            Button CreateMatchButton = CreateButton("CreateMatchButton", "Create Match");
            Button PostResultsButton = CreateButton("PostResultsButton", "Post Match Results");
            CreateMatchButton.Click += (sender, e) => { MatchCreation(); };
            PostResultsButton.Click += (sender, e) => { PostResultsSelection(); };
        }
        private bool verifyMatchName(TextBox tb)
        {
            string text = tb.Text;
            return !string.IsNullOrWhiteSpace(text) && text.Length <= 20 && text.Length > 2;
        }
        private void ColourTeamTextBox(TextBox tb)
        {
            string text = tb.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                tb.BackColor = Color.White;
            }
            else
            {
                if (verifyMatchName(tb))
                {
                    tb.BackColor = Color.LightGreen;
                }
                else
                {
                    tb.BackColor = Color.LightCoral;
                }
            }

        }
        private void MatchNameVerifyMessage(TextBox tb1, TextBox tb2, Label msg)
        {

            ColourTeamTextBox(tb1);
            ColourTeamTextBox(tb2);
            msg.Text = verifyMatchName(tb1) && verifyMatchName(tb2) ? "" : "Both team names must be between 1-20 characters and cannot be blank";

        }
        private void MatchCreation()
        {
            PrepareGB("Match Creation");
            CreateMessageLabel("T1Label", "Enter Team 1 Name", false);
            TextBox t1tb = CreateTextbox("Team1TextBox");
            CreateMessageLabel("T1Label", "Enter Team 2 Name", false);
            TextBox t2tb = CreateTextbox("Team2TextBox");
            Label msgLabel = CreateMessageLabel("ErrorMessageLabel", "", false);
            Button CreateMatchButton = CreateButton("CreateMatchButton", "Create Match");

            t1tb.TextChanged += (sender, e) => { MatchNameVerifyMessage(t1tb, t2tb, msgLabel); };
            t2tb.TextChanged += (sender, e) => { MatchNameVerifyMessage(t1tb, t2tb, msgLabel); };

            CreateMatchButton.Click += (sender, e) =>
            {
                if (verifyMatchName(t1tb) && verifyMatchName(t2tb))
                {
                    Program.CreateMatch(t1tb.Text, t2tb.Text);
                    t1tb.Text = "";
                    t2tb.Text = "";
                    msgLabel.Text = "Match Created!";
                }
            };

            Button BackButton = CreateButton("BackButton", "Return To Staff Menu");
            BackButton.Click += (sender, e) => { StaffMenuLogin(); };
        }
        private void PostResultsSelection()
        {
            PrepareGB("Post Results - Match Selection");
            for (int i = 0; i < Matches.Count; i++)
            {

                Match match = Matches[i];
                Debug.WriteLine(match.matchID);
                if (!match.isFinished)
                {
                    Button matchbtn = CreateButton(match.matchID, $"{match.FormatMatchNoScore()} - Click To Post");
                    matchbtn.Click += (sender, e) => { PostResultsMenu(match); };
                }

            }
            if (UsedGroupBox.Controls.Count == 0)
            {
                CreateMessageLabel("NoMatchesToBetOn", "There are currently no matches to post the results for.", false);
            }
            Button BackButton = CreateButton("BackButton", "Return To Staff Menu");
            BackButton.Click += (sender, e) => { StaffMenuLogin(); };

        }
        private bool verifyScore(TextBox tb)
        {
            string text = tb.Text;
            bool valid = false;
            if (int.TryParse(text, out int number))
            {
                if (number >= 0)
                {
                    valid = true;
                }
            }
            return valid;
        }
        private void PostResultsMenu(Match match)
        {
            if (match != null)
            {
                PrepareGB($"Post Results for {match.FormatMatchNoScore()}");
                CreateMessageLabel("T1Label", $"Enter {match.team1} Score", false);
                TextBox t1tb = CreateTextbox("Team1TextBox");
                CreateMessageLabel("T1Label", $"Enter {match.team2} Score", false);
                TextBox t2tb = CreateTextbox("Team2TextBox");

                Button PublishMatchButton = CreateButton("PublishMatchButton", "Post");
                PublishMatchButton.Click += (sender, e) =>
                {
                    if (verifyScore(t1tb) && verifyScore(t2tb))
                    {
                        //todo post match

                        Program.PayoutBetsOnMatch(Convert.ToInt32(t1tb.Text), Convert.ToInt32(t2tb.Text), match.matchID);
                        PostResultsSelection();

                    }
                };

            }
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ViewBetsButton_Click(object sender, EventArgs e)
        {
            PrepareGB("Active Bets");
            for (int i = 0; i < user.Bets.Count; i++)
            {
                Bet bet = user.Bets[i];
                Match match = bet.GetMatch(Matches);
                if (!match.isFinished)
                {
                    CreateMessageLabel(match.matchID, $"{match.FormatMatchNoScore()} : Predicted {bet.score1} - {bet.score2} on a £{bet.wageredAmount} bet.", true);
                }
            }
            if (UsedGroupBox.Controls.Count == 0)
            {
                CreateMessageLabel("NoActiveBets", "No Active Bets Found", false);
            }
        }

        private void ViewMatchesButton_Click(object sender, EventArgs e)
        {
            PrepareGB("View Matches");
            Debug.WriteLine(Matches.Count);
            for (int i = 0; i < Matches.Count; i++)
            {

                Match match = Matches[i];
                Debug.WriteLine(match.matchID);
                CreateMessageLabel(match.matchID, match.FormatMatch(), true);
            }
        }

        private void BetScreen(Match match)
        {
            PrepareGB($"Betting on {match.FormatMatchNoScore()}");
            CreateMessageLabel("PredictionMsg", $"Enter your predictions", false);
            CreateMessageLabel("T1Label", $"Enter {match.team1} Score", false);
            TextBox t1tb = CreateTextbox("Team1TextBox");
            CreateMessageLabel("T1Label", $"Enter {match.team2} Score", false);
            TextBox t2tb = CreateTextbox("Team2TextBox");
            CreateMessageLabel("T1Label", "Enter Your Wager", false);

            TextBox wagertb = CreateTextbox("Team2TextBox");

            Button PlaceBetButton = CreateButton("ConfirmPredictions", "Place Bet");
            PlaceBetButton.Click += (sender, e) =>
            {
                if (verifyScore(t1tb) && verifyScore(t2tb))
                {
                    //todo verify deposit
                    string wager = wagertb.Text;
                    if (float.TryParse(wager, out float number))
                    {
                        if (user.balance - number >= 0 && number > 0)
                        {
                            Program.PlaceBet(match, Convert.ToInt32(t1tb.Text), Convert.ToInt32(t2tb.Text), number);
                            PrepareGB("");
                        }
                    }

                }
            };
        }

        private void PlaceBets_Click(object sender, EventArgs e)
        {
            PrepareGB("Place Bets");
            for (int i = 0; i < Matches.Count; i++)
            {

                Match match = Matches[i];
                Debug.WriteLine(match.matchID);
                if (!match.isFinished)
                {
                    Button betbutton = CreateButton(match.matchID, match.FormatMatchNoScore());
                    betbutton.Click += (sender, e) => { BetScreen(match); };
                }

            }
            if (UsedGroupBox.Controls.Count == 0)
            {
                CreateMessageLabel("NoMatchesToBetOn", "There are currently no matches to bet on.", false);
            }
        }

        private void BetHistoryButton_Click(object sender, EventArgs e)
        {
            PrepareGB("Bet History");
            for (int i = 0; i < user.Bets.Count; i++)
            {
                Bet bet = user.Bets[i];
                Match match = bet.GetMatch(Matches);
                if (match.isFinished)
                {
                    CreateMessageLabel(match.matchID, $"{match.FormatMatch()} : Predicted {bet.score1} - {bet.score2} on a £{bet.wageredAmount} bet, got £{bet.BetResultCalculator(match)} back.", true);
                }
            }
            if (UsedGroupBox.Controls.Count == 0)
            {
                CreateMessageLabel("NoBetHistory", "No Bet History Found", false);
            }

        }

        private void StaffMenuButton_Click(object sender, EventArgs e)
        {
            PrepareGB("Staff Menu Log In");
            CreateMessageLabel("StaffPasswordLabel", "Enter Staff Password", false);
            TextBox textbox = CreateTextbox("StaffPasswordTextBox");
            Button StaffPasswordButton = CreateButton("StaffPasswordButton", "Submit");
            StaffPasswordButton.Click += (sender, e) =>
            {
                if (textbox.Text == staffpassword)
                {
                    // todo staff login
                    StaffMenuLogin();
                }
                else
                {
                    textbox.Text = "";
                }
            };

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Program.LogOut();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            Program.OpenDepositForm();
        }
    }
}
