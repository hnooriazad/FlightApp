using AutoMapper;
using FlightApp._3rdParties.Aviationstack.Models;
using FlightApp._3rdParties.Aviationstack.Models.Base;
using FlightApp.Application.DTOs;
using FlightApp.Presentation.Models;
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
            try
            {

                RestClient client = new RestClient();
                GetAllFlightsRequestModel requestModel = new GetAllFlightsRequestModel();
                string querySringResult = requestModel.CreateQueryStringFromObject();
                RestRequest request = new RestRequest(_getAllFlightsUrl + querySringResult);



                RestResponse response = await client.ExecuteAsync(request);
                if (response != null && response.IsSuccessful && response.Content != null)
                {
                    var result = JsonConvert.DeserializeObject<BaseResponseModel<List<GetAllFlightsResponseModel>>>(response.Content);

                    return result;
                }
                return await Task.FromResult<BaseResponseModel<List<GetAllFlightsResponseModel>>>(null);
            }
            catch (Exception ex)
            {
                throw;
                //handle Exeption
            }
        }
        public static async Task<BaseResponseModel<List<GetAllFlightsResponseModel>>> GetFlightsByFilterAsync(GetAllFlightsRequestModel getAllFlightsRequestModel)
        {
            try
            {

                RestClient client = new RestClient();
                //GetAllFlightsRequestModel requestModel = new GetAllFlightsRequestModel();
                string querySringResult = getAllFlightsRequestModel.CreateQueryStringFromObject();
                RestRequest request = new RestRequest(_getAllFlightsUrl + querySringResult);


                RestResponse response = await client.ExecuteAsync(request);
                if (response != null && response.IsSuccessful && response.Content != null)
                {
                    var result = JsonConvert.DeserializeObject<BaseResponseModel<List<GetAllFlightsResponseModel>>>(response.Content);

                    return result;
                }
                return await Task.FromResult<BaseResponseModel<List<GetAllFlightsResponseModel>>>(null);
            }
            catch (Exception ex)
            {
                throw;
                //handle Exception
            }
        }
    }
}
