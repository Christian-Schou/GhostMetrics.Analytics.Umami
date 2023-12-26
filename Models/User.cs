namespace GhostMetrics.Analytics.Umami.Models;

public class User
{
    public string Id { get; set; }
    public string Username { get; set; }
    public bool IsAdmin { get; set; }
    public DateTime CreatedAt { get; set; }
}