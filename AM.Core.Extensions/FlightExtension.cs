using AM.Core.Domain;
using System.Runtime.CompilerServices;

namespace AM.Core.Extensions
{
    public static class FlightExtension
    {
        public static int GetDelay(this Flight flight)
        {
            return (flight.EffectiveArrival - flight.FlightDate)
                .Minutes - flight.EstimatedDuration;

        }
    }
}