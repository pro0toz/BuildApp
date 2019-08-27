using System.Linq;
using BuildApp.Web.Controllers;
using Xunit;

namespace BuildApp.Web.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new SampleDataController();
            var result = controller.WeatherForecasts();

            Assert.Equal(5, result.Count());
        }
    }
}
