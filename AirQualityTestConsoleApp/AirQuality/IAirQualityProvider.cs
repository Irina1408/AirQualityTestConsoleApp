using System.Threading.Tasks;
using AirQualityTestConsoleApp.AirQuality.Domain;

namespace AirQualityTestConsoleApp.AirQuality
{
    public interface IAirQualityProvider
    {
        Task<AirQualityResponse> GetCurrentQualityAsync(string city);
    }
}