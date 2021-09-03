using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController values = new WeatherForecastController();

        [Fact]
        public void GetMyName()
        {
            var name = values.Get(1);

            Assert.Equal("Umar 1", name.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
