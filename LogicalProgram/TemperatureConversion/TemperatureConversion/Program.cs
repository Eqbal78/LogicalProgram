using System;

namespace TemperatureConversion
{
    class Program
    {
        static double fahrenheit, celsius;
        static double Celsius()
        {

            Console.WriteLine("Enter the Temperature in Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9) / 5 + 32;
            return fahrenheit;
            
        }

        static double Fahrenheit()
        {
            Console.WriteLine("Enter the Temperature in Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        static void Main(string[] args)
        { 
            
            Console.WriteLine("Temperature in Fahrenheit: " + Celsius());
            Console.WriteLine();
            Console.WriteLine("Temperature in Celsius: " + Fahrenheit());

        }
    }
}
