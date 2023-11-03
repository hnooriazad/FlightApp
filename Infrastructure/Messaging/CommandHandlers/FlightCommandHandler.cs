using AutoMapper;
using FlightApp.Application.Commands.Flights;
using FlightApp.Domain.Entities;
using FlightApp.Infrastructure.Data.Context;
using FlightApp.Infrastructure.Data.Repositories;
using MediatR;

namespace FlightApp.Infrastructure.Messaging.CommandHandlers
{
    public class FlightCommandHandler : IRequestHandler<CreateFlightListCommand, Unit>
    {
        private readonly FlightDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IFlightRepository _flightRepository;

        public FlightCommandHandler(FlightDbContext dbContext, IMapper mapper, IFlightRepository flightRepository)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _flightRepository = flightRepository;
        }

        public async Task<Unit> Handle(CreateFlightListCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var newFlights = _mapper.Map<List<Flight>>(request.Flights);
                await _flightRepository.AddListAsync(newFlights);
                return Unit.Value;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
