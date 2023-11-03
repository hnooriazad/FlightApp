using FlightApp.Domain.Entities;
using MediatR;

namespace FlightApp.Application.Queries.Flights
{
    public class GetAllFlightQuery : IRequest<List<Flight>>
    {
    }
}
