namespace FlightApp._3rdParties.Aviationstack.Models.Base
{
    public class BaseRequestModel
    {
        public string access_key { get; set; } = Config.AccessKey;
        public long? limit { get; set; } = 100;
        public long? offset { get; set; } = 0;

    }
}
