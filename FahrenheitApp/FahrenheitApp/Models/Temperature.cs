using System;

namespace FahrenheitApp.Models
{
    public static class Temperature
    {
        public static double CelciusToFahrenheit(double Tc)
        {
            double Tf;

            Tf = 9 / 5 * Tc + 32;

            return Tf;
        }

    }
}