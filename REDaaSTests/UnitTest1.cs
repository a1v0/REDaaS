using REDaaS;

namespace REDaaSTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, WeatherForecast.Adder(1, 1));
            Assert.AreEqual(2, WeatherForecast.Adder(1, 3));
        }
    }
}