using AutoMapper;
using FlightApp.Application.Commands.Airports;
using FlightApp.Domain.Entities;
using FlightApp.Infrastructure.Data.Context;
using FlightApp.Infrastructure.Data.Repositories;
using MediatR;

namespace FlightApp.Infrastructure.Messaging.CommandHandlers
{
    public class AirportCommandHandler : IRequestHandler<CreateAirportListCommand, Unit>
    {
        private readonly FlightDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IAirportRepository _airportRepository;

        public AirportCommandHandler(FlightDbContext dbContext, IMapper mapper, IAirportRepository airportRepository)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _airportRepository = airportRepository;
        }

        public async Task<Unit> Handle(CreateAirportListCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var newAirports = _mapper.Map<List<Airport>>(request.Airports);
                await _airportRepository.AddListAsync(newAirports);
                return Unit.Value;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
