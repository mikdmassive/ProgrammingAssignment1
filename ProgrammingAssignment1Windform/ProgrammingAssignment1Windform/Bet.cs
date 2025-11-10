using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

class Bet
{
    [JsonInclude] public string matchID;
    [JsonInclude] public int score1;
    [JsonInclude] public int score2;
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