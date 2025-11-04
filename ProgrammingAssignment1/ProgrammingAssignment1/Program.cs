
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

//vital values
string userdatafile = "userdata.json";
string matchesfile = "matches.json";

float maxdeposit = 50f;

int passwordMinLength = 8;
int passwordMaxLength = 16;
int passwordMinDigits = 2;

int usernameMaxLen = 10;
int usernameMinLen = 4;

string StaffMenuPassword = "passwordthosewhoknow";

User LoggedInUser = null;

List<User> Users = new List<User>();
List<Match> Matches = new List<Match>();

//functions
void CheckFile(string file)
{
    if (!File.Exists(file))
    {
        File.Create(file).Close();
    }
}
void CheckOrCreateFiles()
{
    CheckFile(userdatafile);
    CheckFile(matchesfile);
}
bool UsernameInUse(string username)
{
    foreach (User user in Users)
    {
        if (user.username == username)
        {
            return true;
        }
    }
    return false;
}
User GetUserFromUsername(string username)
{
    User userpoiner = null;
    foreach (User user in Users)
    {
        if (user.username == username)
        {
            userpoiner = user;
        }
    }
    return userpoiner;
}
string ValidateName(string txt)
{
    string name = "";
    bool valid = false;
    while (!valid)
    {
        name = Prompt(txt);
        if (name.Length >= 1)
        {
            valid = true;
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    valid = false;
                }
            }
        }
        if (!valid)
        {
            Console.WriteLine("Invalid name, use only letters and be at least one character long.");
        }
    }
    return name;
}
string UsernameValidationCheck()
{
    bool valid = false;
    string username = "";
    while (!valid)
    {
        username = Prompt("Enter your username");
        bool invalidchar = false;
        if (username.Length >= usernameMinLen && username.Length <= usernameMaxLen)//len check
        {
            for (int i = 0; i < username.Length; i++)
            {
                if (!(char.IsDigit(username[i]) || char.IsLetter(username[i])))// charcheck
                {
                    invalidchar = true;
                }
              
            }
            valid = (!invalidchar);//setval
        }
        if (valid)
        {
            if (UsernameInUse(username))//check if taken
            {
                valid = false;
                Console.WriteLine($"\"{username}\" is already taken, try another.");
            }
        }
        else//if not valid error message
        {
            Console.WriteLine($"Username must be between {usernameMinLen} and {usernameMaxLen} characters and only contain letters and numbers.\nTry again.");
            
        }
    }
    return username;
}
string PasswordValidationCheck()
{
    bool valid = false;
    string password = "";
    while (!valid)
    {
        password = Prompt("Enter your password");
        bool ws = false;
        if (password.Length >= passwordMinLength && password.Length <= passwordMaxLength)//len check
        {
            int numCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))//digit check
                {
                    numCount++;
                }
                else if (char.IsWhiteSpace(password[i]))//space check
                {
                    ws = true;
                }
            }
            valid = (numCount >= passwordMinDigits && !ws);//setval
        }
        if (!valid)//if not valid error message
        {
            Console.WriteLine($"Password must be between {passwordMinLength} and {passwordMaxLength} characters and contain at least {passwordMinDigits} digits with no spaces.\nTry again.");
        }
    }
    return password;
}
string Prompt(string txt)
{
    Console.WriteLine(txt);
    return Console.ReadLine();
}
void SaveAllUsers()
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
void SaveAllMatches()
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
void Initialise()
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
            if (potentialmatch.Length > 0)
            {
                Matches.Add(JsonSerializer.Deserialize<Match>(potentialmatch));
            }
        }
    }
}
bool isLoggedIn()
{
    return LoggedInUser != null;
}
//MENU FUNCTIONS
void CreateAccount()
{
    string username = UsernameValidationCheck();
    string fname = ValidateName("Enter your first name:");
    string lname = ValidateName("Enter your last name:");
    Console.WriteLine($"Create your password, it must...\n1) Be between {passwordMinLength} and {passwordMaxLength} characters \n2) Contain at least {passwordMinDigits} digits\n3) Contain no spaces");
    string password = PasswordValidationCheck();
    User user = new User(username, fname, lname, password);
    Users.Add(user);
    SaveAllUsers();
}
void LogIn()
{
    string username = Prompt("Enter your username: ");
    if (UsernameInUse(username))
    {
        User user = GetUserFromUsername(username);
        string password = Prompt("Enter your password: ");
        if (user.password == password)
        {
            LoggedInUser = user;
            Console.WriteLine($"Welcome back {user.fname} {user.lname}!");
        }
        else
        {
            Console.WriteLine("Incorrect Password.");
        }
    }
    else
    {
        Console.WriteLine("Account Not Found.");
    }
}
void PayoutBetsOnMatch(Match match)
{
    if (File.Exists(matchesfile) && File.Exists(matchesfile))
    {
        if (!match.isFinished)
        {
            match.isFinished = true;
            foreach(User user in Users)
            {
                foreach(Bet bet in user.Bets)
                {
                    Match betmatch = bet.GetMatch(Matches);
                    if (betmatch==match)
                    {
                        //Correct match
                        float payout = bet.BetResultCalculator(match);
                        Console.WriteLine($"Paid {payout} to {user.username}");
                        user.balance += payout;
                    }
                }
            }
            SaveAllMatches();
            SaveAllUsers();
        }
    }
    else
    {
        Console.WriteLine("File error, fixing...");
        CheckOrCreateFiles();
        Console.WriteLine("Fixed!");
    }
    
}
void CreateMatch()
{
    string team1 = Prompt("Enter the name of Team 1:");
    string team2 = Prompt("Enter the name of Team 2:");
    Match match = new Match($"MATCH_{Matches.Count}",team1,team2);
    Matches.Add(match);
    SaveAllMatches();
}
void PostResults()
{
    Console.WriteLine("AVALIABLE MATCHES\n==========");
    Dictionary<string, Match> activeMatches = new Dictionary<string, Match>();
    int indexer = 0;
    for (int i = 0; i < Matches.Count; i++)
    {
        Match match = Matches[i];
        if (!match.isFinished)
        {
            indexer++;
            activeMatches.Add(indexer.ToString(), match);
            Console.WriteLine($"{indexer}) {match.FormatMatch()}");
        }
    }
    string matchChoice = Prompt("Enter the number of the match you want to post the results for:");
    if (activeMatches.ContainsKey(matchChoice))
    {
        Match selectedMatch = activeMatches[matchChoice];
        int score1 = int.Parse(Prompt($"Enter the score for {selectedMatch.team1}:")); //TODO input validation
        int score2 = int.Parse(Prompt($"Enter the score for {selectedMatch.team2}:"));

        selectedMatch.score1 = score1;
        selectedMatch.score2 = score2;
        PayoutBetsOnMatch(selectedMatch);
    }
}
//main
CheckOrCreateFiles();
Initialise();
bool looping = true;
while (looping)
{
    Console.WriteLine("WELCOME TO BET367\n=========");
    if (isLoggedIn())
    {
        Console.WriteLine($"Logged in as: {LoggedInUser.username} | Balance: £{LoggedInUser.balance}");
    }
    string choice = Prompt("1) Create Account\n2) Log In\n3) Make Bet\n4) View Your Bets\n5) View Matches\n6) Staff Menu\n7) Exit\nEnter Here:");
    
    switch(choice)
    {
        case "1":
            CreateAccount();
            break;
        case "2":
            LogIn();
            break;
        case "3":
            if (isLoggedIn())
            {
                Console.WriteLine("AVALIABLE MATCHES\n==========");
                Dictionary<string, Match> activeMatches = new Dictionary<string, Match>();
                int indexer = 0;
                for (int i = 0; i < Matches.Count; i++)
                {
                    Match match = Matches[i];
                    if (!match.isFinished)
                    {
                        indexer++;
                        activeMatches.Add(indexer.ToString(), match);
                        Console.WriteLine($"{indexer}) {match.FormatMatch()}");
                    }
                }
                string matchChoice = Prompt("Enter the number of the match you want to bet on:");
                if (activeMatches.ContainsKey(matchChoice))
                {
                    Match selectedMatch = activeMatches[matchChoice];
                    int predictedScore1 = int.Parse(Prompt($"Enter your predicted score for {selectedMatch.team1}:")); //TODO input validation
                    int predictedScore2 = int.Parse(Prompt($"Enter your predicted score for {selectedMatch.team2}:"));
                    float wagerAmount = float.Parse(Prompt($"Current Balance: £{LoggedInUser.balance}\nEnter the amount you want to wager:"));
                    if (wagerAmount > 0 && wagerAmount <= LoggedInUser.balance)
                    {
                        LoggedInUser.balance -= wagerAmount;
                        Bet bet = new Bet(selectedMatch.matchID, predictedScore1, predictedScore2, wagerAmount);
                        LoggedInUser.Bets.Add(bet);
                        SaveAllUsers();
                    }
                }
            }
            else
            {
                Console.WriteLine("You must be logged in to make a bet.");
            }
            break;
        case "4":
            if (isLoggedIn())
            {
                List<Bet> activeBets = new List<Bet>();
                List<Bet> finishedBets = new List<Bet>();
                for (int i = 0; i < LoggedInUser.Bets.Count; i++)
                {
                    Bet bet = LoggedInUser.Bets[i];
                    Match match = bet.GetMatch(Matches);
                    if (match != null)
                    {
                        if (match.isFinished)
                        {
                            finishedBets.Add(bet);
                        }
                        else
                        {
                            activeBets.Add(bet);
                        }
                    }
                }
                //YEAH
                Console.WriteLine("ACTIVE BETS\n=======");
                for (int i = 0; i < activeBets.Count; i++)
                {
                    Bet bet = activeBets[i];
                    Match match = bet.GetMatch(Matches);
                    if (match != null)
                    {
                        Console.WriteLine($"{i+1}) {match.FormatMatch()}: Predicted {bet.score1} - {bet.score2} on a £{bet.wageredAmount} bet.");
                    }
                }
                Console.WriteLine("PREVIOUS BETS\n=======");
                for (int i = finishedBets.Count-1; i >=0 ; i--)
                {
                    Bet bet = finishedBets[i];
                    Match match = bet.GetMatch(Matches);
                    if (match != null)
                    {
                        Console.WriteLine($"{finishedBets.Count-i}) {match.FormatMatch()} : Predicted {bet.score1} - {bet.score2} on a £{bet.wageredAmount} bet, got £{bet.BetResultCalculator(match)} back.");
                    }
                }
            }
            else
            {
                Console.WriteLine("You must be logged in to view your bets.");
            }
            break;
        case "5":
            Console.WriteLine("MATCHES\n==========");
            for(int i = 0; i < Matches.Count; i++)
            {
                Match match = Matches[i];
                Console.WriteLine($"{i+1}) {match.FormatMatch()}");
            }
            Console.WriteLine("==========");
            break;
        case "6":
            if (isLoggedIn())
            {
                string password = Prompt("Enter the staff password:");
                if (password == StaffMenuPassword)
                {
                    choice = Prompt("WELCOME TO BET367 ADMIN PANEL\n===========\n1) Add Match\n2) Post Results\nEnter Here:");
                    switch (choice)
                    {
                        case "1":
                            CreateMatch();
                            break;
                        case "2":
                            PostResults();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Password.");
                }
            }
            else
            {
                Console.WriteLine("You must be logged in to view staff menu");
            }
            break;
        case "7":
            looping = false;
            break;
        default:
            Console.WriteLine("Invalid choice, try again.");
            break;
    }
    Prompt(looping?"Press enter to continue...":"Goodbye!");
    Console.Clear();
}
//classes
class User
{
    [JsonInclude] public string username;
    [JsonInclude] public string fname;
    [JsonInclude] public string lname;
    [JsonInclude] public string password;
    [JsonInclude] public float balance;
    [JsonInclude] public List<Bet> Bets = new List<Bet>();
    public User(string username, string fname, string lname, string password)
    {
        this.username = username;
        this.fname = fname;
        this.lname = lname;
        this.password = password;
        this.balance = 0.0f;
    }
}
class Match
{
    [JsonInclude] public string matchID;
    [JsonInclude] public string team1;
    [JsonInclude] public string team2;
    [JsonInclude] public int score1;
    [JsonInclude] public int score2;
    [JsonInclude] public bool isFinished = false;
    public Match(string matchID, string team1, string team2)
    {
        this.matchID = matchID;
        this.team1 = team1;
        this.team2 = team2;
        this.score1 = 0;
        this.score2 = 0;
    }
    public string FormatMatch()
    {
        return ($"{team1} VS {team2} = {(isFinished ? $"{score1} - {score2}" : "Awaiting Kickoff")}");
    }
}
class Bet
{
    [JsonInclude] public string matchID;
    [JsonInclude] public int score1;
    [JsonInclude]public int score2;
    [JsonInclude] public float wageredAmount;
    public Bet(string matchID, int score1, int score2, float wageredAmount)
    {
        this.matchID = matchID;
        this.score1 = score1;
        this.score2 = score2;
        this.wageredAmount = wageredAmount;
    }
    public Match GetMatch(List<Match> matches)
    {
        foreach (Match match in matches)
        {
            if (match.matchID == matchID)
            {
                return match;
            }
        }
        return null;
    }
    public float BetResultCalculator(Match match)
    {
        int accscore1 = match.score1;
        int accscore2 = match.score2;
        if (accscore1 == score1 && accscore2 == score2)
        {
            //exact
            return wageredAmount * 3f;
        }
        else if ((accscore1 > accscore2 && score1 > score2) || (accscore1 < accscore2 && score1 < score2) || (accscore1 == accscore2 && score1 == score2))
        {
            //correct outcome
            return wageredAmount * 1.5f;
        }
        return 0;
    }
}