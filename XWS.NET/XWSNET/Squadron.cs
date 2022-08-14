using Newtonsoft.Json;

namespace XWSNET
{
    public class Squadron
    {
        [JsonProperty(PropertyName = "faction")]
        public string Faction { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "pilots")]

        public List<Pilot> Pilots { get; set; }
    }
}