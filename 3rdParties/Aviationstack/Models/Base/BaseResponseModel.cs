using Newtonsoft.Json;

namespace FlightApp._3rdParties.Aviationstack.Models.Base
{
    public class BaseResponseModel<T>
        where T : class
    {

        [JsonProperty("pagination", NullValueHandling = NullValueHandling.Ignore)]
        public PaginationModel Pagination { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public T Data { get; set; }

        public class PaginationModel
        {
            public int limit { get; set; }
            public int offset { get; set; }
            public int count { get; set; }
            public int total { get; set; }
        }
    }
}
