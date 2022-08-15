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

}