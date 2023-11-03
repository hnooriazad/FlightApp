using FlightApp._3rdParties.Aviationstack.Models.Base;
using Newtonsoft.Json;

namespace FlightApp._3rdParties.Aviationstack.Models
{
    public class GetAllAirportsResponseModel
    {

        [JsonProperty("airport_name", NullValueHandling = NullValueHandling.Ignore)]
        public string Airport_name { get; set; }
        [JsonProperty("iata_code", NullValueHandling = NullValueHandling.Ignore)]
        public string Iata_code { get; set; }
        [JsonProperty("icao_code", NullValueHandling = NullValueHandling.Ignore)]
        public string Icao_code { get; set; }
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }
        [JsonProperty("geoname_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Geoname_id { get; set; }
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; set; }
        [JsonProperty("gmt", NullValueHandling = NullValueHandling.Ignore)]
        public string Gmt { get; set; }
        [JsonProperty("phone_number", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone_number { get; set; }
        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string Country_name { get; set; }
        [JsonProperty("country_iso2", NullValueHandling = NullValueHandling.Ignore)]
        public string Country_iso2 { get; set; }
        [JsonProperty("city_iata_code", NullValueHandling = NullValueHandling.Ignore)]
        public string City_iata_code { get; set; }
    }
}
