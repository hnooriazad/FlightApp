using FlightApp.Application.DTOs;
using MediatR;

namespace FlightApp.Application.Commands.Flights
{
    public class CreateFlightListCommand : IRequest<Unit>
    {
        public List<CreateFlightCommand> Flights { get; set; } = new List<CreateFlightCommand>();
    }
}
