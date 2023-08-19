using Newtonsoft.Json;

namespace XWSNET
{
    public class Squadron
    {
        [JsonProperty(PropertyName = "faction")]
        public string Faction { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "pilots")]

        public List<Pilot> Pilots { get; set; }

        public bool Equals(Squadron compareSquadron)
        {
            return (String.Equals(this.Faction, compareSquadron.Faction, StringComparison.InvariantCultureIgnoreCase) && 
                this.Pilots.OrderBy(p => p.Name).SequenceEqual(compareSquadron.Pilots.OrderBy(p => p.Name)));
        }
    }
}