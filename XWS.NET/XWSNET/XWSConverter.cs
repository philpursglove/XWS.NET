using Newtonsoft.Json;

namespace XWSNET
{
    public class XWSConverter
    {
        public Squadron FromJson(string xwsJson)
        {
            Squadron squad = JsonConvert.DeserializeObject<Squadron>(xwsJson);

            squad.Faction = DecodeFaction(squad.Faction);

            return squad;
        }

        private string DecodeFaction(string squadFaction)
        {
            switch (squadFaction)
            {
                case "galacticempire":
                    return "Galactic Empire";
                case "rebelalliance":
                    return "Rebel Alliance";
                case "firstorder":
                    return "First Order";
                case "scumandvillainy":
                    return "Scum And Villainy";
                case "resistance":
                    return "Resistance";
                case "galacticrepublic":
                    return "Galactic Republic";
                case "separatistalliance":
                    return "Separatist Alliance";
                default:
                    return string.Empty;
            }
        }
    }
}
