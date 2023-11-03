using FlightApp.Application.DTOs;
using MediatR;

namespace FlightApp.Application.Commands.Flights
{
    public class CreateFlightCommand : IRequest<Unit>
    {
        public string FlightDate { get; set; }
        public string FlightStatus { get; set; }
        public InfoDto Departure { get; set; }
        public InfoDto Arrival { get; set; }
        public AirlineDto Airline { get; set; }
        public FlightDetailsDto FlightDetails { get; set; }
        public object Aircraft { get; set; }
        public object Live { get; set; }
    }
}
