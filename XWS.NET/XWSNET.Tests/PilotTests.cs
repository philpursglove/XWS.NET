﻿namespace XWSNET.Tests
{
    [TestFixture]
    public class PilotTests
    {
        private XWSConverter converter;

        [SetUp]
        public void Setup()
        {
            converter = new XWSConverter();
        }

        [TestCase("{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\"}]}", 1)]
        [TestCase("{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\"}, {\"id\":\"test\",\"name\":\"test\"}]}", 2)]
        [TestCase("{\"description\":\"\",\"faction\":\"\",\"name\":\"\",\"pilots\":[{\"id\":\"test\",\"name\":\"test\"}, {\"id\":\"test\",\"name\":\"test\"}, {\"id\":\"test\",\"name\":\"test\"}]}", 3)]
        public void Pilots_Are_Read_From_XWS_Formatted_Input(string xwsInput, int expectedCount)
        {
            var result = converter.FromJson(xwsInput);

            Assert.That(result.Pilots.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void Pilot_Equality()
        {
            Pilot pilot1 = new Pilot
            {
                Name = "Darth Vader",
                Ship = "TIE Advanced x1",
                Upgrades = new Upgrades{Talents = new List<string> {"Marksmanship", "Deadeye Shot"}}
            };

            Pilot pilot2 = new Pilot
            {
                Ship = "TIE Advanced x1",
                Upgrades = new Upgrades { Talents = new List<string> { "Deadeye Shot", "marksmanship" } },
                Name = "Darth Vader",
            };

            Assert.That(pilot1.Equals(pilot2), Is.True);
        }

        [Test]
        public void Configuration()
        {
            Pilot pilot1 = new Pilot
            {
                Name = "Darth Vader",
                Ship = "TIE Defender",
                Upgrades = new Upgrades { Configuration = new List<string>(){"TIE Defender Elite"} }
            };

            Assert.That(pilot1.Configuration(), Is.EqualTo("TIE Defender Elite"));
        }

        [Test]
        public void Title()
        {
            Pilot RAC = new Pilot()
            {
                Name = "Rear Admiral Chiraneau",
                Ship = "VT-49 Decimator",
                Upgrades = new Upgrades {Title = new List<string>() {"Dauntless"}}
            };

            Assert.That(RAC.Title(), Is.EqualTo("Dauntless"));
        }
    }
}
