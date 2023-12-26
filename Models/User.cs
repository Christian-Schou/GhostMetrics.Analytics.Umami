using System.Text.Json.Serialization;

namespace UmamiNet.Models;

public class User
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    [JsonPropertyName("username")]
    public string Username { get; set; }
    
    [JsonPropertyName("isAdmin")]
    public bool IsAdmin { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
}