namespace GhostMetrics.Analytics.Umami.Models;

public class RealtimeUpdate
{
    public List<object> Pageviews { get; set; }
    public List<object> Sessions { get; set; }
    public List<object> Events { get; set; }
    public long Timestamp { get; set; }
}