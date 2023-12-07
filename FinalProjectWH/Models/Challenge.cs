namespace FinalProjectWH.Models
{
public class Challenge
{
    public int ChallengeId { get; set; }
    public string ChallengeName { get; set; }
    public ICollection<Progress> Progress { get; set; }
}
}