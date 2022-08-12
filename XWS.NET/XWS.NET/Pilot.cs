using Newtonsoft.Json;

namespace XWS.NET;

public class Pilot
{
    [JsonProperty(PropertyName = "name")]

    public string Name { get; set; }

    [JsonProperty(PropertyName = "ship")]

    public string Ship { get; set; }

    [JsonProperty(PropertyName = "upgrades")]

    public Upgrades Upgrades { get; set; }
}

public class Upgrades
{
    [JsonProperty(PropertyName = "astromech")]
    public List<string> Astromech { get; set; }

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

    [JsonProperty(PropertyName = "title")]
    public List<string> Title { get; set; }

    [JsonProperty(PropertyName = "torpedo")]
    public List<string> Torpedo { get; set; }

    [JsonProperty(PropertyName = "turret")]
    public List<string> Turrets { get; set; }


}