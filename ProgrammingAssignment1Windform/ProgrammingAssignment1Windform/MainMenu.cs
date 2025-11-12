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
        void CreateMessageLabel(string name, string txt, bool border)
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
            CreateMatchButton.Click += (sender, e) => { MatchCreation(); } ;
            PostResultsButton.Click += (sender, e) => { PostResultsSelection(); };
        }

        private void MatchCreation()
        {
            PrepareGB("Match Creation");
            CreateMessageLabel("T1Label", "Enter Team 1 Name", false);
            TextBox t1tb = CreateTextbox("Team1TextBox");
            CreateMessageLabel("T1Label", "Enter Team 2 Name", false);
            TextBox t2tb = CreateTextbox("Team2TextBox");
            Button CreateMatchButton = CreateButton("CreateMatchButton", "Create Match");
            bool verify(TextBox tb)
            {
                string text = tb.Text;
                return string.IsNullOrWhiteSpace(text) && text.Length <= 10;
            }
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
            
        }
        private void PostResultsMenu(Match match)
        {
            if (match == null)
            {
                PrepareGB($"Post Results for {match.FormatMatchNoScore()}");
                CreateMessageLabel("T1Label",$"Enter {match.team1} Score", false);
                TextBox t1tb = CreateTextbox("Team1TextBox");
                CreateMessageLabel("T1Label", $"Enter {match.team2} Score", false);
                TextBox t2tb = CreateTextbox("Team2TextBox");
                bool verify(TextBox tb)
                {
                    string text = tb.Text;
                    return int.TryParse(text, out int number);
                }
                Button PublishMatchButton = CreateButton("PublishMatchButton", "Post");
                PublishMatchButton.Click += (sender, e) =>
                {
                    if (verify(t1tb) && verify(t2tb))
                    {
                        //todo post match

                        Program.PayoutBetsOnMatch(Convert.ToInt32(t1tb.Text), Convert.ToInt32(t2tb.Text), match.matchID);
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

        private void PlaceBets_Click(object sender, EventArgs e)
        {
            PrepareGB("Place Bets");
            for (int i = 0; i < Matches.Count; i++)
            {

                Match match = Matches[i];
                Debug.WriteLine(match.matchID);
                if (!match.isFinished)
                {
                    CreateButton(match.matchID, match.FormatMatchNoScore());
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
            Button StaffPasswordButton =  CreateButton("StaffPasswordButton","Submit");
            StaffPasswordButton.Click += (sender, e) =>
            {
                if(textbox.Text == staffpassword)
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
        private void SelectBet(Button sender, EventArgs e)
        {

        }
    }
}
