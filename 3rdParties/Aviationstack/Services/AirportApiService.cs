using FlightApp._3rdParties.Aviationstack.Models;
using FlightApp._3rdParties.Aviationstack.Models.Base;
using FlightApp.Utility;
using Newtonsoft.Json;
using RestSharp;

namespace FlightApp._3rdParties.Aviationstack.Services
{
    public static partial class AirportApiService
    {
        private static readonly string _getAllAirportsUrl = Config.BaseUrl + "airports";
        public static async Task<BaseResponseModel<List<GetAllAirportsResponseModel>>> GetAllAirportsAsync()
        {
            string requestUrl = _getAllAirportsUrl + $"?access_key={Config.AccessKey}";
            return await SendRequestAsync(requestUrl);
        }

        public static async Task<BaseResponseModel<List<GetAllAirportsResponseModel>>> GetAirportsByFilterAsync(GetAllAirportsRequestModel getAllAirportsRequestModel)
        {
            string requestUrl = _getAllAirportsUrl + getAllAirportsRequestModel.CreateQueryStringFromObject();
            return await SendRequestAsync(requestUrl);
        }

        public static async Task<BaseResponseModel<List<GetAllAirportsResponseModel>>> SendRequestAsync(string requestUrl)
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest(requestUrl);
            RestResponse response = await client.ExecuteAsync(request);

            if (response != null && response.IsSuccessful && response.Content != null)
            {
                return JsonConvert.DeserializeObject<BaseResponseModel<List<GetAllAirportsResponseModel>>>(response.Content);
            }

            return null;
        }
    }
}
