using System.Text.Json.Serialization;

namespace XWS.NET;

public class Pilot
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("ship")]
    public string Ship { get; set; }
}