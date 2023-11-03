using AutoMapper;
using FlightApp._3rdParties.Aviationstack.Models;
using FlightApp.Application.Commands.Flights;
using FlightApp.Application.DTOs;
using FlightApp.Domain.Entities;
using FlightApp.Presentation.Models;

namespace FlightApp.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Flight, FlightDto>()
                .ForMember(dest => dest.FlightId, src => src.MapFrom(ar => ar.Id))
                .ReverseMap();
            CreateMap<GetAllFlightsResponseModel, CreateFlightCommand>().ReverseMap();
            CreateMap<FlightDetail, FlightDetailsDto>().ReverseMap();
            CreateMap<_3rdParties.Aviationstack.Models.Info, InfoDto>().ReverseMap();
            CreateMap<_3rdParties.Aviationstack.Models.Airline, AirlineDto>().ReverseMap();
            CreateMap<_3rdParties.Aviationstack.Models.Live, LiveDto>().ReverseMap();
            CreateMap<_3rdParties.Aviationstack.Models.Aircraft, AircraftDto>().ReverseMap();
            CreateMap<_3rdParties.Aviationstack.Models.Codeshared, CodesharedDto>().ReverseMap();

            CreateMap<Flight, CreateFlightCommand>().ReverseMap();
            CreateMap<FlightDetails, FlightDetailsDto>().ReverseMap();
            CreateMap<Domain.Entities.Info, InfoDto>().ReverseMap();
            CreateMap<Domain.Entities.Airline, AirlineDto>().ReverseMap();
            CreateMap<Domain.Entities.Aircraft, AircraftDto>().ReverseMap();
            CreateMap<Domain.Entities.Live, LiveDto>().ReverseMap();
            CreateMap<Domain.Entities.Codeshared, CodesharedDto>().ReverseMap();

            CreateMap<FlightSearchInputModel, GetAllFlightsRequestModel>().ReverseMap();


            CreateMap<Airport, AirportDto>().ReverseMap();
        }
    }
}
