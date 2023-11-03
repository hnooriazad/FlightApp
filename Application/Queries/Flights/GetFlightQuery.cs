using FlightApp.Domain.Entities;
using MediatR;

namespace FlightApp.Application.Queries.Flights
{
    public class GetFlightQuery : IRequest<Flight>
    {
        public Guid FlightId { get; set; }
    }
}
