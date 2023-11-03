namespace FlightApp.Application.DTOs
{
    public class AirportDto
    {
        public Guid FlightId { get; set; }
        public string Airport_name { get; set; }
        public string Iata_code { get; set; }
        public string Icao_code { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Geoname_id { get; set; }
        public string Timezone { get; set; }
        public string Gmt { get; set; }
        public string Phone_number { get; set; }
        public string Country_name { get; set; }
        public string Country_iso2 { get; set; }
        public string City_iata_code { get; set; }
    }
}
