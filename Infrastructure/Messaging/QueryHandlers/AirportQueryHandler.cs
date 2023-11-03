using FlightApp.Application.Queries.Airports;
using FlightApp.Domain.Entities;
using FlightApp.Infrastructure.Data.Context;
using FlightApp.Infrastructure.Data.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlightApp.Infrastructure.Messaging.QueryHandlers
{
    public class AirportQueryHandler : IRequestHandler<GetAirportQuery, Airport>, IRequestHandler<GetAllAirportQuery, List<Airport>>
    {
        private readonly FlightDbContext _dbContext;
        private readonly IAirportRepository _airportRepository;

        public AirportQueryHandler(FlightDbContext dbContext,IAirportRepository airportRepository)
        {
            _dbContext = dbContext;
            _airportRepository = airportRepository;
        }

        public async Task<Airport> Handle(GetAirportQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Airports.FindAsync(request.AirportId);
        }

        public async Task<List<Airport>> Handle(GetAllAirportQuery request, CancellationToken cancellationToken)
        {
            return await _airportRepository.GetAllAsync();
        }
    }
}
