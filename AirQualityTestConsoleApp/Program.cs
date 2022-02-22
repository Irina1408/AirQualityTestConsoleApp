using System;
using AirQualityTestConsoleApp.AirQuality;

namespace AirQualityTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // prepare
            var airQualityProvider = new AirQualityProvider();
            
            // get name of the city
            Console.Write("Please, enter the name of city to fetch current air quality: ");
            var city = Console.ReadLine();

            // try to get the air quality
            var response = airQualityProvider.GetCurrentQualityAsync(city).Result;

            if (response.Success)
            {
                // show quality on UI
                Console.WriteLine($"Current air quality in {city} is {response.AirQuality.Quality}");
            }
            else
            {
                // show an error on UI
                Console.WriteLine($"Cannot fetch the air quality for {city}");
                Console.WriteLine(string.Join("; ", response.Errors));
            }

            // finish
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}