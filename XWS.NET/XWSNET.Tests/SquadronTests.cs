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
    }
}