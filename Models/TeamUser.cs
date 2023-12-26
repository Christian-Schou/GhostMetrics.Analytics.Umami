namespace GhostMetrics.Analytics.Umami.Models;

public class TeamUser
{
    public string Id { get; set; }
    public string TeamId { get; set; }
    public string UserId { get; set; }
    public string Role { get; set; }
    public DateTime CreatedAt { get; set; }
}