using System.Diagnostics;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace ProgrammingAssignment1Windform
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        static void CheckFile(string file)
        {
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }
        }
        static void CheckOrCreateFiles()
        {
            CheckFile(userdatafile);
            CheckFile(matchesfile);
        }

        static string userdatafile = "userdata.json";
        static string matchesfile = "matches.json";
        static List<User> Users = new List<User>();
        static List<Match> Matches = new List<Match>();

        static User user = null;

        static LoginScreen loginScreen = null;

        static MainMenu mainMenu = null;
        static DepositForm depositForm = null;
        static void Initialise()
        {
            Users.Clear();
            Matches.Clear();
            //user
            if (File.Exists(userdatafile))
            {
                List<string> data = File.ReadAllLines(userdatafile).ToList();
                foreach (string potentialuser in data)
                {
                    if (potentialuser.Length > 0)
                    {
                        Users.Add(JsonSerializer.Deserialize<User>(potentialuser));
                    }
                }
            }
            //matches
            if (File.Exists(matchesfile))
            {
                List<string> data = File.ReadAllLines(matchesfile).ToList();
                foreach (string potentialmatch in data)
                {
                    Debug.WriteLine(potentialmatch);
                    if (potentialmatch.Length > 0)
                    {
                        Matches.Add(JsonSerializer.Deserialize<Match>(potentialmatch));
                    }
                }
            }
        }
        static void SaveAllUsers()
        {
            string data = "";
            if (File.Exists(userdatafile))
            {
                foreach (User user in Users)
                {

                    data += JsonSerializer.Serialize(user) + "\n";
                }
            }
            File.WriteAllText(userdatafile, data);
        }

        static Match GetMatchFromID(string id)
        {
            Match matchPointer = null;
            foreach (Match match in Matches)
            {
                if (match.matchID == id)
                {
                    matchPointer = match;
                }
            }
            return matchPointer;
        }
        private static void UpdateAllScreens()
        {
            mainMenu.UpdateStats(user, Matches);
            if (depositForm != null)
            {
                depositForm.UpdateStats(user);
            }
        }
        public static void CreateAccount(string username, string fname, string lname, string password)
        {
            User newuser = new User(username, fname, lname, password);
            Users.Add(newuser);
            SaveAllUsers();
            Login(newuser);
        }
        public static void CreateMatch(string team1, string team2)
        {
            Match match = new Match($"MATCH_{Matches.Count}", team1, team2);
            Matches.Add(match);
            SaveAllMatches();
            UpdateAllScreens();
        }
       
        public static void PlaceBet(Match selectedMatch, int predictedScore1, int predictedScore2, float wagerAmount)
        {
            user.balance -= wagerAmount;
            Bet bet = new Bet(selectedMatch.matchID, predictedScore1, predictedScore2, wagerAmount);
            user.Bets.Add(bet);
            SaveAllUsers();
            UpdateAllScreens();
        }
        public static void PayoutBetsOnMatch(int score1,int score2,string matchid)
        {
            if (File.Exists(matchesfile) && File.Exists(userdatafile))
            {
                Match match = GetMatchFromID(matchid);
                if (match!=null)
                {
                    if (!match.isFinished)
                    {
                        match.score1 = score1;
                        match.score2 = score2;
                        match.isFinished = true;
                        foreach (User user in Users)
                        {
                            foreach (Bet bet in user.Bets)
                            {
                                Match betmatch = bet.GetMatch(Matches);
                                if (betmatch == match)
                                {
                                    //Correct match
                                    float payout = bet.BetResultCalculator(match);

                                    user.balance += payout;
                                }
                            }
                        }

                        SaveAllMatches();
                        SaveAllUsers();
                        if (mainMenu != null)
                        {
                            mainMenu.UpdateStats(user, Matches);
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("File error, fixing...");
                CheckOrCreateFiles();
                Console.WriteLine("Fixed!");
            }

        }
        static void SaveAllMatches()
        {
            string data = "";
            if (File.Exists(matchesfile))
            {
                foreach (Match match in Matches)
                {

                    data += JsonSerializer.Serialize(match) + "\n";
                }
            }
            File.WriteAllText(matchesfile, data);
        }
        
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            CheckOrCreateFiles();
            Initialise();
            ApplicationConfiguration.Initialize();
            loginScreen = new LoginScreen(Users);
            Application.Run(loginScreen);
        }
        public static void Login(User userr)
        {
            Debug.WriteLine(Matches.Count);
            user = userr;
            mainMenu = new MainMenu(user,Matches);//(user, Users, Matches));
            mainMenu.Show();
            
        }
        public static void Deposit(float amount)
        {
            if (user != null)
            {
                user.balance += amount;
                SaveAllUsers();
                UpdateAllScreens();
            }
         
        }
        public static void OpenDepositForm()
        {
            if (depositForm == null)
            {
                depositForm = new DepositForm(user);
            }
            depositForm.Show();
        }
        public static void LogOut()
        {
            user = null;
            mainMenu.Hide();
            if (depositForm != null)
            {
                depositForm.Hide();
    
            }
            loginScreen = new LoginScreen(Users);
            loginScreen.Show();
        }
    }
}