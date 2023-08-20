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
        return Upgrades.Title.FirstOrDefault();
    }

    public string Configuration()
    {
        return Upgrades.Configuration.FirstOrDefault();
    }

    public string Astromech()
    {
        return Upgrades.Astromech.FirstOrDefault();
    }

    public IEnumerable<string> Cannons()
    {
        return Upgrades.Cannons.OrderBy(c => c);
    }

    public IEnumerable<string> Cargo()
    {
        return Upgrades.Cargo.OrderBy(c => c);
    }

    public IEnumerable<string> Commands()
    {
        return Upgrades.Commands.OrderBy(c => c);
    }

    public IEnumerable<string> Crew()
    {
        return Upgrades.Crew.OrderBy(c => c);
    }

    public IEnumerable<string> Devices()
    {
        return Upgrades.Devices.OrderBy(d => d);
    }

    public IEnumerable<string> ForcePowers()
    {
        return Upgrades.ForcePowers.OrderBy(f => f);
    }

    public string Gunner()
    {
        return Upgrades.Gunners.FirstOrDefault();
    }

    public IEnumerable<string> Illicit()
    {
        return Upgrades.Illicit.OrderBy(i => i);
    }

    public IEnumerable<string> Hardpoints()
    {
        return Upgrades.Hardpoints.OrderBy(h => h);
    }

    public IEnumerable<string> Missiles()
    {
        return Upgrades.Missiles.OrderBy(m => m);
    }

    public IEnumerable<string> Modifications()
    {
        return Upgrades.Modifications.OrderBy(m => m);
    }

    public IEnumerable<string> Sensors()
    {
        return Upgrades.Sensors.OrderBy(s => s);
    }

    public IEnumerable<string> Talents()
    {
        return Upgrades.Talents.OrderBy(t => t);
    }

    public IEnumerable<string> Teams()
    {
        return Upgrades.Teams.OrderBy(t => t);
    }

    public IEnumerable<string> Tech()
    {
        return Upgrades.Tech.OrderBy(t => t);
    }

    public IEnumerable<string> Torpedoes()
    {
        return Upgrades.Torpedoes.OrderBy(t => t);
    }

    public IEnumerable<string> Turrets()
    {
        return Upgrades.Turrets.OrderBy(t => t);
    }

    public IEnumerable<string> TacticalRelays()
    {
        return Upgrades.TacticalRelays.OrderBy(t => t);
    }
}