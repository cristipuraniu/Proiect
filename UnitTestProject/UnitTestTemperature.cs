using Microsoft.VisualStudio.TestTools.UnitTesting;
using FahrenheitApp.Models;

namespace UnitTestTemperature
{
    [TestClass]
    public class UnitTestFahrenheit
    {
        [TestMethod]
        public void TestFahrenheitConversion()
        {
            double temperatureCelcius = 22;
            double temperatureFahrenheitActual;
            double temperatureFahrenheitExpected = 71.6;

            temperatureFahrenheitActual = Temperature.CelciusToFahrenheit(temperatureCelcius);

            Assert.AreEqual(temperatureFahrenheitExpected, temperatureFahrenheitActual, 0.001, "Temperature conversion not correctly");
        }
    }
}