using System.Text.Json.Serialization;

public class Match
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
        return ($"{FormatMatchNoScore()} = {(isFinished ? $"{score1} - {score2}" : "Awaiting Kickoff")}");
    }
    public string FormatMatchNoScore()
    {
        return ($"{team1} VS {team2}");
    }
}