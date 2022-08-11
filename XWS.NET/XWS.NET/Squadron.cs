using System.Text.Json;
using System.Text.Json.Serialization;

namespace XWS.NET
{
    public class Squadron
    {
        [JsonPropertyName("faction")]
        public string Faction { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("pilots")]
        public List<Pilot> Pilots { get; set; }
    }
}