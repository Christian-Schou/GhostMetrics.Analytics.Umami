namespace UmamiNet.Models;

public class Website
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public int RevId { get; set; }
    public string Name { get; set; }
    public string Domain { get; set; }
    public string ShareId { get; set; }
    public DateTime CreatedAt { get; set; }
}