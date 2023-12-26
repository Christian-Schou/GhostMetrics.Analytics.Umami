namespace GhostMetrics.Analytics.Umami.Models;

public class WebsiteEventData
{
    public string EventName { get; set; }
    public string FieldName { get; set; }
    public int DataType { get; set; }
    public string FieldValue { get; set; }
    public int Total { get; set; }
}