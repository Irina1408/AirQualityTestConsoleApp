using System.Linq;

namespace AirQualityTestConsoleApp.AirQuality.Domain
{
    public class AirQualityResponse
    {
        public AirQualityResponse(params string[] errors)
        {
            Success = !errors?.Any() ?? true;
            Errors = errors;
        }
        
        public AirQualityModel AirQuality { get; set; }

        public bool Success { get; }
        public string[] Errors { get; }
    }
}