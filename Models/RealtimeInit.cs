namespace GhostMetrics.Analytics.Umami.Models;

public class RealtimeInit
{
    public List<Website> Websites { get; set; }
    public string Token { get; set; }
    public RealtimeUpdate Data { get; set; }
}