namespace XWSNET.Tests
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
    }
}
