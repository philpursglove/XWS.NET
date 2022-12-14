using Newtonsoft.Json;

namespace XWSNET;

public class Pilot
{
    [JsonProperty(PropertyName = "name")]

    public string Name { get; set; }

    [JsonProperty(PropertyName = "ship")]

    public string Ship { get; set; }

    [JsonProperty(PropertyName = "upgrades")]

    public Upgrades Upgrades { get; set; }
}