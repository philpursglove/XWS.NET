using Newtonsoft.Json;

namespace XWSNET;

public class Pilot : IEquatable<Pilot>
{
    [JsonProperty(PropertyName = "name")]

    public string Name { get; set; }

    [JsonProperty(PropertyName = "ship")]

    public string Ship { get; set; }

    [JsonProperty(PropertyName = "upgrades")]

    public Upgrades Upgrades { get; set; }

    public bool Equals(Pilot comparePilot)
    {
        return (String.Equals(this.Name, comparePilot.Name, StringComparison.InvariantCultureIgnoreCase) &&
                String.Equals(this.Ship, comparePilot.Ship, StringComparison.InvariantCultureIgnoreCase) &&
                this.Upgrades.Equals(comparePilot.Upgrades));
    }

    public string Title()
    {
        if (Upgrades.Title.Any())
        {
            return Upgrades.Title.First();
        }
        return String.Empty;
    }

    public string Configuration()   
    {
        if (Upgrades.Configuration.Any())
        {
            return Upgrades.Configuration.First();
        }
        return String.Empty;
    }
}