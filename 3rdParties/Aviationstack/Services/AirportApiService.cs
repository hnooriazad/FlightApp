using FlightApp._3rdParties.Aviationstack.Models;
using FlightApp._3rdParties.Aviationstack.Models.Base;
using FlightApp.Application.DTOs;
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
            RestClient client = new RestClient();
            RestRequest request = new RestRequest(_getAllAirportsUrl);
            GetAllAirportsRequestModel requestModel = new GetAllAirportsRequestModel();
            request.AddJsonBody(requestModel);


            RestResponse response = await client.ExecuteAsync(request);
            if (response != null && response.IsSuccessful && response.Content != null)
            {
                var result = JsonConvert.DeserializeObject<BaseResponseModel<List<GetAllAirportsResponseModel>>>(response.Content);

                return result;
            }
            return await Task.FromResult<BaseResponseModel<List<GetAllAirportsResponseModel>>>(null);
        }

        public static async Task<BaseResponseModel<List<GetAllAirportsResponseModel>>> GetAirportsByFilterAsync(GetAllAirportsRequestModel getAllAirportsRequestModel)
        {
            try
            {

                RestClient client = new RestClient();
                string querySringResult = getAllAirportsRequestModel.CreateQueryStringFromObject();
                RestRequest request = new RestRequest(_getAllAirportsUrl + querySringResult);


                RestResponse response = await client.ExecuteAsync(request);
                if (response != null && response.IsSuccessful && response.Content != null)
                {
                    var result = JsonConvert.DeserializeObject<BaseResponseModel<List<GetAllAirportsResponseModel>>>(response.Content);

                    return result;
                }
                return await Task.FromResult<BaseResponseModel<List<GetAllAirportsResponseModel>>>(null);
            }
            catch (Exception ex)
            {
                throw;
                //handle Exception
            }
        }
    }
}
