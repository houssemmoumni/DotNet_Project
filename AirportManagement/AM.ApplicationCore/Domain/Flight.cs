using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        String Destination { get; set; }
        String Departure { get; set; }
        DateTime FlightDate   { get; set; }
        int FlightId { get; set; }
        DateTime EffectiveArrival {  get; set; }
        int EstimatedDuration { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public Plane Plane { get; set; }

        public override string? ToString()
        {
            return "FlightDate:" + FlightDate
                 + "Destination:" + Destination
                 + "EstimatedDuration:" + EstimatedDuration;
        }
    }
}
