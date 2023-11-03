using FlightApp.Application.Commands.Airports;
using FlightApp.Application.DTOs;
using MediatR;

namespace FlightApp.Application.Commands.Airports
{
    public class CreateAirportListCommand : IRequest<Unit>
    {
        public List<CreateAirportCommand> Airports { get; set; } = new List<CreateAirportCommand>();
    }
}
