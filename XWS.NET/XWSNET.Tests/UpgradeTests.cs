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
    public void Astromech_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"astromech\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Astromech.Count, Is.EqualTo(1));
    }

    [Test]
    public void Cannon_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"cannon\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Cannons.Count, Is.EqualTo(1));
    }

    [Test]
    public void Device_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"device\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Devices.Count, Is.EqualTo(1));
    }

    [Test]
    public void Talent_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"talent\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Talents.Count, Is.EqualTo(1));
    }

    [Test]
    public void Modification_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"modification\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Modifications.Count, Is.EqualTo(1));
    }

}