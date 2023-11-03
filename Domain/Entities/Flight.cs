using Newtonsoft.Json;

namespace FlightApp.Domain.Entities
{
    public class Flight
    {
        public Guid? Id { get; set; } = Guid.NewGuid();
        public string? FlightDate { get; set; }
        public string? FlightStatus { get; set; }
        public Info? Departure { get; set; }
        public Info? Arrival { get; set; }
        public Airline? Airline { get; set; }
        public FlightDetails FlightDetails { get; set; } = new FlightDetails();
        public Aircraft? Aircraft { get; set; }
        public Live? Live { get; set; }
    }
    public class Info
    {
        public string? Airport { get; set; }
        public string? Timezone { get; set; }
        public string? Iata { get; set; }
        public string? Icao { get; set; }
        public string? Terminal { get; set; }
        public string? Gate { get; set; }
        public long? Delay { get; set; }
        public DateTime? Scheduled { get; set; }
        public DateTime? Estimated { get; set; }
        public DateTime? Actual { get; set; }
        public DateTime? Estimated_runway { get; set; }
        public DateTime? Actual_runway { get; set; }
    }

    public class Airline
    {
        public string? Name { get; set; }
        public string? Iata { get; set; }
        public string? Icao { get; set; }
    }

    public class FlightDetails
    {
        public string? Number { get; set; }
        public string? Iata { get; set; }
        public string? Icao { get; set; }
        public Codeshared? Codeshared { get; set; }
    }

    public class Codeshared
    {
        public string? Airline_name { get; set; }
        public string? Airline_iata { get; set; }
        public string? Airline_icao { get; set; }
        public string? Flight_number { get; set; }
        public string? Flight_iata { get; set; }
        public string? Flight_icao { get; set; }
    }
    public class Aircraft
    {
        public string Registration { get; set; }
        public string Iata { get; set; }
        public string Icao { get; set; }
        public string Icao24 { get; set; }
    }
    public class Live
    {
        public DateTime? Updated { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float Altitude { get; set; }
        public float Direction { get; set; }
        public float Speed_horizontal { get; set; }
        public float Speed_vertical { get; set; }
        public bool Is_ground { get; set; }
    }


}
