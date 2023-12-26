namespace GhostMetrics.Analytics.Umami.Models;

public class WebsiteStats
{
    public Stat Pageviews { get; set; }
    public Stat Uniques { get; set; }
    public Stat Bounces { get; set; }
    public Stat TotalTime { get; set; }
}