namespace FlightApp.Presentation.Models
{
    public class FlightSearchInputModel
    {
        public string? callback { get; set; }
        public long? limit { get; set; } = 100;
        public long? offset { get; set; } = 0;
        public string? flight_status { get; set; }
        public string? flight_date { get; set; }
        public string? dep_iata { get; set; }
        public string? arr_iata { get; set; }
        public string? dep_icao { get; set; }
        public string? arr_icao { get; set; }
        public string? airline_iata { get; set; }
        public string? airline_icao { get; set; }
        public string? flight_number { get; set; }
        public string? flight_iata { get; set; }
        public string? flight_icao { get; set; }
        public string? min_delay_dep { get; set; }
        public string? min_delay_arr { get; set; }
        public string? max_delay_dep { get; set; }
        public string? max_delay_arr { get; set; }
        public string? arr_scheduled_time_arr { get; set; }
        public string? arr_scheduled_time_dep { get; set; }
    }
}
