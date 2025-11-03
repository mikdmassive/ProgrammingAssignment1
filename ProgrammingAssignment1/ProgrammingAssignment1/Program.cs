using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
//vital values
string userdatafile = "userdata.json";
string matchesfile = "matches.json";

float maxdeposit = 50f;

int passwordMinLength = 8;
int passwordMaxLength = 16;
int passwordMinDigits = 2;

int usernameMaxLen = 10;
int usernameMinLen = 4;

List<User> Users = new List<User>();
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

void CreateAccount()
{
    string username = UsernameValidationCheck();
    string fname = ValidateName("Enter your first name:");
    string lname = ValidateName("Enter your last name:");
    Console.WriteLine($"Create your password, it must...\n1) Be between {passwordMinLength} and {passwordMaxLength} characters \n2) Contain at least {passwordMinDigits} digits\n3) Contain no spaces");
    string password = PasswordValidationCheck();
    User user = new User(username, fname, lname, password);
    Users.Add(user);
    if (File.Exists(userdatafile))
    {
        string jsonString = JsonSerializer.Serialize(user);
        Console.WriteLine(jsonString);
        File.WriteAllText(userdatafile, jsonString);
    }
}

string Prompt(string txt)
{
    Console.WriteLine(txt);
    return Console.ReadLine();
}
//main
CheckOrCreateFiles();
CreateAccount();
//classes
class User
{
    public string username;
    public string fname;
    public string lname;
    public string password;
    public float balance;
    public List<Bet> Bets = new List<Bet>();
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
    public string matchID;
    public string team1;
    public string team2;
    public int score1;
    public int score2;
    public bool isFinished = false;
    public Match(string matchID, string team1, string team2, int score1, int score2)
    {
        this.matchID = matchID;
        this.team1 = team1;
        this.team2 = team2;
        this.score1 = score1;
        this.score2 = score2;
    }
    public string FormatMatch()
    {
        return ($"{team1} VS {team2}\n {(isFinished ? $"{score1} - {score2}" : "Awaiting Kickoff")}");
    }
}
class Bet
{
    public string matchID;
    public int score1;
    public int score2;
    public float wageredAmount;
    public Bet(string matchID, int score1, int score2, float wageredAmount)
    {
        this.matchID = matchID;
        this.score1 = score1;
        this.score2 = score2;
        this.wageredAmount = wageredAmount;
    }
}