using System;

namespace AirQualityTestConsoleApp.AirQuality.Domain
{
    /// <summary>
    /// Data that is fetched from the https://aqicn.org/api/
    /// NOTE: property names starts from lowercase correspond to API documentation
    /// </summary>
    internal class AirQualityApiResponse
    {
        /// <summary>
        /// Status code, can be ok or error.
        /// </summary>
        public string status { get; set; }
        
        /// <summary>
        /// Station data (Contains <see cref="AirQualityData"/> if <see cref="status"/> is "ok" and error message in other case)
        /// </summary>
        public object data { get; set; }
    }

    internal class AirQualityData
    {
        /// <summary>
        /// Unique ID for the city monitoring station.
        /// </summary>
        public int idx { get; set; }
        
        /// <summary>
        /// Unique ID for the city monitoring station.
        /// </summary>
        public int aqi { get; set; }
        
        /// <summary>
        /// Forecast data
        /// </summary>
        public AirQualityForecast forecast { get; set; }
    }
    
    internal class AirQualityForecast
    {
        /// <summary>
        /// daily forecast data
        /// </summary>
        public AirQualityDailyForecast daily { get; set; }
    }

    internal class AirQualityDailyForecast
    {
        /// <summary>
        /// PM2.5 forecast
        /// </summary>
        public AirQualityInfo[] pm25 { get; set; }
        
        /// <summary>
        /// PM10 forecast
        /// </summary>
        public AirQualityInfo[] pm10 { get; set; }
        
        /// <summary>
        /// Ozone forecast
        /// </summary>
        public AirQualityInfo[] o3 { get; set; }
        
        /// <summary>
        /// Ultra Violet Index forecast
        /// </summary>
        public AirQualityInfo[] uvi { get; set; }
    }

    internal class AirQualityInfo
    {
        public int avg { get; set; }
        public DateTime day { get; set; }
        public int max { get; set; }
        public int min { get; set; }
    }
}