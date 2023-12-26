using System.Text.Json.Serialization;

namespace UmamiNet.Models;

public class UserSearchParams : SearchParams
{
    [JsonPropertyName("teamId")]
    public string TeamId { get; set; }
}