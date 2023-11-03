using MediatR;

namespace FlightApp.Application.Commands.Airports
{
    public class DeleteAirportCommand : IRequest<Unit>
    {
        public Guid AirportId { get; set; }
    }
}
