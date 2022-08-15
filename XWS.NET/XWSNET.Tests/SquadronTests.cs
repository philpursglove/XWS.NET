namespace XWSNET.Tests
{
    public class SquadronTests
    {
        XWSConverter converter;

        [SetUp]
        public void Setup()
        {
            converter = new XWSConverter();
        }

        [Test]
        public void Squadron_Details_Are_Read_From_An_XWS_Formatted_Input()
        {
            var result =
                converter.FromJson(
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
                converter.FromJson(
                    "{\"description\":\"Test Description\",\"faction\":\"[FACTION]\",\"name\":\"Test Squadron\"}".Replace("[FACTION]", unformattedFaction));

            Assert.That(result.Faction, Is.EqualTo(formattedFaction));
        }
    }
}