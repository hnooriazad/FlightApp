using Newtonsoft.Json;

namespace FlightApp.Application.DTOs
{
    public class FlightDto
    {
        public Guid FlightId { get; set; }
        public string FlightDate { get; set; }
        public string FlightStatus { get; set; }
        public InfoDto Departure { get; set; }
        public InfoDto Arrival { get; set; }
        public AirlineDto Airline { get; set; }
        public FlightDetailsDto FlightDetails { get; set; }
        public AircraftDto Aircraft { get; set; }
        public LiveDto Live { get; set; }
    }

    public class InfoDto
    {
        [JsonProperty("airport", NullValueHandling = NullValueHandling.Ignore)]
        public string Airport { get; set; }
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }
        [JsonProperty("iata", NullValueHandling = NullValueHandling.Ignore)]
        public string Iata { get; set; }
        [JsonProperty("icao", NullValueHandling = NullValueHandling.Ignore)]
        public string Icao { get; set; }
        [JsonProperty("terminal", NullValueHandling = NullValueHandling.Ignore)]
        public string Terminal { get; set; }
        [JsonProperty("gate", NullValueHandling = NullValueHandling.Ignore)]
        public string Gate { get; set; }
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public long Delay { get; set; }
        [JsonProperty("scheduled", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Scheduled { get; set; }
        [JsonProperty("estimated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Estimated { get; set; }
        [JsonProperty("actual", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Actual { get; set; }
        [JsonProperty("estimated_runway", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Estimated_runway { get; set; }
        [JsonProperty("actual_runway", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Actual_runway { get; set; }
    }

    public class AirlineDto
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        [JsonProperty("iata", NullValueHandling = NullValueHandling.Ignore)]
        public string Iata { get; set; }
        [JsonProperty("icao", NullValueHandling = NullValueHandling.Ignore)]
        public string Icao { get; set; }
    }

    public class FlightDetailsDto
    {
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }
        [JsonProperty("iata", NullValueHandling = NullValueHandling.Ignore)]
        public string Iata { get; set; }
        [JsonProperty("icao", NullValueHandling = NullValueHandling.Ignore)]
        public string Icao { get; set; }
        [JsonProperty("codeshared", NullValueHandling = NullValueHandling.Ignore)]

        public CodesharedDto Codeshared { get; set; }
    }

    public class CodesharedDto
    {
        [JsonProperty("airline_name", NullValueHandling = NullValueHandling.Ignore)]
        public string Airline_name { get; set; }
        [JsonProperty("airline_iata", NullValueHandling = NullValueHandling.Ignore)]
        public string Airline_iata { get; set; }
        [JsonProperty("airline_icao", NullValueHandling = NullValueHandling.Ignore)]
        public string Airline_icao { get; set; }
        [JsonProperty("flight_number", NullValueHandling = NullValueHandling.Ignore)]
        public string Flight_number { get; set; }
        [JsonProperty("flight_iata", NullValueHandling = NullValueHandling.Ignore)]
        public string Flight_iata { get; set; }
        [JsonProperty("flight_icao", NullValueHandling = NullValueHandling.Ignore)]
        public string Flight_icao { get; set; }
    }
    public class AircraftDto
    {
        [JsonProperty("registration", NullValueHandling = NullValueHandling.Ignore)]
        public string? Registration { get; set; }
        [JsonProperty("iata", NullValueHandling = NullValueHandling.Ignore)]
        public string? Iata { get; set; }
        [JsonProperty("icao", NullValueHandling = NullValueHandling.Ignore)]
        public string? Icao { get; set; }
        [JsonProperty("icao24", NullValueHandling = NullValueHandling.Ignore)]
        public string? Icao24 { get; set; }
    }
    public class LiveDto
    {
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public float Latitude { get; set; }
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public float Longitude { get; set; }
        [JsonProperty("altitude", NullValueHandling = NullValueHandling.Ignore)]
        public float Altitude { get; set; }
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public float Direction { get; set; }
        [JsonProperty("speed_horizontal", NullValueHandling = NullValueHandling.Ignore)]
        public float Speed_horizontal { get; set; }
        [JsonProperty("speed_vertical", NullValueHandling = NullValueHandling.Ignore)]
        public float Speed_vertical { get; set; }
        [JsonProperty("is_ground", NullValueHandling = NullValueHandling.Ignore)]
        public bool Is_ground { get; set; }
    }
}
