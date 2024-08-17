using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter.Model
{
    class TemperatureModel
    {
        public double Celsius { get; set; }
        public double Fahrenheit { get; set; }
        public double Kelvin { get; set; }

        public void ConvertFromCelsius()
        {
            Fahrenheit = (Celsius * 9.0 / 5.0) + 32;
            Kelvin = Celsius + 273.15;
        }

        public void ConvertFromFahrenheit()
        {
            Celsius = (Fahrenheit - 32) * 5.0 / 9.0;
            Kelvin = ((Fahrenheit - 32) * 5.0 / 9.0) + 273.15;
        }

        public void ConvertFromKelvin()
        {
            Celsius = Kelvin - 273.15;
            Fahrenheit = (Fahrenheit - 32) * 5.0 / 9.0;
        }
        public void Reset()
        {
            Celsius = 0;
            Fahrenheit = (Celsius * 9.0 / 5.0) + 32; // Updated to reflect default value correctly
            Kelvin = Celsius + 273.15; // Updated to reflect default value correctly
        }

    }
}
