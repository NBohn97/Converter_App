using System;

namespace Converter_App
{
    public class Temperatures
    {
        
        protected double Temp { get; set; }

        public Temperatures(double temp)
        {
            this.Temp = temp;
        }

        public double CelsiusToKelvin()
        {
            var celsius = Temp;
            var kelvin = Math.Round(celsius + 273.15,2);
            
            return kelvin;
        }
        
        public double KelvinToCelsius()
        {
            return 0;
        }
        
        public double CelsiusToFahrenheit()
        {
            return 0;
        }
        
        public double FahrenheitToCelsius()
        {
            return 0;
        }
        
        public double FahrenheitToKelvin()
        {
            return 0;
        }
        
        public double KelvinToFahrenheit()
        {
            return 0;
        }

        public static double TempInput()
        {
            double tempInputVal;
            Console.WriteLine("Enter a Temperature: ");
            string tempInputValString = Console.ReadLine();
            double.TryParse(tempInputValString, out tempInputVal);
            return tempInputVal;
        }
        
        
    }
}