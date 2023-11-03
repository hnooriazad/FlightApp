using FlightApp.Domain.Entities;
using MediatR;

namespace FlightApp.Application.Queries.Airports
{
    public class GetAirportQuery : IRequest<Airport>
    {
        public Guid AirportId { get; set; }
    }
}
