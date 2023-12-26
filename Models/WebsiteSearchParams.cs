namespace UmamiNet.Models;

public class WebsiteSearchParams : SearchParams
{
    public string UserId { get; set; }
    public string TeamId { get; set; }
    public bool? IncludeTeams { get; set; }
}