namespace XWSNET.Tests
{
    public class SquadronTests
    {
        XWSConverter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new XWSConverter();
        }

        [Test]
        public void Squadron_Details_Are_Read_From_An_XWS_Formatted_Input()
        {
            var result =
                _converter.FromJson(
                    "{\"description\":\"Test Description\",\"faction\":\"galacticempire\",\"name\":\"Test Squadron\"}");

            Assert.That(result.Name, Is.EqualTo("Test Squadron"));
            Assert.That(result.Description, Is.EqualTo("Test Description"));
        }

        [TestCase("galacticempire", "Galactic Empire")]
        [TestCase("scumandvillainy", "Scum And Villainy")]
        [TestCase("firstorder", "First Order")]
        [TestCase("rebelalliance", "Rebel Alliance")]
        [TestCase("resistance", "Resistance")]
        [TestCase("galacticrepublic", "Galactic Republic")]
        [TestCase("separatistalliance", "Separatist Alliance")]
        public void Squadron_Faction_Is_Humanised(string unformattedFaction, string formattedFaction)
        {
            var result =
                _converter.FromJson(
                    "{\"description\":\"Test Description\",\"faction\":\"[FACTION]\",\"name\":\"Test Squadron\"}".Replace("[FACTION]", unformattedFaction));

            Assert.That(result.Faction, Is.EqualTo(formattedFaction));
        }

        [Test]
        public void Squadron_Equality()
        {
            Squadron squadron1 = new Squadron
            {
                Name = "Test Squadron",
                Description = "Test Description",
                Faction = "Galactic Empire",
                Pilots = new List<Pilot>
                {
                    new Pilot
                    {
                        Name = "Darth Vader",
                        Ship = "TIE Advanced x1",
                        Upgrades = new Upgrades
                        {
                            Talents = new List<string> {"Marksmanship", "Deadeye Shot"}
                        }
                    }
                }
            };

            Squadron squadron2 = new Squadron
            {
                Name = "Test Squadron",
                Description = "Test Description",
                Faction = "Galactic Empire",
                Pilots = new List<Pilot>
                {
                    new Pilot
                    {
                        Name = "Darth Vader",
                        Ship = "TIE Advanced x1",
                        Upgrades = new Upgrades
                        {
                            Talents = new List<string> {"Deadeye Shot", "Marksmanship"}
                        }
                    }
                }
            };

            Assert.That(squadron1.Equals(squadron2), Is.True);
        }
    }
}
