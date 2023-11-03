namespace FlightApp.Presentation.Models
{
    public class AirportSearchInputModel
    {
        public string? callback { get; set; }
        public long? limit { get; set; } = 100;
        public long? offset { get; set; } = 0;
        public string? search { get; set; }
    }
}
