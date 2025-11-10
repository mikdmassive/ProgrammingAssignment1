using System.Text.Json.Serialization;

public class User
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