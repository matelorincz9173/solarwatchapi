using SolarwatchAPI.Controllers;
using SolarwatchAPI.Model;

namespace SolarWatchTest;

public class SolarControllerTest
{

    private SolarController _solarController;

    [SetUp]
    public void SetUp()
    {
        _solarController = new SolarController();
    }

    [Test]
    public async Task CorrectInputTest1()
    {
        var solarData1 = await _solarController.GetSunrise("szeged", new DateTime(2023, 05, 20));

        Assert.That(solarData1.City, Is.EqualTo("szeged"));
    }
    
    [Test]
    public async Task CorrectInputTest2()
    {
        var solarData1 = await _solarController.GetSunset("szeged", new DateTime(2023, 05, 20));

        Assert.That(solarData1.City, Is.EqualTo("szeged"));
    }
}