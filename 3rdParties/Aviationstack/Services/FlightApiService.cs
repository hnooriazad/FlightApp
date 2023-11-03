using FlightApp._3rdParties.Aviationstack.Models;
using FlightApp._3rdParties.Aviationstack.Models.Base;
using FlightApp.Utility;
using Newtonsoft.Json;
using RestSharp;

namespace FlightApp._3rdParties.Aviationstack.Services
{
    public static partial class FlightApiService
    {
        private static readonly string _getAllFlightsUrl = Config.BaseUrl + "flights";
        public static async Task<BaseResponseModel<List<GetAllFlightsResponseModel>>> GetAllFlightsAsync()
        {
            string requestUrl = _getAllFlightsUrl + $"?access_key={Config.AccessKey}";
            return await SendRequestAsync(requestUrl);
        }

        public static async Task<BaseResponseModel<List<GetAllFlightsResponseModel>>> GetFlightsByFilterAsync(GetAllFlightsRequestModel getAllFlightsRequestModel)
        {
            string requestUrl = _getAllFlightsUrl + getAllFlightsRequestModel.CreateQueryStringFromObject();
            return await SendRequestAsync(requestUrl);
        }

        public static async Task<BaseResponseModel<List<GetAllFlightsResponseModel>>> SendRequestAsync(string requestUrl)
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest(requestUrl);
            RestResponse response = await client.ExecuteAsync(request);

            if (response != null && response.IsSuccessful && response.Content != null)
            {
                return JsonConvert.DeserializeObject<BaseResponseModel<List<GetAllFlightsResponseModel>>>(response.Content);
            }

            return null;
        }
    }
}
