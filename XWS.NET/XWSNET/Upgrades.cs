using Newtonsoft.Json;
using System.Linq;

namespace XWSNET;

public class Upgrades
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
        Teams = new List<string>();
        Tech = new List<string>();
        Title = new List<string>();
        Torpedoes = new List<string>();
        Turrets = new List<string>();
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

    public bool Equals(Upgrades compareUpgrades)
    {
               return this.Astromech.Intersect(compareUpgrades.Astromech).Equals(this.Astromech) &&
                      this.Cannons.Intersect(compareUpgrades.Cannons).Equals(this.Cannons) &&
                      this.Cargo.Intersect(compareUpgrades.Cargo).Equals(this.Cargo) &&
                      this.Commands.Intersect(compareUpgrades.Commands).Equals(this.Commands) &&
                      this.Configuration.Intersect(compareUpgrades.Configuration).Equals(this.Configuration) &&
                      this.Crew.Intersect(compareUpgrades.Crew).Equals(this.Crew) &&
                      this.Devices.Intersect(compareUpgrades.Devices).Equals(this.Devices) &&
                      this.ForcePowers.Intersect(compareUpgrades.ForcePowers).Equals(this.ForcePowers) &&
                      this.Gunners.Intersect(compareUpgrades.Gunners).Equals(this.Gunners) &&
                      this.Hardpoints.Intersect(compareUpgrades.Hardpoints).Equals(this.Hardpoints) &&
                      this.Illicit.Intersect(compareUpgrades.Illicit).Equals(this.Illicit) &&
                      this.Missiles.Intersect(compareUpgrades.Missiles).Equals(this.Missiles) &&
                      this.Modifications.Intersect(compareUpgrades.Modifications).Equals(this.Modifications) &&
                      this.Sensors.Intersect(compareUpgrades.Sensors).Equals(this.Sensors) &&
                      this.Talents.Intersect(compareUpgrades.Talents).Equals(this.Talents) &&
                      this.Teams.Intersect(compareUpgrades.Teams).Equals(this.Teams) &&
                      this.Tech.Intersect(compareUpgrades.Tech).Equals(this.Tech) &&
                      this.Title.Intersect(compareUpgrades.Title).Equals(this.Title) &&
                      this.Torpedoes.Intersect(compareUpgrades.Torpedoes).Equals(this.Torpedoes) &&
                      this.Turrets.Intersect(compareUpgrades.Turrets).Equals(this.Turrets);
    }
    
}