using FlightApp.Domain.Entities;
using MediatR;

namespace FlightApp.Application.Queries.Airports
{
    public class GetAllAirportQuery : IRequest<List<Airport>>
    {
    }
}
