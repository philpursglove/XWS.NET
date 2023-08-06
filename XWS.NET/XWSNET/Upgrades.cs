using System.Text;
using Newtonsoft.Json;

namespace XWSNET;

public class Upgrades : IEquatable<Upgrades>
{
    public Upgrades()
    {
        Astromech = new List<string>();
        Cannons = new List<string>();
        Cargo = new List<string>();
        Commands = new List<string>();
        Configuration = new List<string>();
        Crew = new List<string>();
        Devices = new List<string>();
        ForcePowers = new List<string>();
        Gunners = new List<string>();
        Hardpoints = new List<string>();
        Illicit = new List<string>();
        Missiles = new List<string>();
        Modifications = new List<string>();
        Sensors = new List<string>();
        Talents = new List<string>();
        Teams = new List<string>();
        Tech = new List<string>();
        Title = new List<string>();
        Torpedoes = new List<string>();
        Turrets = new List<string>();
        TacticalRelays = new List<string>();
    }

    [JsonProperty(PropertyName = "astromech")]
    public List<string> Astromech { get; set; }

    [JsonProperty(PropertyName = "cannon")]
    public List<string> Cannons { get; set; }

    [JsonProperty(PropertyName = "cargo")]
    public List<string> Cargo { get; set; }

    [JsonProperty(PropertyName = "command")]
    public List<string> Commands { get; set; }

    [JsonProperty(PropertyName = "configuration")]
    public List<string> Configuration { get; set; }

    [JsonProperty(PropertyName = "crew")]
    public List<string> Crew { get; set; }

    [JsonProperty(PropertyName = "device")]
    public List<string> Devices { get; set; }

    [JsonProperty(PropertyName = "force")]
    public List<string> ForcePowers { get; set; }

    [JsonProperty(PropertyName = "gunner")]
    public List<string> Gunners { get; set; }

    [JsonProperty(PropertyName = "hardpoint")]
    public List<string> Hardpoints { get; set; }

    [JsonProperty(PropertyName = "illicit")]
    public List<string> Illicit { get; set; }

    [JsonProperty(PropertyName = "missile")]
    public List<string> Missiles { get; set; }

    [JsonProperty(PropertyName = "modification")]
    public List<string> Modifications { get; set; }

    [JsonProperty(PropertyName = "sensor")]
    public List<string> Sensors { get; set; }

    [JsonProperty(PropertyName = "talent")]
    public List<string> Talents { get; set; }

    [JsonProperty(PropertyName = "team")]
    public List<string> Teams { get; set; }

    [JsonProperty(PropertyName = "tech")]
    public List<string> Tech { get; set; }

    [JsonProperty(PropertyName = "title")]
    public List<string> Title { get; set; }

    [JsonProperty(PropertyName = "torpedo")]
    public List<string> Torpedoes { get; set; }

    [JsonProperty(PropertyName = "turret")]
    public List<string> Turrets { get; set; }

    [JsonProperty(PropertyName = "tacticalrelay")]
    public List<string> TacticalRelays { get; set; }

    public bool Equals(Upgrades compareUpgrades)
    {
         return this.GetHashCode() == compareUpgrades.GetHashCode();
    }

    public override int GetHashCode()
    {
        StringBuilder upgradesString = new StringBuilder();
        upgradesString.Append(String.Join("", this.Astromech.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Cannons.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Cargo.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Commands.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Configuration.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Crew.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Devices.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.ForcePowers.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Gunners.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Hardpoints.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Illicit.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Missiles.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Modifications.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Sensors.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Talents.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Teams.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Tech.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Title.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Torpedoes.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.Turrets.OrderBy(s => s).Select(s => s.ToLower())));
        upgradesString.Append(String.Join("", this.TacticalRelays.OrderBy(s => s).Select(s => s.ToLower())));

        return upgradesString.ToString().GetHashCode();
    }
}