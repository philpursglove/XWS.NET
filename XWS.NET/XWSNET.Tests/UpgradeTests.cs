namespace XWSNET.Tests;

[TestFixture]
public class UpgradeTests
{
    private XWSConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new XWSConverter();
    }

    [Test]
    public void Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"talent\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Talents.Count, Is.EqualTo(1));
    }

}