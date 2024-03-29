﻿namespace XWSNET.Tests;

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
    public void Cargo_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"cargo\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Cargo.Count, Is.EqualTo(1));
    }

    [Test]
    public void Command_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"command\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Commands.Count, Is.EqualTo(1));
    }

    [Test]
    public void Configuration_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"configuration\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Configuration.Count, Is.EqualTo(1));
    }

    [Test]
    public void Crew_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"crew\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Crew.Count, Is.EqualTo(1));
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
    public void Force_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"force-power\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.ForcePowers.Count, Is.EqualTo(1));
    }

    [Test]
    public void Gunner_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"gunner\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Gunners.Count, Is.EqualTo(1));
    }

    [Test]
    public void Hardpoint_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"hardpoint\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Hardpoints.Count, Is.EqualTo(1));
    }

    [Test]
    public void Illicit_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"illicit\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Illicit.Count, Is.EqualTo(1));
    }

    [Test]
    public void Missile_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"missile\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Missiles.Count, Is.EqualTo(1));
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

    [Test]
    public void Sensor_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"sensor\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Sensors.Count, Is.EqualTo(1));
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
    public void Team_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"team\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Teams.Count, Is.EqualTo(1));
    }

    [Test]
    public void Tech_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"tech\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Tech.Count, Is.EqualTo(1));
    }

    [Test]
    public void Title_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"title\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Title.Count, Is.EqualTo(1));
    }

    [Test]
    public void Torpedo_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"torpedo\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Torpedoes.Count, Is.EqualTo(1));
    }

    [Test]
    public void Turret_Upgrade_Details_Are_Read_From_An_XWS_Formatted_Input()
    {
        var result =
            converter.FromJson(
                "{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\", \"upgrades\":{\"turret\":[\"test\"]}}]}");

        Pilot pilot = result.Pilots.First();

        Assert.That(pilot.Upgrades.Turrets.Count, Is.EqualTo(1));
    }
}